using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public List<Gesture> gestures;
        
        public User player1=new User();
        public Player player2;
        

        public Game()
        {
            this.gestures = new List<Gesture>();
            

        }

        public void StartGame()
        {
            AddGesturesToList();
            Menu.Title();
            int numberOfPlayers=player1.SelectNumberOfPlayers();
            SetPlayerChoice(numberOfPlayers);
        }
        public void Run()
        {
            StartGame();
        }
        public void SinglePlayerGame()
        {
            int player1Wins = 0;
            int player2Wins = 0;
            
        }
        public void TwoPlayerGame()
        {
           
        }
        public void AddGesturesToList()
        {
            Gesture gesture1 = new Gesture("Rock", "crushes", "crushes");
            Gesture gesture2 = new Gesture("Paper", "covers", "disproves");
            Gesture gesture3 = new Gesture("Scissors", "cuts", "decapitates");
            Gesture gesture4 = new Gesture("Lizard", "poisons", "eats");
            Gesture gesture5 = new Gesture("Spock", "smashes", "vaporizes");
            gestures.Add(gesture1);
            gestures.Add(gesture2);
            gestures.Add(gesture3);
            gestures.Add(gesture4);
            gestures.Add(gesture5);        
        }

        
        
        public void SetPlayerChoice(int numberOfPlayers)
        {
            if(numberOfPlayers==1)
            {
                player2 = new User();
                TwoPlayerGame();
            }
            else
            {
                player2 = new CPU();
                SinglePlayerGame();
            }
        }
    }
}
