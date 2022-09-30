using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace method_assignment_4._5
{
    internal class Program
    {


        static void Main(string[] args)
        {

            DrawBear();

            drawpopeye();

            drawcow();

            drawknockknock();

            Console.ReadLine();

        }

        public static void DrawBear()
        {
            Console.WriteLine(" __         __");
            Console.WriteLine("/  \\.-\"\"\"-./  \\");
            Console.WriteLine("\\    -   -    /");
            Console.WriteLine(" |   o   o   |\r\n");
            Console.WriteLine(" \\  .-'''-.  /\r\n");
            Console.WriteLine("  '-\\__Y__/-'\r\n");
            Console.WriteLine("     `---`\r\n\\");
        }
        public static void drawpopeye()
        {
            Console.WriteLine("         .-'-.\r\n");
            Console.WriteLine("       /`     |__\r\n");
            Console.WriteLine("     /`  _.--`-,-`\r\n");
            Console.WriteLine("     '-|`   a '<-.   []\r\n");
            Console.WriteLine("       \\     _\\__) \\=`\r\n");
            Console.WriteLine("        C_  `    ,_/\r\n");
            Console.WriteLine("          | ;----'\r\n");
            Console.WriteLine("");
        }
        public static void drawcow()
        {

            Console.WriteLine(@"         /)  (\");
            Console.WriteLine("    .-._((, ~~.))_.-,      ");
            Console.WriteLine("     `=.   99   ,= '       ");
            Console.WriteLine(@"       / ,o~~o. \          ");
            Console.WriteLine("      { { .__. } }         ");
            Console.WriteLine("       ) `~~~\' (          ");
            Console.WriteLine(@"      /`-._  _\.-\         ");
            Console.WriteLine(@"     /         )  \        ");
            Console.WriteLine("   ,-X        #   X-.      ");
            Console.WriteLine(@" /   \          /   \      ");
            Console.WriteLine(" (     ) | |  | | (     )  ");
            Console.WriteLine(@"  \   / | |  | | \   /     ");
            Console.WriteLine(@"   \_(.-( )--() -.)_ /     ");
            Console.WriteLine(@"   / _,\ ) /  \ ( /._\     ");
            Console.WriteLine(@"       / _,\  /._\         ");
        }
        public static void drawknockknock()
        {
            Console.WriteLine("Knock Knock");
            Console.WriteLine("whos there");
            Console.WriteLine("honey bee");
            Console.WriteLine("honey bee who");
            Console.WriteLine("honey bee a dear and get the sugar for me");
        }
    }
}
