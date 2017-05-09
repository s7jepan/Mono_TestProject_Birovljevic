using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity; --- potreban za lambda exp

namespace Project.Service
{
    public class VehicleService : IVehicleService
    {
        private VehicleContext _context;
        public VehicleService()
        {
            _context = new VehicleContext();
        }

        public void DeleteVehicleMake(VehicleMake make)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicleModel(VehicleModel model)
        {
            throw new NotImplementedException();
        }

        public List<VehicleMake> GetAllVehicleMakes()
        {
            throw new NotImplementedException();
        }

        public List<VehicleModel> GetAllVehicleModels()
        {
            throw new NotImplementedException();
        }

        public VehicleMake GetVehicleMakeById()
        {
            throw new NotImplementedException();
        }

        public VehicleModel GetVehicleModelById()
        {
            throw new NotImplementedException();
        }

        public void InsertVehicleMake(VehicleMake make)
        {
            _context.VehicleMakes.Add(make);
            _context.SaveChanges();
        }

        public void InsertVehicleModel(VehicleModel model)
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicleMake(VehicleMake make)
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicleModel(VehicleModel model)
        {
            throw new NotImplementedException();
        }
    }
}
