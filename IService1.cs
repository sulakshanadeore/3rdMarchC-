using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        int Add(int i, int j);

        [OperationContract]
       List<Employees> GetDataEmployees();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Employees
    {
        private int _empid;
            [DataMember]
        public int Empid
        {
            get { return _empid; }
            set { _empid = value; }
        }

        private string _fname;
        [DataMember]
        public string Fname
        {
            get { return _fname; }
            set { _fname = value; }
        }

        private string _lname;

        public string LName
        {
            get { return _lname; }
            set { _lname = value; }
        }




    }
}
