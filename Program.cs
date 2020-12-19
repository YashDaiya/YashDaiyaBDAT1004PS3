using System;

namespace DataProrammingProblemSet3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.AngryProfessor();
        }

        public void AngryProfessor()
        {
            Console.Write("Enter Test Cases: ");
            int t = Convert.ToInt32(Console.ReadLine());    //Store number of cases


            for(int test=0; test<t; test++)
            {
                Console.WriteLine("Enter Number of count and Threshold:-");
                string ln = Console.ReadLine();     // Reads Line for student count and threshold
                string[] splitln = ln.Split();      //Split and store ln into the array

                
                int n = Convert.ToInt32(splitln[0]);    // Convert and store number of students in n
                int k = Convert.ToInt32(splitln[1]);    // Convert and store number of thresholds in n

                Console.Write("Enter Student Arrival: ");
                string studcount = Console.ReadLine();  // Reads Student arrival
                string[] splitstu = studcount.Split();  // Store in array

                int[] a = Array.ConvertAll(splitstu, int.Parse);    //Convert string array in integer

                int pos = 0;        //Store Who arrive late
                int neg = 0;        //Store Who arrive on time
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] <= 0)
                    {neg += 1;}     //Arrive on time
                    else
                    {pos += 1;}     //Arrive late
                }
                if (neg >= k)
                {
                    Console.WriteLine("Yes");   //Class will start
                }
                else
                {
                    Console.WriteLine("No");    //Class Cancel
                }
            }
        }
    }
}
