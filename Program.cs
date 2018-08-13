/*
Josephus Problem from Coding Challenges
by Silvio Duka

Last modified date: 2018-02-24

N people (numbered 1 to N) are standing in a circle. Person 1 kills Person 2 with a sword and gives it to Person 3. Person 3 kills Person 4 and gives the sword to Person 5. This process is repeated until only one person is alive. 

Task: 
(Medium) Given the number of people N, write a program to find the number of the person that stays alive at the end. 
(Hard) Show each step of the process.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosephusProblem
{
    class Program
    {
        static int numberOfSoldiers = 13;  //Insert integer number of soldiers in circle (n > 0)
        static bool[] soldiers = Enumerable.Repeat(true, numberOfSoldiers).ToArray(); // Array of live soldiers

        static void Main(string[] args)
        {
            int soldier = 0;

            while (true)
            {
                    int nextSoldier = FindNextLiveSoldier(soldier);

                    if (nextSoldier == soldier) { Console.WriteLine($"Last live Soldier is: {soldier + 1}"); break; }

                    soldiers[nextSoldier] = false;

                    Console.WriteLine($"{soldier + 1} eliminates {nextSoldier + 1}");

                    soldier = FindNextLiveSoldier(nextSoldier);
            }
        }

        static int FindNextLiveSoldier(int n)
        {
            for (int i = n+1; i < numberOfSoldiers; i++ )
            {
                if (soldiers[i] == true) return i;
            }

            for (int i = 0; i < n; i++)
            {
                if (soldiers[i] == true) return i;
            }

            return n;
        }
    }
}
