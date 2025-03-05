using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite um texto:");
            string input = Console.ReadLine();
            Console.Write("Digite um caracter:");
            char input2 = char.Parse(Console.ReadLine());
            string text = "";
            for (int i = 0; i<input.Length; i++)
            {
                char toAdd = input[i] == input2 ? 'x' : input[i];
                text += toAdd;
            }
            Console.WriteLine(text);
        }
    }
}
