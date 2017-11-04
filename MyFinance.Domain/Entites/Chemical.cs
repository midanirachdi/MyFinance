using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entites
{
   public  class Chemical:Product
    {
        public string LabName { get; set; }
        public Adress myAddress { get; set; }//t^ype complex
    }
}
