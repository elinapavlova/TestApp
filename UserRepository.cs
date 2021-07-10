using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestApp
{
    public class UserRepository
    {
        /// <summary>
        /// Хранилище данных
        /// </summary>
        static Dictionary<int, string> users = new Dictionary<int, string>
        {
            [0] = "Alex",
            [2] = "Ann",
            [1] = "Kate"
        };

        /// <summary>
        /// Добавление пользователя в хранилище
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        public static void AddUser(int userId, string userName)
        {
            users.Add(userId, userName);
        }

        /// <summary>
        /// Получение пользователя по UserId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static string GetUser(int userId)
        {
            return users[userId];
        }

        /// <summary>
        /// Получение отсортированного по UserId списка пользователей
        /// </summary>
        /// <returns></returns>
        public static SortedDictionary<int, string> GetOrderedUsers()
        {
            var sortedUsers = new SortedDictionary<int, string>(users);

            foreach (var a in sortedUsers)
            {
                Console.WriteLine(a.Key + " - " + a.Value);
            }

            return sortedUsers;
        }

        /// <summary>
        ///  Асинхронная версия метода AddUser()
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        public static async void AddUserAsync(int userId, string userName)
        {
            await Task.Run(() => AddUser(userId, userName));
        }

        /// <summary>
        /// Асинхронная версия метода GetUser()
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static async Task<string> GetUserAsync(int userId)
        {
            return await Task.Run(() => GetUser(userId));
        }
        
        /// <summary>
        /// Асинхронная версия метода GetOrderedUsers()
        /// </summary>
        /// <returns></returns>
        public static async Task<SortedDictionary<int, string>> GetOrderedUsersAsync()
        {
            return await Task.Run(() => GetOrderedUsers());
        }
    }
}
