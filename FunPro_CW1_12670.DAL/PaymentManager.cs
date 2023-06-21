using FunPro_CW1_12670.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;


namespace FunPro_CW1_12670.DAL
{
    public class PaymentManager : DbManager
    {
        public void Create(Payment p)
        {
            var connection = Connection;
            try
            {
                var sql = $@"INSERT INTO rp_region_payment
           (rp_date_12670
           ,rp_region_12670
           ,rp_headcount_12670
           ,rp_limit_12670
           ,rp_paid_12670)
     VALUES
           ('{p.Date:yyyy-MM-dd}',
            {p.Region},
            {p.Headcount},
            {p.Limit},
            {p.Paid})";
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


        public void Update(Payment p)
            { 
                var connection =Connection;
                try
                {
                var sql = $@"
                    UPDATE sw_social_worker SET
                    rp_date_12670 = '{p.Date}',
                    rp_region_12670 = '{p.Region:yyyy-MM-dd}',
                    rp_headcount_12670 = '{p.Headcount}',
                    rp_limit_12670 = '{p.Limit}',
                    rp_paid_12670 = '{p.Paid}'
                    WHERE rp_id_12670 = {p.Id}";

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
                    var sql = $"DELETE FROM rp_region_payment WHERE rp_id_12670 = {id}";
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

        public Payment GetById(int id)
            {
                var connection =Connection;
                try
                {
                var sql = $@" SELECT 
       rp_id_12670
      ,rp_region_12670
      ,rp_headcount_12670
      ,rp_limit_12670
      ,rp_paid_12670
  FROM rp_region_payment
  WHERE rp_id_12670 = {id}";
                    var command = new SqlCeCommand(sql, connection);
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var a = GetFromReader(reader);
                        return a;
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

        public List<Payment> GetAll()
        {
              var connection =Connection;
              var result = new List<Payment>();
              try
              {
                  var sql = "SELECT rp_id_12670, rp_date_12670, rp_region_12670, rp_headcount_12670, rp_limit_12670, rp_paid_12670 FROM rp_region_payment"; 
                  var command = new SqlCeCommand(sql, connection);
                  connection.Open();
                  var reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      var a = GetFromReader(reader);
                      result.Add(a);
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

        private Payment GetFromReader(SqlCeDataReader reader)
        {
             var a = new Payment
             {
                 Id = Convert.ToInt32(reader.GetValue(0)),
                 Date = Convert.ToDateTime(reader.GetValue(1)),
                 Region = Convert.ToInt32(reader.GetValue(2)),
                 Headcount = Convert.ToInt32(reader.GetValue(3)),
                 Limit = Convert.ToInt32(reader.GetValue(4)),
                 Paid = Convert.ToInt32(reader.GetValue(5))
             };

             return a;

             //A method that sets the values of certain properties used in the above methods

        }
    }
}

