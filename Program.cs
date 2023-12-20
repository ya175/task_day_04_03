using System.Diagnostics;

namespace task_day_04_03
{
    internal class Program
    {
        static void checkString()
        {
            string str = Console.ReadLine();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            bool found = false;
            foreach (var item in vowels)
            {
                if (str.Contains(item)) found = true;
                break;
            }
            if (!found)
            {
                throw new Exception("string does not contain vowels");

            }
            else Console.WriteLine(" this sring contains vowles");
        }
        static void checkDuplicate() 
        {
            List<int> list = new List<int>();
            do
            {
                Console.WriteLine("Enter a number : ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (list.Contains(number))
                {
                    Console.Write('[');
                    foreach (var item in list) Console.Write($"{item} ");
                    Console.WriteLine(']');

                    throw new Exception("Duplicate number.please try again.");

                }
                else list.Add(number);

            } while (true);
        }
        static void Main(string[] args)
        {
            //1

            checkDuplicate();

            //2

            checkString();


            }


    }
    }

