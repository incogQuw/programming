using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            int height = 0;
            bool valid = false;

            while(!valid)
            {
                Console.Write("Enter the pyramid height: ");
                string currentEntry = Console.ReadLine();
                valid = Int32.TryParse(currentEntry, out height);

                if (height <= 0 || height > 23)
                    valid = false;
            }

            int hashCount = 2;

            for (int i = 0; i < height; i++)
            {
                string line = "";
                int spaces = height - hashCount + 1;
                for (int j = 0; j < spaces; j++)
                {
                    line += " ";
                }

                for (int j = 0; j < hashCount; j++)
                {
                    line += "#";
                }


                Console.WriteLine(line);
                hashCount++; 
            }

            Console.ReadLine();
        }
    }
}
