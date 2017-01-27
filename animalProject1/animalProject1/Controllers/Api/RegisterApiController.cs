//using animalProject1.Services.Interfaces;
using System;
using animalProject1.Domain;
using animalProject1.Models.Responses;
using animalProject1.Services;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using animalProject1.Models.Requests;

namespace animalProject1.Controllers.Api
{

    [RoutePrefix("api/registry")]
    public class RegisterApiController : ApiController
    {

        //private IRegistriesService _registriesService;
        //public RegisterApiController(IRegistriesService registriesService)
        //{
        //    _registriesService = registriesService;          
        //}

        [Route(), HttpGet]      
        public HttpResponseMessage GetAll()
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            ItemsResponse<Register> response = new ItemsResponse<Register>();
            response.Items = RegisterService.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [Route(), HttpPost]
        public HttpResponseMessage Post(AddRegisterRequest model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            ItemResponse<int> response = new ItemResponse<int>();
            response.Item = RegisterService.Post(model);
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [Route("{id:int}"), HttpGet]
        public HttpResponseMessage GetById(string id)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            ItemResponse<Register> response = new ItemResponse<Register>();
            response.Item = RegisterService.GetById(id);
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }
        
        [Route(), HttpPut]
        public HttpResponseMessage Update(UpdateRegisterRequest model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            RegisterService.Update(model);
            return Request.CreateResponse(HttpStatusCode.OK, true);
        }

        [Route("{id:int}"), HttpDelete]
        public HttpResponseMessage Delete(int Id)
        {
            RegisterService.Delete(Id);
            return Request.CreateResponse(new SuccessResponse());
        }


    }
}
