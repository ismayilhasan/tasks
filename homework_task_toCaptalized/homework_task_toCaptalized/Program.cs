using System;
using System.Text;

namespace homework_task_toCaptalized
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sAlam BURDA MeTHod oLMaliDir");
            Console.WriteLine(toCaptalized("sAlam BURDA MeTHod oLMaliDir")); 


        }


        public static string toCaptalized(string sentence)
        {
            StringBuilder stringBuilder = new StringBuilder();
            sentence = sentence.ToLower();
            string[] words = sentence.Split();

            foreach(string word in words)
            {
                stringBuilder.Append(char.ToUpper(word[0]));
                for (int i = 1; i < word.Length; i++)
                {
                    stringBuilder.Append(word[i]);
                }
                if (word != words[words.Length - 1])
                {
                    stringBuilder.Append(" ");
                }
                
            }
            return stringBuilder.ToString();

        }
    }
}
