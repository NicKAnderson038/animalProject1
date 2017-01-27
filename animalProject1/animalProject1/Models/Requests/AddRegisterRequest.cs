using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace animalProject1.Models.Requests
{
    public class AddRegisterRequest
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        // Nulls could not be allowed for some reason, So i used this code to allow empty inputs via RESTclient. However, its not necessary after wiring it up :/ ?
        //[Required(AllowEmptyStrings = true)]
        //[DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Message { get; set; }

        public string UserId { get; set; }
    }
}