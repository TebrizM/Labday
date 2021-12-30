using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlHomework.Models
{
    public class TrainerSocial
    {
        public int Id { get; set; }
        public int TrainerId { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public Trainers Trainer { get; set; }
    }
}
