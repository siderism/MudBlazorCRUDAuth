using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace final.Data
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(1), MaxLength(10)]
        public int Ects { get; set; }
        //public List<Student> Students { get; set; }
    }
}
