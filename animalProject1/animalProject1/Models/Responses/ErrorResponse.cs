using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace animalProject1.Models.Responses
{
    public class ErrorResponse : BaseResponse
    {

        public List<String> Errors { get; set; }

        public ErrorResponse(string errMsg)
        {
            Errors = new List<string>();

            Errors.Add(errMsg);
            this.IsSuccessFul = false;
        }

        public ErrorResponse(IEnumerable<String> errMsg)
        {
            Errors = new List<string>();

            Errors.AddRange(errMsg);
            this.IsSuccessFul = false;
        }

    }
}