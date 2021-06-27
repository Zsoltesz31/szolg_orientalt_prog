using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonyvtarService
{
    public class DatabaseManager
    {
        static string connStr = "server=localhost;user=root;database=konyvtarservice;port=3306;password=";
        MySqlConnection conn = new MySqlConnection(connStr);
        MySqlCommand cmd;
        MySqlDataReader rdr;
     

        
            
        public List<Konyv> ListKonyvek(string querystring)
        {
            try
            {
                List<Konyv> konyvek = new List<Konyv>();
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Konyv konyv = new Konyv();
                    konyv.k_Id = int.Parse(rdr["id"].ToString());
                    konyv.k_Cim = rdr["cim"].ToString();
                    konyv.k_Mufaj = rdr["mufaj"].ToString();
                    konyv.k_Oldalszam = int.Parse(rdr["oldalszam"].ToString());
                    konyv.StringFormatum = String.Format("{0} {1} {2}", konyv.k_Cim, konyv.k_Mufaj, konyv.k_Oldalszam);
                    konyvek.Add(konyv);
                }
                conn.Close();
                return konyvek;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public List<KolcsonzottKonyv> ListKolcsonzott(string querystring)
        {
            try
            {
                List<KolcsonzottKonyv> kolcsonzottek = new List<KolcsonzottKonyv>();
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    KolcsonzottKonyv kolcsonzott = new KolcsonzottKonyv();
                    kolcsonzott.Id = int.Parse(rdr["id"].ToString());
                    kolcsonzott.Cim = rdr["cim"].ToString();
                    kolcsonzott.Mufaj = rdr["mufaj"].ToString();
                    kolcsonzott.Oldalszam = int.Parse(rdr["oldalszam"].ToString());
                    kolcsonzott.Kolcsonzo = rdr["kolcsonzo"].ToString();
                    kolcsonzott.KolcsonzottFormatum = String.Format("{0} {1}", kolcsonzott.Cim, kolcsonzott.Kolcsonzo);
                    kolcsonzottek.Add(kolcsonzott);
                }
                conn.Close();
                return kolcsonzottek;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<KolcsonzottKonyv> ListKolcsonzottToUser(string querystring, User user)
        {
            try
            {
                List<KolcsonzottKonyv> kolcsonzottek = new List<KolcsonzottKonyv>();
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                cmd.Parameters.AddWithValue("@username", user.Fnev);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    KolcsonzottKonyv kolcsonzott = new KolcsonzottKonyv();
                    kolcsonzott.Id = int.Parse(rdr["id"].ToString());
                    kolcsonzott.Cim = rdr["cim"].ToString();
                    kolcsonzott.Mufaj = rdr["mufaj"].ToString();
                    kolcsonzott.Oldalszam = int.Parse(rdr["oldalszam"].ToString());
                    kolcsonzott.Kolcsonzo = rdr["kolcsonzo"].ToString();
                    kolcsonzott.KolcsonzottFormatum = String.Format("{0} {1}", kolcsonzott.Cim, kolcsonzott.Kolcsonzo);
                    kolcsonzottek.Add(kolcsonzott);
                }
                conn.Close();
                return kolcsonzottek;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Register(string querystring, string felhasznalonev, string jelszo)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                cmd.Parameters.AddWithValue("@username", felhasznalonev);
                cmd.Parameters.AddWithValue("@password", jelszo);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex )
            {

                throw ex;
            }
            
        }

        public User Login(string querystring, string felhasznalonev, string jelszo)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                cmd.Parameters.AddWithValue("@username", felhasznalonev);
                cmd.Parameters.AddWithValue("@password", jelszo);
                rdr = cmd.ExecuteReader();
                rdr.Read();

                User user = new User();
                user.u_Id = int.Parse(rdr["id"].ToString());
                user.Fnev = rdr["fnev"].ToString();
                user.Passw = "";
                user.Jogkor = int.Parse(rdr["jogkor"].ToString());


                conn.Close();
                return user;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public int RegisterCheck(string querystring, string felhasznalonev)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                cmd.Parameters.AddWithValue("@username", felhasznalonev);
                rdr = cmd.ExecuteReader();
                rdr.Read();

                //conn.Close();
                return int.Parse(rdr["COUNT(*)"].ToString());
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void InsertKonyv(string querystring, Konyv konyv)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                cmd.Parameters.AddWithValue("@title", konyv.k_Cim);
                cmd.Parameters.AddWithValue("@genre", konyv.k_Mufaj);
                cmd.Parameters.AddWithValue("@pagenumber", konyv.k_Oldalszam);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void InsertKonyv2(string querystring, KolcsonzottKonyv kolcsonzott)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                cmd.Parameters.AddWithValue("@title", kolcsonzott.Cim);
                cmd.Parameters.AddWithValue("@genre", kolcsonzott.Mufaj);
                cmd.Parameters.AddWithValue("@pagenumber", kolcsonzott.Oldalszam);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void InsertKolcsonzott(string querystring, Konyv konyv, User user)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                cmd.Parameters.AddWithValue("@title", konyv.k_Cim);
                cmd.Parameters.AddWithValue("@genre", konyv.k_Mufaj);
                cmd.Parameters.AddWithValue("@pagenumber", konyv.k_Oldalszam);
                cmd.Parameters.AddWithValue("@user", user.Fnev);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateKonyv(string querystring, Konyv konyv)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                cmd.Parameters.AddWithValue("@id", konyv.k_Id);
                cmd.Parameters.AddWithValue("@title", konyv.k_Cim);
                cmd.Parameters.AddWithValue("@genre", konyv.k_Mufaj);
                cmd.Parameters.AddWithValue("@pagenumber", konyv.k_Oldalszam);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteKonyv(string querystring,Konyv konyv)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                cmd.Parameters.AddWithValue("@id", konyv.k_Id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
         

        }

        public void DeleteKolcsonzott(string querystring, KolcsonzottKonyv kolcsonzott)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                cmd.Parameters.AddWithValue("@id", kolcsonzott.Id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Kolcsonoz(string querystring, Konyv konyv, User user)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(querystring, conn);
                cmd.Parameters.AddWithValue("@title", konyv.k_Cim);
                cmd.Parameters.AddWithValue("@kolcsonzo", user.Fnev);


                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DatabaseManager()
        {

        }

        public DatabaseManager(string connectionstring)
        {
            connStr = connectionstring;
        }
    }
}