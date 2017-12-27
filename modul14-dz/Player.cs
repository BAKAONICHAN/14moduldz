using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace modul14_dz
{
    public class Player:Game
    {
        public string[] hand = new string[6];
        public void show(int numberOfPlayer)
        {
            for(int i=0;i<hand.Length;i++)
            {
                WriteLine(hand[i]);   
            }
        }
        Card[] deckOfFirstPlayer = new Card[12];
        Card[] deckOfSecondPlayer = new Card[12];


    }
}
