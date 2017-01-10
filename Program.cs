using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Object> boxes = new List<Object>();

            boxes.Add(7);
            boxes.Add(28);
            boxes.Add(-1);
            boxes.Add(true);

            int boxSum = 0;
            for (int idx = 0; idx < boxes.Count; idx++){
                if (boxes[idx] is int){
                    boxSum = boxSum + (int) boxes[idx];
                }
            }

            Console.WriteLine(boxSum);


            //Box some string data into a variable
            object BoxedData = "This is clearly a string";
            //Make sure it is the type you need before proceeding
            if (BoxedData is int) {
                //This shouldn't run
                Console.WriteLine("I guess we have an integer value in this box?");
            }
            if (BoxedData is string) {
                Console.WriteLine("It is totally a string in the box!");
            }
        }
    }
}
