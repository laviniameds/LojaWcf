using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LojaWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        List<Fabricante> FabricanteSelect();

        [OperationContract]
        void FabricanteInsert(int id, string descricao);

        [OperationContract]
        void FabricanteUpdate(int id, string descricao);

        [OperationContract]
        void FabricanteDelete(int id);

        [OperationContract]
        List<Veiculo> VeiculoSelectDisponiveis();

        [OperationContract]
        void VeiculoInsert(int id, string modelo, int ano, int idFab, DateTime dataCompra,
            decimal valorCompra, decimal precoVenda, DateTime dataVenda, decimal valorVenda);

        [OperationContract]
        void VeiculoUpdate(int id, string modelo, int ano, int idFab, DateTime dataCompra,
            decimal valorCompra, decimal precoVenda, DateTime dataVenda, decimal valorVenda);

        [OperationContract]
        void VeiculoDelete(int id);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
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
