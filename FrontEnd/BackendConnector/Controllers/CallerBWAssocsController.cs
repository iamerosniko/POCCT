﻿using BackendConnector.Entities;
using BackendConnector.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendConnector.Controllers
{
    [EnableCors("CORS")]
    [Route("api/[controller]")]
    [ApiController]
    public class CallerBWAssocsController
    {
        APIAccess _apiAccess;

        public CallerBWAssocsController(string apiUrl)
        {
            _apiAccess = new APIAccess("CallerAssocs", apiUrl);
        }
        //public async void Get()
        [HttpGet]
        public async Task<List<CtdCallerAssocs>> Get()
        {
            var result = await _apiAccess.GetRequest();
            var Calls = JsonConvert.DeserializeObject<List<CtdCallerAssocs>>(result);
            return Calls;
        }
        [HttpGet]
        public async Task<CtdCallerAssocs> Get(string callAssocID)
        {
            var result = await _apiAccess.GetRequest(callAssocID);
            var Call = result == null ? new CtdCallerAssocs() : JsonConvert.DeserializeObject<CtdCallerAssocs>(result);
            return Call;
        }

        [HttpGet]
        public async Task<CtdCallerAssocs> Post(CtdCallerAssocs callAssoc)
        {
            var body = JsonConvert.SerializeObject(callAssoc);
            var result = await _apiAccess.PostRequest(body);
            var Call = JsonConvert.DeserializeObject<CtdCallerAssocs>(result);
            return Call;
        }

        [HttpGet]
        public async Task<CtdCallerAssocs> Put(CtdCallerAssocs callAssoc)
        {
            var body = JsonConvert.SerializeObject(callAssoc);
            var result = await _apiAccess.PutRequest(callAssoc.CallerAssocID.ToString(), body);
            return await Get(callAssoc.CallerAssocID.ToString());
        }

        [HttpGet]
        public async Task<CtdCallerAssocs> Delete(string callAssocID)
        {
            var result = await _apiAccess.DeleteRequest(callAssocID);
            var Call = JsonConvert.DeserializeObject<CtdCallerAssocs>(result);
            return Call;
        }
    }
}
