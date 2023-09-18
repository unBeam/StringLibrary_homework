using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary
{
    public class StringClass
    {
        /// <summary>
        ///  Создание тест-кейсов с использованием метода Assert.IsTrue(). Метод Assert.IsTrue() проверяет, что тестовые данные удовлетворяют проверяемым условиям
        /// </summary>
        /// <param name="textString"> Метод принимает в качестве параметра строку. Предполагается, что строка может быть пустой или содержать произвольный набор символов. </param>
        /// <returns>Метод возвращает true, если входная строка содержит только цифры. Если имеется хотя бы один символ, которой не является цифрой, то метод должен вернуть false. В случае пустой строки метод также должен вернуть false.</returns>
        public bool OnlyDigits(string textString)
        {
            double number;

            textString = textString.Replace('.', ',');

            if (!double.TryParse(textString, out number))
            {
                return false;
            }

            if (string.IsNullOrEmpty(textString))
            {
                return false;
            }

            if(textString.Length >= 10)
            {
                return false;
            }

            return true;
        }


    }
}
