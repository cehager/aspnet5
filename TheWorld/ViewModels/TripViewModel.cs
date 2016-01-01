using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TheWorld.Models;

namespace TheWorld.ViewModels
{
    public class TripViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255,MinimumLength =3)]
        public string Name { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        //public string UserName { get; set; }

        public ICollection<Stop> Stops { get; set; }
    }
}
