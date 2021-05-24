using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<Car> Cars { get; set; }
    }
}