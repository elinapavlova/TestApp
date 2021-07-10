using System;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        /// <summary>
        /// Функция для битового реверса массива байтов
        /// </summary>
        /// <param name="array"></param>
        public static void Reverse(byte[] array)
        {
            foreach (byte element in array)
            {
                string tmp = String.Format("{0:d8}", Convert.ToInt32(Convert.ToString(element, 2)));

                string reverseTmp = new string(tmp.ToCharArray().Reverse().ToArray());

                int reverseElement = Convert.ToInt32(reverseTmp, 2);

                Console.WriteLine(reverseElement);
            }
        }

        static async Task Main(string[] args)
        {
            // Проверка работы класса UserRepository
           
            var user = await UserRepository.GetUserAsync(1);

            Console.WriteLine(user);

            UserRepository.AddUserAsync(5, "John");

            await UserRepository.GetOrderedUsersAsync();


            Console.WriteLine();

            // Проверка работы функции Reverse

            byte[] array = { 0, 10, 50, 100, 255 };

            Reverse(array);
        }
    }
}
