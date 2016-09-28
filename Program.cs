using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vocabulario
            Dictionary<char, String> morseCode = new Dictionary<char, String>()
            {
                {'A' , ".-"},
                { 'B' , "-..."},
                { 'C' , "-.-."},
                {'D' , "-.."},
                { 'E' , "."},
                { 'F' , "..-."},
                {'G' , "--."},
                { 'H' , "...."},
                { 'I' , ".."},
                {'J' , ".---"},
                { 'K' , "-.-"},
                { 'L' , ".-.."},
                {'M' , "--"},
                { 'N' , "-."},
                { 'O' , "---"},
                {'P' , ".--."},
                { 'Q' , "--.-"},
                { 'R' , ".-."},
                {'S' , ".-."},
                { 'T' , "-"},
                { 'U' , "..-"},
                {'V' , "...-"},
                { 'W' , ".--"},
                { 'X' , "-..-"},
                {'Y' , "-.--"},
                { 'Z' , "--.."},
                {'0' , "-----"},
                { '1' , ".----"},
                { '2' , "..----"},
                { '3' , "...--"},
                {'4' , "....-"},
                { '5' , "....."},
                { '6' , "-...."},
                { '7' , "--..."},
                {'8' , "---.."},
                { '9' , "----."},
            };
            #endregion

            #region Conversao
            Console.WriteLine("Datilografe o que deseja traduzir");
            String input = Console.ReadLine();
            input = input.ToUpper();

            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0)
                    Console.Write('/');

                char c = input[i];
                if (morseCode.ContainsKey(c))
                    Console.Write(morseCode[c]);
            }
            #endregion

            #region Frescura
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla...");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
