using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebApplication3.Models;

namespace WebApplication3.repository
{
    public class Common
    {
        private SqlConnection con;

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }

        public List<AppRefData> GetAppRefData(int parentId)
        {
            List<AppRefData> appRefDataList = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("GetAppRefData_Training_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@parentId", SqlDbType.Int);
            cmd.Parameters["@parentId"].Value = parentId;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new AppRefData { KeyId = Convert.ToInt32(reader["KeyId"]), KeyName = reader["KeyName"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }


        public List<Emplist> GetAppRefId()
        {
            List<Emplist> appRefDataList = new List<Emplist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_BatchId_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;
          
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                   new Emplist { Id = Convert.ToInt32(reader["KeyId"]), Name = reader["Description"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }


        public List<Emplist> GetEmplists()
        {
            List<Emplist> appRefDataList = new List<Emplist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_WorkingLocation_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;
       
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Emplist { Id = Convert.ToInt32(reader["WorkingLocation_Id"]), Name = reader["Location_Name"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }


        public List<Emplist> GetWorkingCompany()
        {
            List<Emplist> appRefDataList = new List<Emplist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_WorkingCompany_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Emplist { Id = Convert.ToInt32(reader["CompanyMaster_Id"]), Name = reader["CompanyName"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }

        public List<Emplist> GetDepartment()
        {
            List<Emplist> appRefDataList = new List<Emplist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_Department_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Emplist { Id = Convert.ToInt32(reader["Dept_Code"]), Name = reader["Dept_Name"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }


        public List<Emplist> GetHrRepresentative()
        {
            List<Emplist> appRefDataList = new List<Emplist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_HrRepresentative_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Emplist { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["FullName"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }


        public List<Emplist> GetRecrut()
        {
            List<Emplist> appRefDataList = new List<Emplist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_ActualRecrut_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Emplist { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["Full_Name"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }


    }
}

//        public bool AppRefData(AppRefData obj)
//        {

//            Connection();
//            SqlCommand com = new SqlCommand("GetAppRefData_Training_Ankur", con);
//            com.CommandType = CommandType.StoredProcedure;
//            com.Parameters.AddWithValue("@parentId", obj.CustomerName);
//            com.Parameters.AddWithValue("@ProjectName", obj.ProjectName);
//            com.Parameters.AddWithValue("@ProjectID", obj.ProjectID);
//            com.Parameters.AddWithValue("@StartDate", obj.StartDate);
//            com.Parameters.AddWithValue("@EndDate", obj.EndDate);
//            com.Parameters.AddWithValue("@ProjectStatus", obj.ProjectStatus);
//            com.Parameters.AddWithValue("@LocationGroup", obj.LocationGroup);
//            com.Parameters.AddWithValue("@PayRoll", obj.PayRoll);
//            com.Parameters.AddWithValue("@SalesPerson", obj.SalesPerson);
//            com.Parameters.AddWithValue("@ProjectCategory", obj.ProjectCategory);
//            com.Parameters.AddWithValue("@ProjectType", obj.ProjectType);
//            com.Parameters.AddWithValue("@SubDomain", obj.SubDomain);
//            com.Parameters.AddWithValue("@TimeSheetRepresentative", obj.TimeSheetRepresentative);
//            com.Parameters.AddWithValue("@ClientInvoiceGroup", obj.ClientInvoiceGroup);
//            com.Parameters.AddWithValue("@TimeSheetType", obj.TimeSheetType);
//            com.Parameters.AddWithValue("@IsVMSTimesheet", obj.IsVMSTimesheet);
//            com.Parameters.AddWithValue("@PracticeType", obj.PracticeType);
//            com.Parameters.AddWithValue("@Recruiter", obj.Recruiter);

//            con.Open();
//            int i = com.ExecuteNonQuery();
//            con.Close();
//            if (i >= 1)
//            {

//                return true;

//            }
//            else
//            {

//                return false;
//            }


//        }



//        public List<AppRefData> XGetAppRefData(int ProjectId)
//        {
//            List<AppRefData> appRefList = new List<AppRefData>();

//            Connection();
//            SqlCommand cmd = new SqlCommand("GetAppRefData_Training_Ashil", con);
//            cmd.CommandType = CommandType.StoredProcedure;

//            SqlParameter[] param = new SqlParameter[1];
//            param[0] = new SqlParameter("@ProjectId", DbType.Int32);
//            param[0].Value = ProjectId;

//            cmd.Parameters.AddRange(param);


//            SqlDataAdapter da = new SqlDataAdapter(cmd);
//            DataTable dt = new DataTable();
//            con.Open();
//            da.Fill(dt);
//            con.Close();

//            foreach (DataRow dr in dt.Rows)
//            {
//                appRefList.Add(

//                    new AppRefData
//                    {
//                        ProjectId = Convert.ToInt32(dr["ProjectId"]),
//                        CustomerName = Convert.ToString(dr["CustomerName"]),
//                        ProjectName = Convert.ToString(dr["ProjectName"]),
//                        ProjectID = Convert.ToInt32(dr["ProjectID"]),
//                        StartDate = Convert.ToDateTime(dr["StartDate"]),
//                        EndDate = Convert.ToDateTime(dr["EndDate"]),
//                        ProjectStatus = Convert.ToInt32(dr["ProjectStatus"]),
//                        LocationGroup = Convert.ToInt32(dr["LocationGroup"]),
//                        PayRoll = Convert.ToInt32(dr["PayRoll"]),
//                        SalesPerson = Convert.ToString(dr["SalesPerson"]),
//                        ProjectCategory = Convert.ToInt32(dr["ProjectCategory"]),
//                        ProjectType = Convert.ToInt32(dr["ProjectType"]),
//                        SubDomain = Convert.ToInt32(dr["SubDomain"]),
//                        TimeSheetRepresentative = Convert.ToString(dr["TimeSheetRepresentative"]),
//                        ClientInvoiceGroup = Convert.ToInt32(dr["ClientInvoiceGroup"]),
//                        TimeSheetType = Convert.ToInt32(dr["TimeSheetType"]),
//                        IsVMSTimesheet = Convert.ToInt32(dr["IsVMSTimesheet"]),
//                        PracticeType = Convert.ToInt32(dr["PracticeType"]),
//                        Recruiter = Convert.ToString(dr["Recruiter"]),

//                    }

//                    );
//            }

//            return appRefList;
//        }

//    }
//}
    
