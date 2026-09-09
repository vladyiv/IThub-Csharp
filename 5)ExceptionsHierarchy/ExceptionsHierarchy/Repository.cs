using System;
using System.Collections.Generic;

namespace ExceptionsHierarchy
{
    internal class Repository
    {
        public Dictionary<int, int> dict = new Dictionary<int, int> {
                {1, 18},
                {2, 16},
                {3, 20},
                {4, 30},
                {5, 37},
                {6, 22},
                {7, 25},
                {8, 41}
            };

        public int GetUserAge(int userId)
        {
            try
            {
                return dict[userId];
            }
            catch // если при попытке достать элемент по несуществующему/некорректному id возникнет ошибка
            {
                var e = new KeyNotFoundException();
                throw e;
            }            
        }
    }
}
