using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    public class User : IdentityUser
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        
        public string Name { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}