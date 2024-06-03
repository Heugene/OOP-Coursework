using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DiscountedItem : IValidable
    {
        public int? ID {  get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public string Description { get; set; }
        public Bitmap? Picture { get; set; }
        public Shop Shop { get; set; }

        public DiscountedItem() { }

        public DiscountedItem(string name, ItemType type, string description, Shop shop)
        {
            Name = name;
            Type = type;
            Description = description;
            Shop = shop;
            //TODO знайти дефолтну картинку та вставити сюди замість Null
            SetPicture(null);
        }

        public DiscountedItem(int id, string name, ItemType type, string description, Shop shop) : this(name, type, description, shop)
        { 
            ID = id;
        }

        public DiscountedItem(string name, ItemType type, string description, Shop shop, Bitmap picture) : this(name, type, description, shop)
        {
            Picture = picture;
        }

        public DiscountedItem(int id, string name, ItemType type, string description, Shop shop, Bitmap picture) : this(name, type, description, shop)
        {
            ID = id;
            Picture = picture;
        }

        public void SetPicture(Bitmap? picture) 
        {
            Picture = picture;
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
            if (String.IsNullOrEmpty(Description))
            {
                throw new ArgumentException("Description can`t be null or an empty string");
            }
            if (Picture is null)
            {
                throw new ArgumentException("Picture can`t be null");
            }
            if (Shop is null)
            {
                throw new ArgumentException("Shop can`t be null");
            }
            return true;
        }
    }
}
