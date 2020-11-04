using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using RestSharp;

namespace TenmoClient
{
    class AccountService
    {
        private readonly static string API_URL = "https://localhost:44315/account";
        private readonly IRestClient client = new RestClient();

        public decimal GetBalance(int userId)
        {
            RestRequest request = new RestRequest(API_URL);
            request.AddJsonBody(userId);
            IRestResponse<decimal> response = client.Get<decimal>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("An error occurred communicating with the server.");
                throw new Exception();
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("An error response was received from the server. The status code is " + (int)response.StatusCode);
                throw new Exception();
            }
            else
            {
                return response.Data;
            }
        }
    }
}
