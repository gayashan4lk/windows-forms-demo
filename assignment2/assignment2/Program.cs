namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput1 = Console.ReadLine();
            string arrayInput2 = Console.ReadLine();


            int[] arr1 = arrayInput1?.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray() ?? new int[0];
            int[] arr2 = arrayInput2?.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray() ?? new int[0];

            //You may use above two arrays that contain inputs.
            //Complete the below lines to achieve the task.

            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine("Please enter two number sequences with the same length.");
                return;
            }

            int[] gcdResults = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                var gcd = calculateGCD(arr1 [i], arr2 [i]);

                gcdResults[i] = gcd;
            }

            Console.WriteLine(string.Join(",", gcdResults));
        }

        static int calculateGCD(int a, int b)
        {
            while (b != 0)
            {
                var r = a % b;

                a = b;
                b = r;
            }

            return a;
        }
    }
}
