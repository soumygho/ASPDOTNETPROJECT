using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{

    public class CategoryOperation
    {
        private DatabaseOperation dbops = null;
        public CategoryOperation()
        {
            dbops = new DatabaseOperation();
        }

        public bool insertIntoCategory(Category category)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "insert into category (categoryname)";
                command += "values ('" + category.Categoryname + "'";
                command += ");";
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

        public bool updateCategory(Category category)
        {

            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update category set categoryname = '"+category.Categoryname+"' where id = "+category.Id+"";
                command += "values ('" + category.Categoryname + "'";
                command += ");";
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

        public List<Category> getCategory()
        {
            List<Category> categories = null;
            try
            {
                dbops.getConnection();
                string command = "select * from category;";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    categories = new List<Category>();
                    while (dbops.dbcon.dr.Read())
                    {
                        Category category = new Category();
                        category.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        category.Categoryname = dbops.dbcon.dr["categoryname"].ToString();
                        categories.Add(category);
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
            return categories;
        }
    }
}
