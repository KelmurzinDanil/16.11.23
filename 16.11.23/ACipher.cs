using System;
using System.Text.RegularExpressions;

namespace _16._11._23
{
    internal class ACipher : ICipher
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

                        if (charText[i] == 'я' || charText[i] == 'Я')
                        {
                            Console.Write(Char.IsUpper(charText[i]) ? 'А' : 'а');
                        }
                        else if (charText[i] == 'z' || charText[i] == 'Z')
                        {
                            Console.Write(Char.IsUpper(charText[i]) ? 'A' : 'a');
                        }
                        else
                        {
                            charText[i] = (char)(charText[i] + 1);
                            Console.Write(charText[i]);
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

                        if (charText[i] == 'а' || charText[i] == 'А')
                        {
                            Console.Write(Char.IsUpper(charText[i]) ? 'Я' : 'я');
                        }
                        else if (charText[i] == 'A' || charText[i] == 'a')
                        {
                            Console.Write(Char.IsUpper(charText[i]) ? 'Z' : 'z');
                        }
                        else
                        {
                            charText[i] = (char)(charText[i] - 1);
                            Console.Write(charText[i]);
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
