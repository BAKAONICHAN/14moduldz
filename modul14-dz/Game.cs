using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace modul14_dz
{
   public class Game
    {  string Name { get; set; }
        string SurName { get; set; }
        string[] deck = new string[36];
        List<string>listOfPlayers=new List<string>();
       public void StartGame(string NameOfFirstPlayer,string NameOfSecondPlayer)
       {
            WriteLine("Введите имя первого игрока");
            NameOfFirstPlayer = ReadLine();
            WriteLine("Введите имя второго игрока");
            NameOfSecondPlayer = ReadLine();
        }
        Random rand = new Random();
        for(int i=0;i<)

    }
}
