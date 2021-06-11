using ApplicationsService.DTOs;
using ApplicationsService.Implemetations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DistribAplic
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        InfantryManagementService infantry = new InfantryManagementService();
        BattalionManagementService battalion = new BattalionManagementService();
        BrigadeManagementService brigade = new BrigadeManagementService();
        DivisionManagementService division = new DivisionManagementService();

        public string DeleteBattalion(int id)
        {
            if (!battalion.DeleteBattalion(id))
            {
                return "Battalion not deleted";
            }
            return "Battalion deleted";
        }

        public string DeleteBrigade(int id)
        {
            if (!brigade.DeleteBrigade(id)) return "Brigade not deleted";
            return "Brigade deleted";
        }

        public string DeleteDivision(int id)
        {
            if(!division.DeleteDivision(id)) return "Division not deleted";
            return "Division deleted";
        }

        public string DeleteInfantry(int id)
        {
            if(!infantry.DeleteInfantry(id)) return "Infantry not deleted";
            return "Infantry deleted";
        }

        public List<BattalionDTO> GetBattalion()
        {
            return battalion.GetBattalion();
        }

        public List<BrigadeDTO> GetBrigade()
        {
            return brigade.GetBrigade();
        }

        public List<DivisionDTO> GetDivision()
        {
            return division.GetDivision();
        }

        public List<InfantryDTO> GetInfantry()
        {
            return infantry.GetInfantry();
        }

        public string SaveBattalion(BattalionDTO battalionDto)
        {
            if (!battalion.SaveBattalion(battalionDto))
            {
                return "Battalion not saved";
            }
            return "Battalion saved";
        }

        public string SaveBrigade(BrigadeDTO brigadeDto)
        {
            if (!brigade.SaveBrigade(brigadeDto))
            {
                return "Brigade not saved";
            }
            return "Brigade saved";
        }

        public string SaveDivision(DivisionDTO divisionDto)
        {
            if (!division.SaveDivision(divisionDto))
            {
                return "Division not saved";
            }
            return "Division saved";
        }

        public string SaveInfantry(InfantryDTO infantryDto)
        {
            if (!infantry.SaveInfantry(infantryDto))
            {
                return "Infantry not saved";
            }
            return "Infantry saved";
        }

        public InfantryDTO GetInfantryById(int id)
        {
            return infantry.GetInfantryById(id);
        }

        public BattalionDTO GetBattalionById(int id)
        {
            return battalion.GetBattalionById(id);
        }

        public BrigadeDTO GetBrigadeById(int id)
        {
            return brigade.GetBrigadeById(id);
        }

        public DivisionDTO GetDivisionById(int id)
        {
            return division.GetDivisionById(id);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        //Built In
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
