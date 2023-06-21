using FunPro_CW1_12670.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace FunPro_CW1_12670.DAL
{
    public class WorkerManager : DbManager
    {
       public void Create(Worker c)
       {
           var connection = Connection;
           try
           {
                var sql = $@" INSERT INTO sw_social_worker
           (sw_name_12670
           ,sw_region_12670
           ,sw_hours_12670
          )
     VALUES
           ('{c.Name}', '{c.Region}','{c.Hours}')";
               var command = new SqlCeCommand(sql, connection);
               connection.Open();
               command.ExecuteNonQuery();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
           finally
           {
               if (connection.State != ConnectionState.Closed)
               {
                  connection.Close();
               }
           }
            //Creating new data and sending it to the database
       }



        public void Update(Worker c)
        {
           var connection =Connection;
           try
           {
               var sql = $@" UPDATE [sw_social_worker] 
   SET 
       sw_name_12670 = '{c.Name}',
       sw_region_12670 = {c.Region},
       sw_hours_12670 = {c.Hours}
   WHERE 
       sw_id_12670 = {c.Id}";

                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
           }
            catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
            finally
           {
               if (connection.State != ConnectionState.Closed)
               {
                    connection.Close();
               }
           }
            //Updating an existing data in the DB
        }



        public void Delete(int id)
        {
            var connection =Connection;
            try
            {
                var sql =$"DELETE FROM sw_social_worker WHERE sw_id_12670 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
             //Deleting an existing data in the DB
        }


       
        public List<Worker> GetAll()
        {
            var connection =Connection;
            var result = new List<Worker>();
            try
            {
                var sql = "SELECT sw_id_12670, sw_name_12670, sw_region_12670, sw_hours_12670 FROM sw_social_worker";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Worker
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1)),
                        Region = Convert.ToInt32(reader.GetValue(2)),
                        Hours = Convert.ToInt32(reader.GetValue(3))

                    };
                    result.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return result;

            //A method which returns a selected items from DB 
        }



        public List<Worker> GetAllHours()
        {
            var connection = Connection;
            var result = new List<Worker>();
            try
            {
                var sql = "SELECT sw_hours_12670 FROM sw_social_worker";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Worker
                    {
                        
                        Hours = Convert.ToInt32(reader.GetValue(3))

                    };
                    result.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return result;
        }



        public Worker GetById(int id)
        {
            var connection =Connection;
            var result = new List<Worker>();
            try
            {
                var sql = $@"SELECT 
      sw_name_12670
      ,sw_region_12670
      ,sw_hours_12670
  FROM sw_social_worker
  WHERE sw_id_12670 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Worker
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1)),
                        Region = Convert.ToInt32(reader.GetValue(2)),
                        Hours = Convert.ToInt32(reader.GetValue(3))
                    };
                    result.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            //When something went wrong
            return null;
        }
    }








}
