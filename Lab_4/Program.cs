using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Anya
{
    internal class Program
    {
        private static readonly string _filePath = "input_text.txt";

        public static void SaveInFile(string filePath, string text)
        {
            using(Stream stream = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.Write(text);
                }
            }
        }

        public static string ReadFromFile(string filePath)
        {
            string text = "";

            using (Stream stream = new FileStream(filePath, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    while(!reader.EndOfStream)
                    {
                        text += reader.ReadLine() + "\n";
                    }
                }
            }

            return text;
        }

        public static string GetOnlyWords(string text)
        {
            string result = "";

            for(int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i])) result += text[i];
                else if (result.Length > 0 && result[result.Length - 1] != ' ') result += " ";
            }

            return result;
        }

        public static List<string> Split(string text, char symbol)
        {
            List<string> result = new List<string>();

            string temp = "";

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    result.Add(temp);
                    temp = "";
                }
                else temp += text[i];
            }


            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input text: ");
            string text = Console.ReadLine();

            SaveInFile(_filePath, text);
            Console.WriteLine("\nFile was saved!\n");


            text = ReadFromFile(_filePath);
            Console.WriteLine($"Words after reading:\n{text}");

            text = GetOnlyWords(text);
            Console.WriteLine($"Only words:\n{text}\n");

            Console.WriteLine($"Count of words: {Split(text, ' ').Count}");

        }
    }
}
