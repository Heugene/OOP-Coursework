using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IAuthorizable
    {
        /// <summary>
        /// checks if specified login exists
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public bool Identificate(string login);

        /// <summary>
        /// checks if specified credentials are valid
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Authentificate(string login, string password);

        /// <summary>
        /// Here is the authorization logic
        /// </summary>
        /// <returns></returns>
        public bool Authorize();

    }
}
