using System;
using System.CodeDom.Compiler;

namespace SoloLearnChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Variable name : ");
            var variableName = Console.ReadLine().ToString();

            Console.WriteLine(IsValidVarName(variableName));
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
    }
}
