using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace animalProject1.Models.Requests
{
    public class UpdateRegisterRequest : AddRegisterRequest
    {
        [Required]
        public int Id { get; set; }
    }
}