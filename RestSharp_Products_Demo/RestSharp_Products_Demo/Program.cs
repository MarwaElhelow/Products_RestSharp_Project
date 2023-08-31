using RestSharp;
using System;
using NUnit;
using NUnit.Framework;
using System.Net;

namespace RestSharp_FirstProject
{
    public class RestSharpRunner
    {
        public static void Main(string[] args)
        {
            // Precondition Initialization
            var baseUrl = "https://dummyjson.com/products";
            var client = new RestClient(baseUrl);
            var request = new RestRequest();

            Console.WriteLine($"{baseUrl} {request.Method}");

            var response = client.Execute(request);

            Console.WriteLine($"Response Content: {response.Content}");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }

}