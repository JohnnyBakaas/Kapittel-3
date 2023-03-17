namespace Kapittel_3.Components
{
    internal class Oppgave_4
    {
        private string Alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";

        public void encrypt(int rotNumber, string inputText)
        {
            Console.WriteLine(ShiftString(inputText.ToUpper(), MakeROT_Alfabet(rotNumber)));
        }

        private string MakeROT_Alfabet(int offset)
        {
            string FinaleAlfabet = "";
            char[] ROT_alfabet = new char[Alfabet.Length];
            for (int i = 0; i < ROT_alfabet.Length; i++)
            {
                ROT_alfabet[i] = Alfabet[fixEadgeCases(i, offset, ROT_alfabet.Length)];
            }

            foreach (char c in ROT_alfabet)
            {
                FinaleAlfabet += c;
            }

            return FinaleAlfabet;
        }

        private int fixEadgeCases(int index, int offset, int length)
        {
            if (((index + offset) % length) < 0) return ((index + offset) % length) + length;
            else return (index + offset) % length;
        }

        public string ShiftString(string inputText, string ROT_Alfabet)
        {
            string outputString = "";

            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == ' ') outputString += ' ';
                else outputString += ROT_Alfabet[Alfabet.IndexOf(inputText[i])];
            }
            return outputString;
        }

    }
}

