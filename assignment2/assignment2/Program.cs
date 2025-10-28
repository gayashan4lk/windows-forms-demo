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

            try
            {
                var result = GcdCalculator.CaculateGCDArray(arr1, arr2);

                Console.WriteLine(string.Join(",", result));
            }
            catch (Exception ex)
            {
                Console.Write($"!! Exception occured: {ex.Message}");
            }
        }
    }
}
