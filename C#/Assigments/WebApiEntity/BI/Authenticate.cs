using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiEntity;

namespace BI
{
    /// <summary>
    /// The main class for the business layer.
    /// </summary>
    public class Authenticate
    {
        // HttpClient reference for the business layer.
        public HttpClient clientObj;
        
        /// <summary>
        /// ctor for the Authenticate class.
        /// </summary>
        /// <param name="uri"></param>
        public Authenticate(string uri)
        {
            clientObj = new HttpClient();
            clientObj.BaseAddress = new Uri(uri);
        }

        /// <summary>
        /// Register method for user signup.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> RegisterAsync(AuthDetail user)
        {
            HttpResponseMessage response = await clientObj.PostAsJsonAsync("api/AuthDetails", user);

            if(response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// User Login Method.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> LoginAsync(AuthDetail user)
        {
            string response = await clientObj.GetStringAsync("api/AuthDetails/" + user.username);

            try
            {
                AuthDetail userResponse = JsonConvert.DeserializeObject<AuthDetail>(response);

                return user.password == userResponse.password;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Update Password Method as a reference for forgot password users.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="newpassword"></param>
        /// <returns></returns>
        public bool UpdatePassword(string name, string newpassword)
        {
            throw new NotImplementedException();
        }
    }
}
