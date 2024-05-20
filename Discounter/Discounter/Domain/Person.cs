using System.Net;
using System.Text.RegularExpressions;

namespace Domain
{
    public abstract class Person
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public UserRole Role { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; protected set; }

        public Person() { }

        public Person(string name, UserRole role, string phoneNumber, string email, string password)
        {
            Name = name;
            Role = role;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
        }

        public Person(int id, string name, UserRole role, string phoneNumber, string email, string password) : this(name, role, phoneNumber, email, password)
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
        public virtual bool IsValid()
        {
            // Приклад телефонного номеру вірного формату "+380441234567" 
            // Регулярний вираз для перевірки українського телефонного номеру
            string phonePattern = @"^\+380\d{9}$";

            // Приклад емейлу вірного формату: aboba@gmail.com
            // Приклад емейлу вірного формату: y.i.heoka@student.khai.edu
            // Перевірив ці приклади на цьому виразі на https://regex101.com/
            // Регулярний вираз для перевірки емейлу
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";


            if (String.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Name can`t be null or an empty string");
            }
            if (String.IsNullOrEmpty(PhoneNumber))
            {
                throw new ArgumentException("Phone number can`t be null or an empty string");
            }
            if (!Regex.IsMatch(PhoneNumber, phonePattern))
            {
                throw new ArgumentException("Phone number format is invalid. Example of valid one: +380441234567. Only Ukrainian numbers are supported at the moment");
            }
            if (String.IsNullOrEmpty(Email))
            {
                throw new ArgumentException("Email can`t be null or an empty string");
            }
            if (!Regex.IsMatch(Email, emailPattern))
            {
                throw new ArgumentException("Email format is invalid");
            }
            if (String.IsNullOrEmpty(Password))
            {
                throw new ArgumentException("Password can`t be null or an empty string");
            }
            if (!IsStrongPassword(Password))
            {
                throw new ArgumentException("Format of password is wrong. Length: 8-12 characters, " +
                    "no special symbols or spaces allowed, must contain at least 1 uppercase character and 1 digit," +
                    " can contain only 2 the same characters in a row");
            }
            return true;
        }

        // Взяв з форуму і модифікував під свої потреби, мені підходить. Цікаве використання LINQ
        public static bool IsStrongPassword(string password)
        {
            // Minimum and Maximum Length of field - 8 to 12 Characters
            if (password.Length < 8 || password.Length > 12)
                return false;

            // Special Characters - Not Allowed
            // Spaces - Not Allowed
            if (!(password.All(c => char.IsLetter(c) || char.IsDigit(c))))
                return false;

            // Numeric Character - At least one character
            if (!password.Any(c => char.IsDigit(c)))
                return false;

            // At least one Capital Letter
            if (!password.Any(c => char.IsUpper(c)))
                return false;

            // Repetitive Characters - Allowed only two repetitive characters
            var repeatCount = 0;
            var lastChar = '\0';
            foreach (var c in password)
            {
                if (c == lastChar)
                    repeatCount++;
                else
                    repeatCount = 0;
                if (repeatCount == 2)
                    return false;
                lastChar = c;
            }

            return true;
        }
    }
}
