using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_string = Console.ReadLine();
            string string_to_replace = Console.ReadLine();
            int Left_border = input_string.IndexOf('[');
            int Right_border = 0;
            int i = 0;
            int left_amount = 0;
            int right_amount = 0;
            while (true)
            {
                if (input_string[i] == '[' && Right_border == 0) left_amount++;
                if (input_string[i] == ']') right_amount++;
                if (left_amount == right_amount)
                {
                    Right_border = i;
                    break;
                }
                i++;
            }
            string old_str = input_string.Substring(Left_border, Right_border + 1);
            string new_str = input_string.Replace(old_str, string_to_replace);
            Console.WriteLine($"Новая строка: {new_str}");
            Console.ReadKey();
        }
    }
}



