using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entity
{
    public  class Gamer : IEntity
    {
        public int gamerId { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public int tc { get; set; }
        public DateTime dateBirth { get; set; }
    }
}
