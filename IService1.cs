using ApplicationsService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DistribAplic
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        //Infantry
        [OperationContract]
        List<InfantryDTO> GetInfantry();

        [OperationContract]
        InfantryDTO GetInfantryById(int id);

        [OperationContract]
        string SaveInfantry(InfantryDTO infantryDto); 
           
        [OperationContract]
        string DeleteInfantry(int id);

        //Battalions
        [OperationContract]
        List<BattalionDTO> GetBattalion();

        [OperationContract]
        BattalionDTO GetBattalionById(int id);
        [OperationContract]
        string SaveBattalion(BattalionDTO battalionDto);

        [OperationContract]
        string DeleteBattalion(int id);


        //Brigades
        [OperationContract]
        List<BrigadeDTO> GetBrigade();
        [OperationContract]
        BrigadeDTO GetBrigadeById(int id);
        [OperationContract]
        string SaveBrigade(BrigadeDTO brigadeDto);

        [OperationContract]
        string DeleteBrigade(int id);

        //Divisions

        [OperationContract]
        List<DivisionDTO> GetDivision();
        [OperationContract]
        DivisionDTO GetDivisionById(int id);
        [OperationContract]
        string SaveDivision(DivisionDTO divisionDto);

        [OperationContract]
        string DeleteDivision(int id);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "DistribAplic.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
