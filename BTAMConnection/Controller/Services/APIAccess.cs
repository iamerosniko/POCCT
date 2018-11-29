﻿using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BTAMConnection.Controller.Services
{
    public class APIAccess
    {
        private string _apiURL;
        private string _apiToken;
        private HttpClient _client;

        public APIAccess(string controller, string apiURL)
        {
            _apiURL = apiURL;
            _apiURL = _apiURL + controller;

            _client = new HttpClient();

        }

        public async Task<string> PostRequest(string body)
        {
            var content = new StringContent(body, Encoding.UTF8, "application/json");

            try
            {
                var request = await _client.PostAsync(_apiURL, content);

                if (request.IsSuccessStatusCode)
                {
                    var result = request.Content.ReadAsStringAsync().Result;
                    return result;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }



        public async Task<string> GetRequest()
        {
            try
            {
                var request = await _client.GetAsync(_apiURL);
                if (request.IsSuccessStatusCode)
                {
                    var result = request.Content.ReadAsStringAsync().Result;
                    return result;
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<string> GetRequest(string id)
        {
            try
            {
                var request = await _client.GetAsync(_apiURL + "/" + id);
                if (request.IsSuccessStatusCode)
                {
                    var result = request.Content.ReadAsStringAsync().Result;
                    return result;
                }

                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
