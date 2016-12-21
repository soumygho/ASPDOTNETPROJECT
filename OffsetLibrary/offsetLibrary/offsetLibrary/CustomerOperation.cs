using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerOperation
/// </summary>
/// 
namespace offsetLibrary
{
    public class CustomerOperation
    {
        private DatabaseOperation dbops = null;
        public CustomerOperation()
        {
            dbops = new DatabaseOperation();
        }
        public bool insertintoCustomer(CustomerDetails customer)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "insert into customerdetails (custname,custaddress,custmobno,custemail) values ('" + customer.Customername + "','" + customer.CustomerAddress + "','" + customer.Customermobno + "','" + customer.Customeremail + "');";
                dbops.executeNonQuery(command);
                flag = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbops.closeConnection();
            }
            return flag;
        }

        public bool updateCustomerDetails(CustomerDetails customer)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update customerdetails set custname = '" + customer.Customername + "' , custaddress = '" + customer.CustomerAddress + "' , custmobno = '" + customer.Customermobno + "' ,custemail = '" + customer.Customeremail + "';";
                dbops.executeNonQuery(command);
                flag = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbops.closeConnection();
            }
            return flag;
        }

        public List<CustomerDetails> readCustomers(String start)
        {
            List<CustomerDetails> customers = null;
            try
            {
                dbops.getConnection();
                string command = "select * from customerdetails where custname like '"+start+"%';";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    customers = new List<CustomerDetails>();
                    while (dbops.dbcon.dr.Read())
                    {
                        CustomerDetails customer = new CustomerDetails();
                        customer.Customerid = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        customer.Customername = dbops.dbcon.dr["custname"].ToString();
                        customer.CustomerAddress = dbops.dbcon.dr["custaddress"].ToString();
                        customer.Customermobno = dbops.dbcon.dr["custmobno"].ToString();
                        customer.Customeremail = dbops.dbcon.dr["custemail"].ToString();
                        customers.Add(customer);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbops.closeConnection();
            }
            return customers;
        }
        public List<CustomerDetails> readCustomers(int id)
        {
            List<CustomerDetails> customers = null;
            try
            {
                dbops.getConnection();
                string command = "select * from customerdetails where id = "+id+";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    customers = new List<CustomerDetails>();
                    while (dbops.dbcon.dr.Read())
                    {
                        CustomerDetails customer = new CustomerDetails();
                        customer.Customerid = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        customer.Customername = dbops.dbcon.dr["custname"].ToString();
                        customer.CustomerAddress = dbops.dbcon.dr["custaddress"].ToString();
                        customer.Customermobno = dbops.dbcon.dr["custmobno"].ToString();
                        customer.Customeremail = dbops.dbcon.dr["custemail"].ToString();
                        customers.Add(customer);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbops.closeConnection();
            }
            return customers;
        }

        public List<CustomerDetails> readCustomers()
        {
            List<CustomerDetails> customers = null;
            try
            {
                dbops.getConnection();
                string command = "select * from customerdetails ;";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    customers = new List<CustomerDetails>();
                    while (dbops.dbcon.dr.Read())
                    {
                        CustomerDetails customer = new CustomerDetails();
                        customer.Customerid = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        customer.Customername = dbops.dbcon.dr["custname"].ToString();
                        customer.CustomerAddress = dbops.dbcon.dr["custaddress"].ToString();
                        customer.Customermobno = dbops.dbcon.dr["custmobno"].ToString();
                        customer.Customeremail = dbops.dbcon.dr["custemail"].ToString();
                        customers.Add(customer);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbops.closeConnection();
            }
            return customers;
        }


        public List<CustomerDetails> readCustomers(CustomerDetails custdetails)
        {
            List<CustomerDetails> customers = null;
            try
            {
                dbops.getConnection();
                string command = "select * from customerdetails where id = "+custdetails.Customerid+";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    customers = new List<CustomerDetails>();
                    while (dbops.dbcon.dr.Read())
                    {
                        CustomerDetails customer = new CustomerDetails();
                        customer.Customerid = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        customer.Customername = dbops.dbcon.dr["custname"].ToString();
                        customer.CustomerAddress = dbops.dbcon.dr["custaddress"].ToString();
                        customer.Customermobno = dbops.dbcon.dr["custmobno"].ToString();
                        customer.Customeremail = dbops.dbcon.dr["custemail"].ToString();
                        customers.Add(customer);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbops.closeConnection();
            }
            return customers;
        }

        public List<CustomerDetails> readCustomerByNameMobNOAndAddress(CustomerDetails custdetails)
        {
            List<CustomerDetails> customers = null;
            try
            {
                dbops.getConnection();
                string command = "select * from customerdetails where custname = '" + custdetails.Customername + "' and custaddress = '"+custdetails.CustomerAddress+"' and custmobno = '"+custdetails.Customermobno+"';";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    customers = new List<CustomerDetails>();
                    while (dbops.dbcon.dr.Read())
                    {
                        CustomerDetails customer = new CustomerDetails();
                        customer.Customerid = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        customer.Customername = dbops.dbcon.dr["custname"].ToString();
                        customer.CustomerAddress = dbops.dbcon.dr["custaddress"].ToString();
                        customer.Customermobno = dbops.dbcon.dr["custmobno"].ToString();
                        customer.Customeremail = dbops.dbcon.dr["custemail"].ToString();
                        customers.Add(customer);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbops.closeConnection();
            }
            return customers;
        }

    }
}
