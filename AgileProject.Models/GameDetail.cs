using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Models
{
    public class GameDetail
    {
        [Display(Name = "Game Title")]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Rating Rating { get; set; }
    }
}
