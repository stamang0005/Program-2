//B8030
//program 01.
//CIS 199
//PROF, ANDREW
// DUE ON 09/25/2018
//this program estimate the problem paint that is required to paint the rooms wall.

using static System.Console;

namespace program1
{
    class Program
    {
        static void Main()
        {
            //string variable
            string totalLength,
                   wallHeight,
                   numberOfDoor,
                   numberOfWindow,
                   coatsOfPaint;

            //double variable
            double length,
                height,
                totalSqFt,
                doors,
                windows,
                minimumGaltoBuy,
                coats;
            //const int value of window and doors.
            const int DOORFOOTAGE = 20,
                WINDOWFOOTAGE = 15,
                PAINTCOVERAGE = 385;
            WriteLine("Welcome To The Handy-Dandy Paint Estimator");//opening statement

            //place to enter in the total length of wall
            Write("Enter the total length of all walls (in feet):");
            totalLength = ReadLine();//length that user inputs
            length = System.Convert.ToDouble(totalLength);//converts to whole number

            //place to enter in the height of the wall.
            Write("Enter the height of the walls (in feet):");
            wallHeight = ReadLine();//height that users inputs
            height = System.Convert.ToDouble(wallHeight);//converts to whole number
 
            //number of doors
            Write("Enter the number of doors (non-neg int):");
            numberOfDoor = ReadLine();//number of doors that user input
            doors = System.Convert.ToDouble(numberOfDoor);

            //numbers of windows
            Write("Enter the number of the Windows (non-neg int):");
            numberOfWindow = ReadLine();//number of window that user input
            windows = System.Convert.ToDouble(numberOfWindow);

            //write the number of coats of paint
            Write("Enter the number of coats of paint(non-neg int):");
            coatsOfPaint = ReadLine();//number ofcoats user need.
            coats = System.Convert.ToDouble(coatsOfPaint);


            // calculation
            //calculation of total square feet of the room.
            totalSqFt = ((length * height) - (doors * DOORFOOTAGE) - (windows * WINDOWFOOTAGE)) * coats;
            minimumGaltoBuy = totalSqFt / PAINTCOVERAGE;
            // dividing total sqaure feet by Paintcoverage to show minimum amount of paint needed.

            //output, shows how much paint needed and how much to buy
            WriteLine("You need minimun of {0} gallon of paint", minimumGaltoBuy.ToString("F1"));//string to 1 decimal place
            WriteLine("You'll need to buy {0} gallon ", System.Math.Ceiling(minimumGaltoBuy) );//math.ceiling rounds upward.
     
            











            
            
        }
    }
}
