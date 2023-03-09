namespace Ex14_Sorting
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int[] array = new int[] { 1, 4, 2, 5, 3, 8, 1};


            IntArrayHelper.Print(array);

            IntArrayHelper.Sort(array);
            
            IntArrayHelper.Print(array);

            IntArrayHelper.Reverse(array);

            IntArrayHelper.Print(array);


        }
    }
}