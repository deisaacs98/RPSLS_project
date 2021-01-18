using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public User player1;
        public Player player2;

        public Game()
        {
            player1 = new User();
        }

        public void StartGame()
        {
            Console.SetWindowSize(120, 40);
            player1.AddGesturesToList();
            Menu.Title();
            int numberOfPlayers=player1.SelectNumberOfPlayers();
            if (numberOfPlayers == 1)
            {
                player2 = new CPU();
            }
            else
            {
                player2 = new User();
            }
        }

        public void Run()
        {
            StartGame();
            bool playGame = true;
            while (playGame)
            {
                while ((player1.wins < 2) && (player2.wins < 2))
                {
                    int player1Gesture = player1.ChooseGesture();
                    int player2Gesture = player2.ChooseGesture();
                    Menu.BattleCountdown();
                    if (player1Gesture == player2Gesture)
                    {
                        Menu.DisplayTie();
                    }
                    else
                    {
                        CompareGestures(player1Gesture, player2Gesture);
                    }
                }
                CheckMatchWinner(player1);
                string replay = Menu.PlayAgain();
                if (replay == "Y" || replay == "y")
                {
                    player1.wins = 0;
                    player2.wins = 0;
                }
                else
                {
                    playGame = false;
                    break;
                }
            }
        }

        public void CompareGestures(int gesture1, int gesture2)
        {
            switch (gesture1)
            {
                case 0:
                    CheckGameWinner(gesture1, gesture2, 2, 3, 1, 4);
                    break;
                case 1:
                    CheckGameWinner(gesture1, gesture2, 0, 4, 2, 3);
                    break;
                case 2:
                    CheckGameWinner(gesture1, gesture2, 1, 3, 4, 0);
                    break;
                case 3:                  
                    CheckGameWinner(gesture1, gesture2, 4, 1, 0, 2);
                    break;
                case 4:
                    CheckGameWinner(gesture1, gesture2, 2, 0, 3, 1);
                    break;
                default:
                    break;
            }
            Menu.DisplayScore(player1, player2);
        }

        public void CheckGameWinner( int player1Gesture, int player2Gesture,int losingGesture1, int losingGesture2,int winningGesture1, int winningGesture2)
        {
            //issue here
            string gestureName = player1.gestures[player1Gesture].Name;
            string gesture1Name = player1.gestures[losingGesture1].Name;
            string gesture2Name = player1.gestures[losingGesture2].Name;
            string gesture3Name = player1.gestures[winningGesture1].Name;
            string gesture4Name = player1.gestures[winningGesture2].Name;
            if (player2Gesture == losingGesture1)
            {
                player1.wins++;
                Menu.DisplayGameWinner(gestureName, gesture1Name, player1.gestures[player1Gesture].Verb1);
                Graphics.GetBattleGraphic(player1Gesture, 0);
            }
            else if (player2Gesture == losingGesture2)
            {
                player1.wins++;
                Menu.DisplayGameWinner(gestureName, gesture2Name, player1.gestures[player1Gesture].Verb2);
                Graphics.GetBattleGraphic(player1Gesture, 1);

            }
            else if (player2Gesture == winningGesture1)
            {
                player2.wins++;
                Menu.DisplayGameWinner(gesture3Name, gestureName, player1.gestures[player2Gesture].Verb1);
                Graphics.GetBattleGraphic(player2Gesture, 0);
            }
            else if (player2Gesture == winningGesture2)
            {
                player2.wins++;
                Menu.DisplayGameWinner(gesture4Name, gestureName, player1.gestures[player2Gesture].Verb2);
                Graphics.GetBattleGraphic(player2Gesture, 1);
            }

        }

        public void CheckMatchWinner(Player player1)
        {
            if(player1.wins==2)
            {
                Menu.DisplayMatchWinner("Player 1");
            }
            else
            {
                Menu.DisplayMatchWinner("Player 2");
            }
        }
    }
}
