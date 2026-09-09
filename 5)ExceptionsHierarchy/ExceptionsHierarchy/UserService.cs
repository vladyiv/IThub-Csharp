using System;
using System.Collections.Generic;

namespace ExceptionsHierarchy
{
    internal class UserService
    {
        public int GetUserAgeSafe(int userId)
        {
            try
            {
                Repository r = new Repository();
                return r.GetUserAge(userId);
            }
            catch (KeyNotFoundException ex) // если возникнет ошибка при вызове GetUserAge, вылезет именно ошибка KeyNotFoundException, поэтому перехватываем её
            {
                var customException = new InvalidOperationException(
                $"Пользователя с ID {userId} нет в базе :(", ex);
                customException.Data["userId"] = userId; // при запуске программы с ошибкой с откладкой во вкладке Data можно увидеть параметр customException.Data["userId"] со значением userId
                throw customException;
            }
        }
    }
}
