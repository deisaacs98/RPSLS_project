using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        
        
        public User player1=new User();
        public Player player2;
        

        

        public Game()
        {
               
        }

        public void StartGame()
        {
            player1.AddGesturesToList();

            
            Menu.Title();
            int numberOfPlayers=player1.SelectNumberOfPlayers();
            SetPlayerChoice(numberOfPlayers);
            player2.AddGesturesToList();


        }
        public void Run()
        {
            
            StartGame();

            while (player1.wins<3&&player2.wins<3)
            {
                int player1Gesture = player1.ChooseGesture();
                int player2Gesture = player2.ChooseGesture();
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
                    CheckGameWinner(player1, player2, gesture2, 2, 3);
                    break;
                case 1:
                    CheckGameWinner(player1, player2, gesture2, 0, 4);
                    break;
                case 2:
                    CheckGameWinner(player1, player2, gesture2, 1, 3);
                    break;
                case 3:
                    CheckGameWinner(player1, player2, gesture2, 4, 1);
                    break;
                case 4:
                    CheckGameWinner(player1, player2, gesture2, 2, 0);
                    break;
                default:
                    break;

            }
         
        }
        public void CheckGameWinner(Player player1, Player player2, int gesture,int gesture1, int gesture2)
        {
            string gestureName = player1.gestures[gesture].Name;
            string gesture1Name = player2.gestures[gesture1].Name;
            string gesture2Name = player2.gestures[gesture2].Name;
            if (gesture == gesture1)
            {
                player1.wins++;
                Menu.DisplayGameWinner(gestureName, gesture1Name, player1.gestures[gesture].Verb1);
            }
            else if (gesture == gesture2)
            {
                player1.wins++;
                Menu.DisplayGameWinner(gestureName, gesture1Name, player1.gestures[gesture].Verb2);
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
