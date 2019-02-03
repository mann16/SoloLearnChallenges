using System;
using System.CodeDom.Compiler;

namespace SoloLearnChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Varibale name validatioon challange");
            Console.WriteLine("Enter Variable name : ");
            var variableName = Console.ReadLine().ToString();
            Console.WriteLine(IsValidVarName(variableName));

            Console.WriteLine("ASCII Converter : ");
            Console.WriteLine("Enter text : ");
            var text = Console.ReadLine().ToString();
            Console.WriteLine(ASCIIConverer(text));
        }

        /// <summary>
        /// Varibale name validation
        /// </summary>
        /// <param name="variableName">Variablename</param>
        /// <returns>
        /// "Valid" if varibale is valid
        /// "Invalid" if varibale is invalid
        /// </returns>
        private static string IsValidVarName(string variableName)
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider("C#");

            if (provider.IsValidIdentifier(variableName))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }

        /// <summary>
        /// Convert text to ASCII
        /// </summary>
        /// <param name="text"></param>
        /// <returns>ASCII String</returns>
        private static string ASCIIConverer(string text)
        {
            string asciiText = string.Empty;
            foreach (var c in text)
            {
                int unicode = c;

                if (unicode < 128)
                {
                    asciiText += string.Format("{0} ", unicode);
                }
                else
                {
                    asciiText = "Provided text is not valid";
                }
                
            }

            return asciiText;
            ;
        }
    }
}
