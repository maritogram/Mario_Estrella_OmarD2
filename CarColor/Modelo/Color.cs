using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarColor.Modelo
{
    public class Color
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Visible { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
