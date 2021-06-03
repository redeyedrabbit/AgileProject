using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Data
{
    // Rachel
    public enum GenreType { Action = 1, Adventure, Fighting, Platform, Puzzle, Racing, Shooter, Simulation, Sports, Strategy, Misc }
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public GenreType TypeOfGenre { get; set; }
    }
}
