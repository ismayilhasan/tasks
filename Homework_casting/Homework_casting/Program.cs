using System;

namespace Homework_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintible word = new Word();
            IPrintible excel = new Excel();
            IPrintible pdf = new PDF();

            MainPrintFile for_word = new MainPrintFile(word);
            MainPrintFile for_excel = new MainPrintFile(excel);
            MainPrintFile for_pdf = new MainPrintFile(pdf);

        }
    }
}
