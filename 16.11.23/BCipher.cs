using System;
using System.Text.RegularExpressions;

namespace _16._11._23
{
    internal class BCipher : ICipher
    {
        void ICipher.Encode(string text)
        {
            if (text != null)
            {

                char[] charText = text.ToCharArray();
                for (int i = 0; i < charText.Length; i++)
                {
                    if (Regex.IsMatch(charText[i].ToString(), @"^[\p{L}]+$"))
                    {

                        if (Char.ToLower(charText[i]) >= 'а' && Char.ToLower(charText[i]) <= 'я')
                        {

                            Console.Write(Char.IsUpper(charText[i]) ? (char)('Я' + 'А' - charText[i]) : (char)('я' + 'а' - charText[i]));
                        }
                        else if (Char.ToLower(charText[i]) >= 'a' && Char.ToLower(charText[i]) <= 'z')
                        {
                            Console.Write(Char.IsUpper(charText[i]) ? (char)('Z' + 'A' - charText[i]) : (char)('z' + 'a' - charText[i]));
                        }
                        else
                        {
                            Console.WriteLine("Используется только русский и английский алфавиты");
                        }

                    }
                    else
                    {
                        Console.Write(charText[i]);
                    }
                }
            }
            else
            {
                Console.Write("Пустая строка");
            }
            Console.WriteLine();
        }

        void ICipher.Decode(string text)
        {
            if (text != null)
            {

                char[] charText = text.ToCharArray();
                for (int i = 0; i < charText.Length; i++)
                {
                    if (Regex.IsMatch(charText[i].ToString(), @"^[\p{L}]+$"))
                    {

                        if (Char.ToLower(charText[i]) >= 'а' && Char.ToLower(charText[i]) <= 'я')
                        {

                            Console.Write(Char.IsUpper(charText[i]) ? (char)('Я' + 'А' - charText[i]) : (char)('я' + 'а' - charText[i]));
                        }
                        else if (Char.ToLower(charText[i]) >= 'a' && Char.ToLower(charText[i]) <= 'z')
                        {
                            Console.Write(Char.IsUpper(charText[i]) ? (char)('Z' + 'A' - charText[i]) : (char)('z' + 'a' - charText[i]));
                        }
                        else
                        {
                            Console.WriteLine("Используется только русский и английский алфавиты");
                        }

                    }
                    else
                    {
                        Console.Write(charText[i]);
                    }
                }
            }
            else
            {
                Console.Write("Пустая строка");
            }
            Console.WriteLine();
        }
    }
}


