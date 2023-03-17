namespace Kapittel_3.Components
{
    internal class Oppgave_3
    {
        public void Run()
        {
            int[] list = new int[] { 0, 1, 2, 3, 4, 6 };
            Console.WriteLine(ListIsSorted(list));
        }

        public bool ListIsSorted(int[] list)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                if (!NumberIsSorted(list[i], list[i + 1])) return false;
            }
            return true;
        }

        public bool NumberIsSorted(int number, int numberToRight)
        {
            if (number < numberToRight) return true;
            else return false;
        }
    }
}
