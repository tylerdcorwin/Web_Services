﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OperationOrder
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IOperationOrder
    {

        [OperationContract(Name = "Initialize", IsInitiating = true)]
        void Initialize(int a);

        [OperationContract(Name = "Add", IsInitiating = false)]
        int Add(int a, int b);


        [OperationContract(Name = "Multiply", IsInitiating = false)]
        int Multiply(int a, int b);


        [OperationContract(Name = "AddTwo", IsInitiating = true)]
        int AddTwo(int a);


        [OperationContract(Name = "MultiplyTwo", IsInitiating = true)]
        int MultiplyTwo(int a);
    }


  
}
