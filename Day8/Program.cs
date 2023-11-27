namespace Day8
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //int arrsize, tharget;
            //string s = Console.ReadLine();

            //string[] arr = s.Split(" ");
            //arrsize= int.Parse(arr[0]);
            //tharget = int.Parse(arr[1]);




            //Console.WriteLine($"array size {arrsize}");
            //Console.WriteLine($"target is sum of 2 numbers it should be {tharget}");



            //int[] values = new int[arrsize];
            //s= Console.ReadLine();
            //arr = s.Split(" ");

            //for (int i = 0; i < arrsize; i++)
            //{
            //    values[i] = int.Parse(arr[i]);


            //}



            // for (int r = 0; r < values.Length; r++)
            //    {
            //        for (int c = r+1; c < values.Length; c++)
            //        {
            //            if (values[r] + values[c]== tharget)
            //            {
            //                Console.WriteLine($"num is position {r+1} and num in position {c+1} the sum of them is 8");
            //                break;
            //            }
            //        }
            //    }











            // multiply table 

            multiplicationfF(3);














                
            
        }

        static void multiplicationfF (int n )
        {


            // multiply table 


            //string s = " ";
            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Multiplication of {i}");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }




            }


        }
    }
}