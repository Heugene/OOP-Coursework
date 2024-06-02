using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Trademark : IValidable
    {
        public int? ID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Trademark() { }

        public Trademark(string name, string description)
        { 
            Name = name;
            Description = description;
        }

        public Trademark(int id, string name, string description) : this(name, description)
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
            if (String.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Name can`t be null or an empty string");
            }
            return true;
        }
    }
}
