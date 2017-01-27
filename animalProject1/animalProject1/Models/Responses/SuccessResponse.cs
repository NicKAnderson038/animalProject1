using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace animalProject1.Models.Responses
{
    public class SuccessResponse : BaseResponse
    {

        public SuccessResponse()
        {

            this.IsSuccessFul = true;
        }

    }
}