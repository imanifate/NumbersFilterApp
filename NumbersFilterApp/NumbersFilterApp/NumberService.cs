using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFilterApp
{
    public static class NumberService
    {
        
        public static List<int> ReadNumbersFromUser()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine(Messages.EnterNumbers);

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done") break;

                if(int.TryParse(input,out int number))
                    numbers.Add(number);
                else
                    Console.WriteLine(Messages.InvalidInput);
            }
            return numbers;
        }

        // کلاس استاتیک برای فیلتر کردن اعداد
        public static List<int> FilterNumbers(List<int> numbers)
        {
          return  numbers.Where(n => n > 5).ToList();
        }

       public static void PrintNumbers(List<int> numbers)
        {
            Console.WriteLine(Messages.Result);

             foreach (int n in numbers)
                Console.WriteLine(n); 
           
        }

    }
}
