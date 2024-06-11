using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DiscountRequest : IValidable
    {
        public int ID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public ShopManager Manager { get; set; }
        public Discount RequestedDiscount { get; set; }
        public DateTime? ViewedDateTime { get; set; }

        public DiscountRequest() { }

        public DiscountRequest(DateTime createdDateTime, ShopManager manager, Discount requestedDiscount)
        {
            CreatedDateTime = createdDateTime;
            Manager = manager;
            RequestedDiscount = requestedDiscount;
            ViewedDateTime = null;
        }

        public DiscountRequest(int id, DateTime createdDateTime, ShopManager manager, Discount requestedDiscount) : this (createdDateTime, manager, requestedDiscount) 
        {
            ID = id;
        }

        public DiscountRequest(int id, DateTime createdDateTime, ShopManager manager, Discount requestedDiscount, DateTime? viewedDateTime) : this(id, createdDateTime, manager, requestedDiscount)
        {
            ViewedDateTime = viewedDateTime;
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
            if (CreatedDateTime is null)
            {
                throw new ArgumentException("Created datatime can`t be null");
            }
            if (Manager is null)
            {
                throw new ArgumentException("Shop manager can`t be null");
            }
            if (RequestedDiscount is null)
            {
                throw new ArgumentException("Requested discount can`t be null");
            }
            return true;
        }
    }
}
