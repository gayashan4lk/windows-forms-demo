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
        }
    }
}
