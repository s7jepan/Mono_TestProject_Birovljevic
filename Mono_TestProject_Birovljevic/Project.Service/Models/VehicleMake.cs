using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class VehicleMake
    {
        public VehicleMake()
        {
            this.VehicleModels = new List<VehicleModel>();
        }
        //scalar properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        //navigation propertie, one2many, virtual = lazyloading
        public virtual ICollection<VehicleModel> VehicleModels { get; set; }
    }
}
