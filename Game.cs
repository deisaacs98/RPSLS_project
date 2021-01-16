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
            player1.AddGesturesToList();

            
            Menu.Title();
            int numberOfPlayers=player1.SelectNumberOfPlayers();
            SetPlayerChoice(numberOfPlayers);
            //player2.AddGesturesToList();


        }
        public void Run()
        {
            StartGame();
            int player1Gesture;
            int player2Gesture;
            while (player1.wins<3&&player2.wins<3)
            {
                player1Gesture = player1.ChooseGesture();
                player2Gesture = player2.ChooseGesture();
                if (player1Gesture == player2Gesture)
                {
                    Menu.DisplayTie();
                }
                else
                {
                    CompareGestures(player1Gesture, player2Gesture);
                    CompareGestures(player2Gesture, player1Gesture);
                }   
            }
        }
        


        
        
        public void SetPlayerChoice(int numberOfPlayers)
        {
            if(numberOfPlayers==1)
            {
                player2 = new CPU();                
            }
            else
            {
                player2 = new User();               
            }           
        }

        // CompareGestures seems like it can be simplified. Look into this after program is running properly
        public void CompareGestures(int gesture1, int gesture2)
        {

            switch(gesture1)
            {
                case 0:
                    CheckGameWinner(player1, gesture1, gesture2, 2, 3);
                    break;
                case 1:
                    CheckGameWinner(player1, gesture1, gesture2, 0, 4);
                    break;
                case 2:
                    CheckGameWinner(player1, gesture1, gesture2, 1, 3);
                    break;
                case 3:
                    CheckGameWinner(player1, gesture1, gesture2, 4, 1);
                    break;
                case 4:
                    CheckGameWinner(player1, gesture1, gesture2, 2, 0);
                    break;
                default:
                    break;

            }
         
        }
        public void CheckGameWinner(Player player1, int player1Gesture, int player2Gesture,int gesture1, int gesture2)
        {
            //issue here
            string gestureName = player1.gestures[player1Gesture].Name;
            string gesture1Name = player1.gestures[gesture1].Name;
            string gesture2Name = player1.gestures[gesture2].Name;
            if (player2Gesture == gesture1)
            {
                player1.wins++;
                Menu.DisplayGameWinner(gestureName, gesture1Name, player1.gestures[gesture1].Verb1);
            }
            else if (player2Gesture == gesture2)
            {
                player1.wins++;
                Menu.DisplayGameWinner(gestureName, gesture1Name, player1.gestures[gesture2].Verb2);
            }
        }
        public void CheckMatchWinner(Player player1)
        {
            if(player1.wins==3)
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
