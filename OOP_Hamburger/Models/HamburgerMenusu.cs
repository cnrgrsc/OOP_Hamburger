using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburger.Models
{
   public  class HamburgerMenusu:BaseEntity
    {
        public string Description { get; set; }
        public override string ToString()
        {
            return $"{Ad} =>{Fiyat:C2}";
        }
    }
}
