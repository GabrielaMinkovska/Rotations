namespace T02_Rotations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arrayNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

  
            int numberRotations = int.Parse(Console.ReadLine());

            RotatedArray(arrayNumbers, numberRotations);

            Console.WriteLine(string.Join(", ", arrayNumbers));
        }

        static void RotatedArray(int[] arr, int rotations)
        {
            for (int i = 0; i < rotations; i++)
            {
                int lastElement = arr[arr.Length - 1];

                for (int j = arr.Length - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];
                }

                arr[0] = lastElement;
            }
        }
    }
}