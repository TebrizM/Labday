using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SqlHomework.Models
{
    public class Trainers
    {

        public int Id { get; set; }
        [StringLength(maximumLength: 50)]
        public string Image { get; set; }
        [StringLength(maximumLength: 20)]
        public string Title { get; set; }
        [StringLength(maximumLength: 20)]
        public string Position { get; set; }
        [StringLength(maximumLength: 200)]
        public string Content { get; set; }


    }
}
