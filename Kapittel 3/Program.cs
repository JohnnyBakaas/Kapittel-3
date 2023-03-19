using Kapittel_3.Components;

namespace Kapittel_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oppgave_7 opgave_7 = new Oppgave_7();
            opgave_7.Run();

            Oppgave_3 oppgave_3 = new Oppgave_3();
            oppgave_3.Run();
            Oppgave_4 oppgave_4 = new Oppgave_4();

            Console.WriteLine("Angi ROT (For decoding start med -)");
            string inputROT = Console.ReadLine();
            Console.WriteLine("Angi tekst");
            string inputMessage = Console.ReadLine();
            oppgave_4.encrypt(Int16.Parse(inputROT), inputMessage);
        }
    }
}