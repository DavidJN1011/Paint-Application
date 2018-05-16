using System;

public class MainClass
{
    public static void Main()
    {

        int x = 0;
        do
        {
            //set the background colour to blue
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            /*note that the r and n values below give a carriage return and a new line
             and t gives a tab.*/


            Console.WriteLine("");
            Console.WriteLine("\t\t The Borwell Challenge \r\n");
            Console.WriteLine("\t Please enter all measurements in metres \r\n");
            Console.WriteLine("\t You may include decimal values e.g. 2.5 metres \r\n");

            Console.WriteLine("\r\n");

            //ask for the room parameters     
            //console.write will put your user input at the end of the line of text unlike
            //console.writeline which forces a new line and your input will go on the next line
            // \t adds a tab to the line which helps formatting

            Console.Write("\t Tell me the length of the room : \t");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\t Tell me the width of the room  : \t");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("\t Tell me the height of the room : \t");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("\t Check the instructions on the paint can and tell me");
            Console.Write("\t how many sq m of wall one litre of paint will cover : ");
            double e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("\t The area of the floor is\t\t: \t " + (a * b) + " sq metres");

            Console.WriteLine("");

            Console.Write("\t The volume of the room is\t\t: \t " + (a * b * c) + " cubic metres");

            // Surface area of all walls assumes that the facing walls are both the same size

            double d = (a * c * 2) + (b * c * 2);

            Console.WriteLine("");


            Console.Write("\t The surface area of the walls is\t: \t " + d + " sq metres");

            Console.WriteLine("\r\n\n");


            //limit final division calculation to 1 decimal places otherwise it can be much too long after the decimal point

            double f = Math.Round(d / e, 1);

            Console.Write("\t To paint all 4 walls you will need " + f + " litres of paint \r\n\n");


            Console.Write("\t Happy Painting.......Press ENTER key to restart");
            Console.ReadLine();



        } while (x < 1);

    }
}


