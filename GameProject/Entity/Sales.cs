using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entity
{
    public class Sales : IEntity
    {
        public int Id { get; set; }
        public string GamerName { get; set; }
        public string ProductName { get; set; }
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }
        public int ProductPrice { get; set; }
    }
}
