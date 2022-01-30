using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_task
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b_1 = true;
            string my_string_1 = "([]{})[]";
            Console.WriteLine(my_string_1);
            Stack<char> stack_1 = new Stack<char>();
            foreach (var s in my_string_1)
            {
                if (s == '{')
                {
                    stack_1.Push('}');
                }
                if (s == '[')
                {
                    stack_1.Push(']');
                }
                if (s == '(')
                {
                    stack_1.Push(')');
                }
                if (stack_1.Count != 0 && s == stack_1.Peek())
                {
                    stack_1.Pop();
                }

                if (stack_1.Count == 0)
                {
                    b_1 = true;
                }
                else
                {
                    b_1 = false;
                }
            }

            if (b_1)
            {
                Console.WriteLine("Скобки расставлены корректно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены Не корректно");
            }
            Console.WriteLine();


            bool b_2 = true;
            string my_string_2 = "([]]";
            Console.WriteLine(my_string_2);
            Stack<char> stack_2 = new Stack<char>();
            foreach (var s in my_string_2)
            {
                if (s == '{')
                {
                    stack_2.Push('}');
                }
                if (s == '[')
                {
                    stack_2.Push(']');
                }
                if (s == '(')
                {
                    stack_2.Push(')');
                }
                if (stack_2.Count != 0 && s == stack_2.Peek())
                {
                    stack_2.Pop();
                }

                if (stack_2.Count == 0)
                {
                    b_2 = true;
                }
                else
                {
                    b_2 = false;
                }
            }

            if (b_2)
            {
                Console.WriteLine("Скобки расставлены корректно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены Не корректно");
            }
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
