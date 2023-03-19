namespace Kapittel_3.Components
{
    // Write a program that is given an array of integers and determines the mode,
    // which is the number that appears most frequently in the array.
    public class Oppgave_7
    {
        public void Run()
        {
            int[] UserInput = new int[] { 1, 2, 3, 2, 4, 5, 2, 6, 2, 4, 6, 6, 4, 3, 6, 6, 6, 6 };
            Console.WriteLine("Det er flest av " + Mode(UserInput) + "ere i denne listen");
        }

        private int Mode(int[] Colection)
        {
            int[] Mode = new int[Colection.Max() + 1];
            for (int i = 0; i < Colection.Length; i++)
            {
                Mode[Colection[i]]++;
            }
            return Array.IndexOf(Mode, Mode.Max());
        }
    }
}
