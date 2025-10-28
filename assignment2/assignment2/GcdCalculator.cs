namespace assignment2
{
    public static class GcdCalculator
    {
        public static int[] CaculateGCDArray(int[] inputA, int[] inputB)
        {
            if (inputA.Length != inputB.Length)
                throw new ArgumentException("InputA and InputB should have the same length");

            int[] gcdResults = new int[inputA.Length];

            for (int i = 0; i < inputA.Length; i++)
            {
                var gcd = CalculateGCD(inputA[i], inputB[i]);

                gcdResults[i] = gcd;
            }
            return gcdResults;
        }

        public static int CalculateGCD(int a, int b)
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
