using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KonyvtarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<User> getUsers(string username)
        {
            lock (LoggedUsers.loggedUser)
            {
                if (LoggedIn(username)==false)
                {
                    throw new Exception("Kérlek jelentkezz be!");
                }
                return LoggedUsers.loggedUser;
            }
        }
        
        public void DeleteKonyv(Konyv konyv, string username)
        {
            if (LoggedIn(username) == false)
            {
                throw new Exception("Kérlek jelentkezz be!");
            }
            DatabaseManager dm = new DatabaseManager();
            dm.DeleteKonyv("DELETE FROM konyvek WHERE id=@id", konyv);
        }

        public void InsertKonyv(Konyv konyv, string username)
        {
            if (LoggedIn(username) == false)
            {
                throw new Exception("Kérlek jelentkezz be!");
            }
            if (konyv.k_Oldalszam<1)
            {
                throw new Exception("Az oldalszám nem lehet kevesebb mint 1!");
            }
            DatabaseManager dm = new DatabaseManager();
            dm.InsertKonyv("INSERT INTO konyvek(cim,mufaj,oldalszam) VALUES(@title, @genre, @pagenumber)",konyv);
        }

        public User Login(string fnev, string jelszo)
        {
            lock (LoggedUsers.loggedUser)
            {
                try
                {
                    DatabaseManager dm = new DatabaseManager();
                    LoggedUsers.loggedUser.Add(dm.Login("SELECT id,jogkor,fnev FROM users WHERE fnev = @username AND jelszo = @password", fnev, jelszo));
                    return dm.Login("SELECT id,jogkor,fnev FROM users WHERE fnev = @username AND jelszo = @password", fnev, jelszo);
                }
                catch(Exception)
                {
                    throw new Exception("Hibás adatok!");
                }
            }
        }

        public void Register(string fnev, string jelszo)
        {
            DatabaseManager dm = new DatabaseManager();
            dm.Register("INSERT INTO users(fnev,jelszo) VALUES(@username, @password)",fnev,jelszo);
        }

        public void UpdateKonyv(Konyv konyv, string username)
        {
           
                if (LoggedIn(username) == false)
                {
                    throw new Exception("Kérlek jelentkezz be!");
                }
                if (konyv.k_Oldalszam < 1)
                {
                    throw new Exception("Az oldalszám nem lehet kevesebb mint 1!");
                }
                DatabaseManager dm = new DatabaseManager();
                dm.UpdateKonyv("UPDATE konyvek SET cim = @title, mufaj = @genre, oldalszam = @pagenumber WHERE id=@id", konyv);
            
          
        }

        List<Konyv> IService1.ListKonyvek(string username)
        {
            if (LoggedIn(username) == false)
            {
                throw new Exception("Kérlek jelentkezz be!");
            }
            DatabaseManager dm = new DatabaseManager();
            return dm.ListKonyvek("SELECT * FROM konyvek"); 

        }

        public void Logout(User user)
        {
            lock (LoggedUsers.loggedUser)
            {
                LoggedUsers.loggedUser.RemoveAll((u) => u.Fnev == user.Fnev);
            }
        }

        public void Kolcsonoz(Konyv konyv, User user, string username)
        {
            if (LoggedIn(username) == false)
            {
                throw new Exception("Kérlek jelentkezz be!");
            }
            DatabaseManager dm = new DatabaseManager();
            List<Konyv> teszt = new List<Konyv>();
            
            teszt = dm.ListKonyvek("SELECT * FROM konyvek");
            for (int i = 0; i < teszt.Count; i++)
            {
                if (teszt[i].k_Id==konyv.k_Id)
                {
                    dm.DeleteKonyv("DELETE FROM konyvek WHERE id=@id", konyv);
                    dm.InsertKolcsonzott("INSERT INTO kolcsonzottkonyvek(cim,kolcsonzo,oldalszam,mufaj) VALUES(@title, @user, @pagenumber, @genre)", konyv, user);
                 
                    return;
                }
            }
            throw new Exception("Ezt a könyvet már valaki kikölcsönözte vagy a könyv nem létezik!");
           
            

        }

        public void Visszavisz(KolcsonzottKonyv kolcsonzott, string username)
        {
            if (LoggedIn(username) == false)
            {
                throw new Exception("Kérlek jelentkezz be!");
            }
            DatabaseManager dm = new DatabaseManager();
            dm.InsertKonyv2("INSERT INTO konyvek(cim,mufaj,oldalszam) VALUES(@title, @genre, @pagenumber)", kolcsonzott);
            dm.DeleteKolcsonzott("DELETE FROM kolcsonzottkonyvek WHERE id = @id",kolcsonzott);
        }

        public List<KolcsonzottKonyv> kolcsonzott(string username)
        {
            if (LoggedIn(username) == false)
            {
                throw new Exception("Kérlek jelentkezz be!");
            }
            DatabaseManager dm = new DatabaseManager();
            return dm.ListKolcsonzott("SELECT * FROM kolcsonzottkonyvek");
        }

        public List<KolcsonzottKonyv> listToUser(User user, string username)
        {
            if (LoggedIn(username) == false)
            {
                throw new Exception("Kérlek jelentkezz be!");
            }
            DatabaseManager dm = new DatabaseManager();
            return dm.ListKolcsonzottToUser("SELECT * FROM kolcsonzottkonyvek WHERE kolcsonzo = @username",user);
        }

        public bool LoggedIn(string fnev)
        {
            lock (LoggedUsers.loggedUser)
            {
                foreach (User u in LoggedUsers.loggedUser)
                {
                    if (fnev == u.Fnev)
                    {
                        return true;
                    }
                }
                return false;
            }
            
        }

        public int CheckRegister(string fnev)
        {
            DatabaseManager dm = new DatabaseManager();
            return dm.RegisterCheck("SELECT COUNT(*) FROM users WHERE fnev = @username", fnev);
        }
    }
}
