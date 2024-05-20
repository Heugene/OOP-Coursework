using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain
{
    public class Shop
    {
        public int? ID { get; set; }
        public Trademark Trademark { get; set; }
        public string Address { get; set; }

        public Shop() { }

        public Shop(Trademark trademark, string address)
        {
            Trademark = trademark;
            Address = address;
        }

        public Shop(int id, Trademark trademark, string address) : this(trademark, address)
        {
            ID = id;
        }

        /// <summary>
        /// Тут можна задати правила валідації, за порушення яких при виклику даного методу викидатимуться ексепшени
        /// Якщо все добре, повернеться true
        /// Зроблено для того, щоб об'єкт міг сам по собі існувати з інвалідними полями, в процесі редагування його даних,
        /// але перед занесенням даних у БД викликати для перевірки валідності даних.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool IsValid()
        {
            if (String.IsNullOrEmpty(Address))
            {
                throw new ArgumentException("Address can`t be null or an empty string");
            }
            if (Trademark is null)
            {
                throw new ArgumentException("Trademark can`t be null");
            }
            return true;
        }
    }
}
