using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace offsetLibrary
{
    public class PaperSizeOperation
    {
         private DatabaseOperation dbops = null;
         public PaperSizeOperation()
        {
            dbops = new DatabaseOperation();
        }
        public bool insertIntoPaperSize(PaperSize papersize)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                //read paper sizes to check unique desc
                bool hassame = false;
                string command = "select description from papersize where paperid = "+papersize.Paperid+";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    while (dbops.dbcon.dr.Read())
                    {
                        if (papersize.Description.Trim().ToUpper().Equals(dbops.dbcon.dr["description"].ToString()))
                        {
                            hassame = true;
                            break;
                        }
                    }
                }
                dbops.dbcon.dr.Close();
                if (!hassame)
                {
                    command = "insert into papersize (paperid,description,paperpersheet) ";
                    command += "values (" + papersize.Paperid + ",'" + papersize.Description + "'," + papersize.Noofpaperspersheet + ");";

                    dbops.executeNonQuery(command);
                    flag = true;
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
            return flag;
        }

        public bool upadtePaperSize(PaperSize papersize)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update papersize set paperpersheet = " + papersize.Noofpaperspersheet + ",description = '" + papersize.Description + "' where id = " + papersize.Id + ";";
              

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

        public List<PaperSize> readPapersizeForSpecificPaper(PaperDetails paper)
        {
            bool flag = false;
            List<PaperSize> sizes = null;
            try
            {
                dbops.getConnection();
                string command = "select * from papersize where paperid = "+paper.Id+";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    sizes = new List<PaperSize>();
                    while (dbops.dbcon.dr.Read())
                    {
                        PaperSize size = new PaperSize();
                        size.Paperid = Int32.Parse(dbops.dbcon.dr["paperid"].ToString());
                        size.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        size.Description = dbops.dbcon.dr["description"].ToString();
                        size.Noofpaperspersheet = Int32.Parse(dbops.dbcon.dr["paperpersheet"].ToString());
                        sizes.Add(size);
                        
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
            return sizes;
        }

        public List<PaperSize> readAllPapersize()
        {
            bool flag = false;
            List<PaperSize> sizes = null;
            try
            {
                dbops.getConnection();
                string command = "select papersize.id,papersize.description,papersize.paperpersheet,paperdetails.papername,paperdetails.paperrate from papersize,paperdetails where papersize.paperid = paperdetails.id ;";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    sizes = new List<PaperSize>();
                    while (dbops.dbcon.dr.Read())
                    {
                        PaperSize size = new PaperSize();
                       // size.Paperid = Int32.Parse(dbops.dbcon.dr["paperid"].ToString());
                        size.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        size.Description = dbops.dbcon.dr["description"].ToString();
                        size.Noofpaperspersheet = Int32.Parse(dbops.dbcon.dr["paperpersheet"].ToString());
                        size.Paper = new PaperDetails();
                        size.Paper.Papername = dbops.dbcon.dr["papername"].ToString();
                        size.Paper.Paperrate = float.Parse(dbops.dbcon.dr["paperrate"].ToString());
                        size.Rateperpaper = size.Paper.Paperrate / size.Noofpaperspersheet;
                        sizes.Add(size);

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
            return sizes;
        }

        public DataTable generateTable(List<PaperSize> sizes)
        {
            DataTable table = null;
            if (sizes != null && sizes.Count > 0)
            {
                table = new DataTable();
                DataColumn col = new DataColumn("PAPER NAME");
                table.Columns.Add(col);
                col = new DataColumn("DESCRIPTION");
                table.Columns.Add(col);
                col = new DataColumn("PAPERS/SHEET");
                table.Columns.Add(col);
                col = new DataColumn("RATE/SHEET");
                table.Columns.Add(col);
                col = new DataColumn("RATE/PAPER");
                table.Columns.Add(col);
                for (int i = 0; i < sizes.Count; i++)
                {
                    DataRow row = table.NewRow();
                    row["PAPER NAME"] = sizes[i].Paper.Papername;
                    row["DESCRIPTION"] = sizes[i].Description;
                    row["PAPERS/SHEET"] = sizes[i].Noofpaperspersheet;
                    row["RATE/SHEET"] = sizes[i].Paper.Paperrate;
                    row["RATE/PAPER"] = sizes[i].Rateperpaper;
                    table.Rows.Add(row);
                }

            }
            return table;
        }

        public List<PaperSize> readSpecificPapersize(int id)
        {
            bool flag = false;
            List<PaperSize> sizes = null;
            try
            {
                dbops.getConnection();
                string command = "select papersize.id,papersize.description,papersize.paperpersheet,paperdetails.papername,paperdetails.paperrate from papersize,paperdetails where papersize.id= "+id+" ;";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    sizes = new List<PaperSize>();
                    while (dbops.dbcon.dr.Read())
                    {
                        PaperSize size = new PaperSize();
                        // size.Paperid = Int32.Parse(dbops.dbcon.dr["paperid"].ToString());
                        size.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        size.Description = dbops.dbcon.dr["description"].ToString();
                        size.Noofpaperspersheet = Int32.Parse(dbops.dbcon.dr["paperpersheet"].ToString());
                        size.Paper = new PaperDetails();
                        size.Paper.Papername = dbops.dbcon.dr["papername"].ToString();
                        size.Paper.Paperrate = float.Parse(dbops.dbcon.dr["paperrate"].ToString());
                        size.Rateperpaper = size.Paper.Paperrate / size.Noofpaperspersheet;
                        sizes.Add(size);

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
            return sizes;
        }

        
    
    }
}
