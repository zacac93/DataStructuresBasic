/*
 * Zachary Clark
 * 09/21/16
 * This Program shows the basic data structures of a Queue and Dictionary
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresBasic
{
    class Program
    {
        //create new Random object
        public static Random random = new Random();
        //method to create random name
        public static string randomName()
        {
            string[] names = new string[8] { "Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher" };
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        }
        //method to create random number
        public static int randomNumberInRange()
        {
            return Convert.ToInt32(random.NextDouble() * 20);
        }

        static void Main(string[] args)
        {
            //initialize new queue and dictionary
            Queue<string> myQueue = new Queue<string>();
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            //fill queue with 100 names
            for (int i = 0; i < 100; i++ )
            {
                myQueue.Enqueue(randomName());
            }

            //initialize temp variables to hold name (key) and number of hamburgers (value)
            string tempName;
            int tempInt = 0;
            for (int x = 0; x < myQueue.Count(); x++)
            {
                //assign current key and value to temp values
                tempName = myQueue.Dequeue();
                tempInt = randomNumberInRange();
                //if duplicate added, catch and update number of burgers
                try
                {
                    myDictionary.Add(tempName, tempInt);
                    //Console.WriteLine(tempName + " " + myDictionary[tempName]);
                }
                catch
                {
                    //Console.WriteLine("DUPLICATE ADDED");
                    //Console.WriteLine(tempName + " " + myDictionary[tempName]);
                    //Console.WriteLine("tempInt: " + tempInt);
                    //Console.ReadLine();
                    myDictionary[tempName] += tempInt;
                   // Console.WriteLine(tempName + " " + myDictionary[tempName]);
                }

            }

            foreach (KeyValuePair<string,int> entry in myDictionary)
            {
                Console.Write(entry.Key.PadRight(25));
                Console.WriteLine(entry.Value);
            }

            Console.ReadLine();
            //IEnumerator MyQueueEnumerator = myQueue.GetEnumerator();

            //while (MyQueueEnumerator.MoveNext())
            //{
            //    myDictionary.Add(myQueue.Dequeue(), randomNumberInRange());
            //}
                
        }
    }
}
