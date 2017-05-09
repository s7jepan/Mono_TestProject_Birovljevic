using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public interface IVehicleService
    {
        //Makes
        List<VehicleMake> GetAllVehicleMakes();
        VehicleMake GetVehicleMakeById();
        void InsertVehicleMake(VehicleMake make);
        void UpdateVehicleMake(VehicleMake make);
        void DeleteVehicleMake(VehicleMake make);

        //Models
        List<VehicleModel> GetAllVehicleModels();
        VehicleModel GetVehicleModelById();
        void InsertVehicleModel(VehicleModel model);
        void UpdateVehicleModel(VehicleModel model);
        void DeleteVehicleModel(VehicleModel model);
    }
}
