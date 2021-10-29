using System;
using System.ComponentModel.DataAnnotations;

namespace BeastRescue
{
    public class Beast
    {
        public int BeastId { get; set; }
        public string Name { get; set; }
        [Required]
        public string Species { get; set; }
        public string Temperment {get; set;}
        public string Description {get; set;}
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Photo {get; set;}
    }
}
