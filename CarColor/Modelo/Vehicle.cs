using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarColor.Modelo
{
    public class Vehicle
    {
        public int ID { get; set; }
        public int ColorID { get; set; }
        public string EnrollNumber { get; set; }
        public int MarkID { get; set; }   
        public int ModelID { get; set; }
        public int Year { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
