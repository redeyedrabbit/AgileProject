using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Models
{
    public class GameEdit
    {
        public int Id { get; set; }

        [MaxLength(75, ErrorMessage = "There are too many characters in game name.")]
        public string Name { get; set; }

        [MinLength(5, ErrorMessage = "Please enter a more detailed description.")]
        [MaxLength(500, ErrorMessage = "The game description is too long.")]
        public string Description { get; set; }

        public decimal Price { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Rating Rating { get; set; }

    }
}
