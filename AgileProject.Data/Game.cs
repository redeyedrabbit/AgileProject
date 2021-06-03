using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Data
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        [ForeignKey(nameof(Genre))]
        public string Genre { get; set; }
        public virtual Genre Genre { get; set; }

        [ForeignKey(nameof(Rating))]
        public int Rating { get; set; }
        public virtual Rating Rating { get; set; }
    }
}
