using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace offsetLibrary
{
    public class PaperDetailsOperation
    {
        private DatabaseOperation dbops = null;
        private DbConnection dbcon = null;
         public PaperDetailsOperation()
        {
            dbops = new DatabaseOperation();
            dbcon = new DbConnection();
        }
        public bool insertIntoPaperDetails(PaperDetails paperdetails)
        {
            bool flag = false;
            bool hassame = false;
            try
            {
                List<PaperDetails> papers = readAllPaperDetails();
                if (papers != null)
                {
                    for (int i = 0; i < papers.Count; i++)
                    {
                        if (papers[i].Papername.Equals(paperdetails.Papername))
                        {
                            hassame = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
                if (!hassame)
                {
                    try
                    {
                        dbops.getConnection();

                        String command = "insert into paperdetails (papername,paperrate)";
                        command += "values ('" + paperdetails.Papername + "','" + paperdetails.Paperrate + "');";

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
                }
            return flag;
        }

        public bool upadtePaperDetails(PaperDetails paperdetails)
        {
            bool flag = false;
            OleDbTransaction transaction = null;
            try
            {
                dbcon.con.Open();
                 transaction = dbcon.con.BeginTransaction();
                dbcon.cmd.Connection = dbcon.con;
                dbcon.cmd.Transaction = transaction;
                string command = "update paperdetails set paperrate = '" + paperdetails.Paperrate + "' where papername = '"+paperdetails.Papername+"';";
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
                transaction.Commit();
                

                flag = true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception em)
                {
                    throw em;
                }
            }
            finally
            {
                dbcon.con.Close();
            }
            return flag;
        }

        public List<PaperDetails> readSpecificPaperDetails(PaperDetails paperdetails)
        {
            bool flag = false;
            List<PaperDetails> papers = null;
            try
            {
                dbops.getConnection();
                string command = "select * from paperdetails where papername = '"+paperdetails.Papername+"'; ";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    papers = new List<PaperDetails>();
                    while (dbops.dbcon.dr.Read())
                    {
                        PaperDetails paper = new PaperDetails();
                        paper.Paperrate = float.Parse(dbops.dbcon.dr["paperrate"].ToString());
                        paper.Papername = paperdetails.Papername;
                        paper.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        papers.Add(paper);
                        
                    }
                }

               
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
            return papers;
        }
        public List<PaperDetails> readAllPaperDetails()
        {
            bool flag = false;
            List<PaperDetails> papers = null;
            try
            {
                dbops.getConnection();
                string command = "select * from paperdetails ; ";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    papers = new List<PaperDetails>();
                    while (dbops.dbcon.dr.Read())
                    {
                        PaperDetails paper = new PaperDetails();
                        paper.Paperrate = float.Parse(dbops.dbcon.dr["paperrate"].ToString());
                        paper.Papername = dbops.dbcon.dr["papername"].ToString();
                        paper.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        papers.Add(paper);

                    }
                }
                dbops.dbcon.dr.Close();

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
            return papers;
        }
        public DataTable generatePageDetailsTable(List<PaperDetails> papers)
        {
            DataTable data = null;
            
            if (papers != null&&papers.Count>0)
            {
                data = new DataTable();
                DataColumn col = new DataColumn("PAPER NAME",typeof(String));
                data.Clear();
                data.Columns.Add(col);
                col = new DataColumn("RATE PER PAGE",typeof(float));
                data.Columns.Add(col);
                for (int i = 0; i < papers.Count; i++)
                {
                    DataRow dr = data.NewRow();
                    dr["PAPER NAME"] = papers[i].Papername;
                    dr["RATE PER PAGE"] = papers[i].Paperrate;
                    data.Rows.Add(dr);
                }
            }
            return data;
        }
    
    }
}
