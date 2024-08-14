using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Registration_Form.Helper
{
    public class RequestHelper
    {
        static string BaseUrl = "https://localhost:44385/api/";
        public static IRestResponse Get(string geturl)
        {

            RestClient client = new RestClient(RequestHelper.BaseUrl);
            var request = new RestRequest(geturl, Method.GET)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddHeader("Content-Type", "application/json");
            var Response = client.Execute(request);
            return Response;
        }
        public static IRestResponse Post(string url, object model)
        {
            RestClient restClient = new RestClient(RequestHelper.BaseUrl);
            var request = new RestRequest(url, Method.POST)
            {
                RequestFormat = DataFormat.Json
            };
            var jsonObject = JsonConvert.SerializeObject(model);
            request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);
            var response = restClient.Execute(request);
            return response;
        }
        public static IRestResponse Put(string url, object model)
        {
            RestClient restClient = new RestClient(RequestHelper.BaseUrl);
            var request = new RestRequest(url, Method.PUT)
            {
                RequestFormat = DataFormat.Json
            };
            var jsonObject = JsonConvert.SerializeObject(model);
            request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);
            var response = restClient.Execute(request);
            return response;
        }

        public static IRestResponse Delete(string url, object model)
        {
            RestClient restClient = new RestClient(RequestHelper.BaseUrl);
            var request = new RestRequest(url, Method.DELETE)
            {
                RequestFormat = DataFormat.Json
            };
            var jsonObject = JsonConvert.SerializeObject(model);
            request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);
            var response = restClient.Execute(request);
            return response;
        }
    }
}