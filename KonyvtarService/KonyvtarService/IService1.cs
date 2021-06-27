using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KonyvtarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [FaultContract(typeof(Exception))]
        List<Konyv> ListKonyvek(string username);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        void Register(string fnev, string jelszo);
        
        [OperationContract]
        [FaultContract(typeof(Exception))]
        User Login(string fnev, string jelszo);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        void InsertKonyv(Konyv konyv, string username);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        void UpdateKonyv(Konyv konyv, string username);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        void DeleteKonyv(Konyv konyv, string username);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        List<User> getUsers(string username);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        void Logout(User user);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        void Kolcsonoz(Konyv konyv, User user, string username);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        void Visszavisz(KolcsonzottKonyv kolcsonzott, string username);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        List<KolcsonzottKonyv> kolcsonzott(string username);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        List<KolcsonzottKonyv> listToUser(User user, string username);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        bool LoggedIn(string fnev);

        [OperationContract]
        [FaultContract(typeof(Exception))]
        int CheckRegister(string fnev);

        

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Konyv
    {
        private int k_id;
        [DataMember]
        public int k_Id
        {
            get { return k_id; }
            set { k_id = value; }
        }

        private string k_cim;
        [DataMember]
        public string k_Cim
        {
            get { return k_cim; }
            set { k_cim = value; }
        }

        private string k_mufaj;
        [DataMember]
        public string k_Mufaj
        {
            get { return k_mufaj; }
            set { k_mufaj = value; }
        }

        private int k_oldalszam;
        [DataMember]
        public int k_Oldalszam
        {
            get { return k_oldalszam; }
            set { k_oldalszam = value; }
        }
        private string stringFormatum;
        [DataMember]
        public string StringFormatum
        {
            get { return stringFormatum; }
            set { stringFormatum = value; }

        }
        public Konyv()
        {

        }
        public Konyv(int id, string cim, string mufaj, int oldalszam)
        {
            this.k_Id = id;
            this.k_Cim = cim;
            this.k_Mufaj = mufaj;
            this.k_Oldalszam = oldalszam;
            this.StringFormatum = String.Format("{0} - {1} - {2}", k_Cim, k_Mufaj, k_Oldalszam);
        }   


    }

    public class User
    {
        private int u_id;
        [DataMember]
        public int u_Id
        {
            get { return u_id; }
            set { u_id = value; }
        }

        private string fnev;
        [DataMember]
        public string Fnev
        {
            get { return fnev; }
            set { fnev = value; }
        }

        private string passw;
        [DataMember]
        public string Passw
        {
            get { return passw; }
            set { passw = value; }
        }

        private int jogkor;
        [DataMember]
        public int Jogkor
        {
            get { return jogkor; }
            set { jogkor = value; }
        }

        public User()
        {
           
        }

        public User(int id, string fnev, string jelszo, int jogkor)
        {
            this.u_Id = id;
            this.Fnev = fnev;
            this.Passw = jelszo;
            this.Jogkor = jogkor;
            
        }

    }

    public class KolcsonzottKonyv
    {
        private int id;
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string cim;
        [DataMember]
        public string Cim
        {
            get { return cim; }
            set { cim = value; }
        }

        private string kolcsonzo;
        [DataMember]
        public string Kolcsonzo
        {
            get { return kolcsonzo; }
            set { kolcsonzo = value; }
        }

        private int oldalszam;
        [DataMember]
        public int Oldalszam
        {
            get { return oldalszam; }
            set { oldalszam = value; }
        }

        private string mufaj;
        [DataMember]
        public string Mufaj
        {
            get { return mufaj; }
            set { mufaj = value; }
        }

        private string kolcsonzottFormatum;

        public string KolcsonzottFormatum
        {
            get { return kolcsonzottFormatum; }
            set { kolcsonzottFormatum = value; }
        }



        public KolcsonzottKonyv()
        {

        }

        public KolcsonzottKonyv(int id, string cim, string kolcsonzo, int oldalszam, string mufaj)
        {
            this.Id = id;
            this.Cim = cim;
            this.Kolcsonzo = kolcsonzo;
            this.Mufaj = mufaj;
            this.Oldalszam = oldalszam;
            this.KolcsonzottFormatum = String.Format("Könyv: {0} Kölcsonző: {1}", Cim,Kolcsonzo);

        }

    }
    public class LoggedUsers
    {
        
        [DataMember]
        public static List<User> loggedUser = new List<User>();

        private string userFormat;
        [DataMember]
        public string UserFormat
        {
            get { return userFormat; }
            set { userFormat = value; }
        }

        


    }
}
