using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceContract
{
    [ServiceContract]
    public interface IOperation1
    {
        [OperationContract]
        int sumNumbersBetween(int a, int b);
        [OperationContract]
        int modulo(int a, int b);
    }

    [ServiceContract]
    public interface IOperation2
    {
        [OperationContract]
        String multiplay(String str, int a); 
        [OperationContract]
        String reverse(String str);
        [OperationContract]
        String concat(String str1, String str2);
    }

}
