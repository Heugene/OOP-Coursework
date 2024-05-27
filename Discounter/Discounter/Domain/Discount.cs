using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Discount : IValidable
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public DiscountedItem? Item { get; set; }
        public string Description { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public byte Percentage 
        { 
            get { return (byte)(100 * (1 - NewPrice / OldPrice)); }
        }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public bool IsApproved { get; private set; } = false;
        public bool WasRejected { get; private set; } = false;

        public void Approve()
        {
            IsApproved = true;
            Approved?.Invoke(this, EventArgs.Empty);
        }

        public void Reject()
        {
            WasRejected = true;
            Rejected?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? Approved;

        public event EventHandler? Rejected;

        public Discount() { }

        public Discount(string name, string description, decimal oldPrice, decimal newPrice, DateTime startDateTime, DateTime endDateTime)
        {
            Name = name;
            Description = description;
            OldPrice = oldPrice;
            NewPrice = newPrice;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }

        public Discount(string name, DiscountedItem item, string description, decimal oldPrice, decimal newPrice, DateTime startDateTime, DateTime endDateTime) : this(name, description, oldPrice, newPrice, startDateTime, endDateTime)
        {
            Item = item;
        }

        public Discount(int id, string name, DiscountedItem item, string description, decimal oldPrice, decimal newPrice, DateTime startDateTime, DateTime endDateTime) : this(name, item, description, oldPrice, newPrice, startDateTime, endDateTime)
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
            if (Item is null)
            {
                throw new ArgumentException("Item can`t be null");
            }
            if (String.IsNullOrEmpty(Description))
            {
                throw new ArgumentException("Description can`t be null or an empty string");
            }
            if (OldPrice <= 0)
            {
                throw new ArgumentException("Old price can`t be below or equal to zero");
            }
            if (NewPrice < 0)
            {
                throw new ArgumentException("New price can`t be below zero");
            }
            if (NewPrice >= OldPrice)
            {
                throw new ArgumentException("New price can`t be higher or equal to the old price");
            }
            if (StartDateTime is null)
            {
                throw new ArgumentException("Start datetime can`t be null");
            }
            if (EndDateTime is null)
            {
                throw new ArgumentException("End datetime can`t be null");
            }
            if (StartDateTime < DateTime.Now)
            {
                throw new ArgumentException("Start datetime can`t be in the past lol");
            }
            if (EndDateTime < StartDateTime) 
            {
                throw new ArgumentException("End datetime can`t be before the start datetime xd");
            }
            return true;
        }
    }
}
