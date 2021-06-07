using System;
using System.Collections.Generic;
using duongsinh2.entity;
using duongsinh2.Helper;
using MySql.Data.MySqlClient;

namespace duongsinh2.model
{
    public class StreetMoDel
    {
        

        public List<Street> FindAll()
        {
         List<Street> _listStreet = new List<Street>();
        
            var cmd = new MySqlCommand(){Connection = ConnectionHelper.GetConnection()};
            try
            {
                cmd.CommandText = $"select *  from streets";
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    _listStreet.Add(new Street()
                    {
                        Ma = result["Ma"].ToString(),
                        Ten = result["Ten"].ToString(),
                        MoTa = result["MoTa"].ToString(),
                        LichSu = result["LichSu"].ToString(),
                        TrangThai = int.Parse(result["TrangThai"].ToString()),
                        TenQuan = result["TenQuan"].ToString()
                    });
                }
                result.Close();
                return _listStreet;
            }
            catch (MySqlException e)
            {
                return _listStreet;
            }
        }

        public bool Save(Street street)
        {
            var cmd = new MySqlCommand(){Connection = ConnectionHelper.GetConnection()};
            try
            {
                cmd.CommandText = $"insert into streets(`Ma`,`Ten`,`MoTa`,`NgaySuDung`,`LichSu`,`TenQuan`) values ('{street.Ma}','{street.Ten}','{street.MoTa}','{street.NgaySuDung}','{street.LichSu}','{street.TenQuan}')";
                var result = cmd.ExecuteNonQuery();
                if (result != 0)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public Street FindById(string id)
        {
            Street street = null;
            var cmd = new MySqlCommand(){Connection = ConnectionHelper.GetConnection()};
            try
            {
                cmd.CommandText = $"select * from streets where Ma = '{id}'";
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    street = new Street()
                    {
                        Ma = result["Ma"].ToString(),
                        Ten = result["Ten"].ToString(),
                        MoTa = result["MoTa"].ToString(),
                        LichSu = result["LichSu"].ToString(),
                        TrangThai = int.Parse(result["TrangThai"].ToString()),
                        TenQuan = result["TenQuan"].ToString()
                    };
                }
                result.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Không tìm thấy");
            }
            return street;
        }

        public bool Update(string id, Street updateStreet)
        {
            
            var cmd = new MySqlCommand(){Connection = ConnectionHelper.GetConnection()};
            try
            {
                cmd.CommandText = $"update streets set Ten = '{updateStreet.Ten}',LichSu = '{updateStreet.LichSu}',MoTa = '{updateStreet.MoTa}',TenQuan = '{updateStreet.TenQuan}'where Ma = '{id}'";
                var result = cmd.ExecuteNonQuery();
                if (result != 0)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            var cmd = new MySqlCommand(){Connection = ConnectionHelper.GetConnection()};
            try
            {
                cmd.CommandText = $"delete from streets where Ma = '{id}'";
                var result = cmd.ExecuteNonQuery();
                if (result != 0)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }
        
    }
}