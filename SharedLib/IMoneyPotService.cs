using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace SharedLib
{
    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface IMoneyPotService
    {
        // Static 
        [OperationContract(IsOneWay = false, IsInitiating = true)]
        decimal GetMoneyStatic(int clientID);

        // Instance
        [OperationContract(IsOneWay = false, IsInitiating = true)]
        decimal GetMoneyInstance(int clientID);

    } // end of interface
}
