using System;



public class main
{

    static void main(string[] args)
    {
        tries(1);

    }
    public static void Main(int tries)
    {

        //if goAgain= "Y";

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

            

           
            double roomLength;
            Console.Write("\t Tell me the length of the room : \t");
            while (!Double.TryParse(Console.ReadLine(), out roomLength))
            {
                Console.WriteLine("This is incorrect format");
            }


            double roomwidth;
            Console.Write("\t Tell me the width of the room  : \t");
            while (!Double.TryParse(Console.ReadLine(), out roomwidth))
            {
                Console.WriteLine("This is incorrect format");
            }

            double roomHeight;
            Console.Write("\t Tell me the height of the room : \t");
            while (!Double.TryParse(Console.ReadLine(), out roomHeight))
            {
                Console.WriteLine("This is incorrect format");
            }

            Console.WriteLine("");

            double paintCover;
            Console.WriteLine("\t Check the instructions on the paint can and tell me");
            Console.Write("\t how many sq m of wall one litre of paint will cover : ");
            while (!Double.TryParse(Console.ReadLine(), out paintCover))
            {
                Console.WriteLine("This is incorrect format");
            }

            Console.WriteLine("");

            Console.Write("\t The area of the floor is\t\t: \t " + (roomLength * roomWidth) + " sq metres");

            Console.WriteLine("");

            Console.Write("\t The volume of the room is\t\t: \t " + (roomLength * roomWidth * roomHeight) + " cubic metres");

            // Surface area of all walls assumes that the facing walls are both the same size

            double wallArea = (roomLength * roomHeight * 2) + (roomWidth * roomHeight * 2);

            Console.WriteLine("");


            Console.Write("\t The surface area of the walls is\t: \t " + wallArea+ " sq metres");

            Console.WriteLine("\r\n\n");


            //limit final division calculation to 1 decimal places otherwise it can be much too long after the decimal point

            double paintNeeded = Math.Round(wallArea / paintCover, 1);

            Console.Write("\t To paint all 4 walls you will need " + paintNeeded + " litres of paint \r\n\n");


            Console.Write("\t Happy Painting.......Press ENTER key to restart");
            Console.ReadLine();
            break;
            {
                return;
            }
            
        } while (x < 1);

    }
}


