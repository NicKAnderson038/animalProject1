using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace animalProject1.Domain
{
    public class Register
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateModified { get; set; }

        public string UserId { get; set; }


    }
}