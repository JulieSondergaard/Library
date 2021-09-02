using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Menu
    {
        //GetMenu is the whole method for the menu
        public static void GetHeader()
        {
            string header = "";
            string headerSpace = "";

            for (int i = 0; i < 50; i++)
            {
                header += "=";
                if (i % 4 == 0)
                {
                    headerSpace += " ";
                }

            }
            Console.WriteLine(header);
            Console.WriteLine($"\n {headerSpace} Velkommen til biblo \n ");
            Console.WriteLine(header);
           
        }

        public static void GetCheckOutCounter()
        {
            string header = "";
            string headerSpace = "";

            for (int i = 0; i < 50; i++)
            {
                header += "=";
                if (i % 4 == 0)
                {
                    headerSpace += " ";
                }

            }
            Console.WriteLine(header);
            Console.WriteLine($"\n {headerSpace}   Tjek ud skranke \n ");
            Console.WriteLine(header);
        }

        public static void GetRepeat()
        {
            Console.WriteLine("\nVil du låne flere bøger? Ja/nej");
            string input = Console.ReadLine();

            if (input == "nej" || input == "Nej") {
                Program.enoughBooks = true;
            }           
            Console.Clear();
        }

        public static void GetGoodbye()
        {
            string header = "";
            string headerSpace = "";

            for (int i = 0; i < 50; i++)
            {
                header += "=";
                if (i % 4 == 0)
                {
                    headerSpace += " ";
                }

            }
            Console.WriteLine(header);
            Console.WriteLine($"\n {headerSpace} Farvel og kom godt hjem \n ");
            Console.WriteLine(header);
        }
    }
}
