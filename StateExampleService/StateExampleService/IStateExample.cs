using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StateExampleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface IStateExample
    {

        [OperationContract(Name = "Initialize")]
        void Initialize(int a);

        [OperationContract(Name = "Add")]
        int Add(int a, int b);


        [OperationContract(Name = "Multiply")]
        int Multiply(int a, int b);


        [OperationContract(Name = "AddTwo")]
        int AddTwo(int a);


        [OperationContract(Name = "MultiplyTwo")]
        int MultiplyTwo(int a);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
  
}
