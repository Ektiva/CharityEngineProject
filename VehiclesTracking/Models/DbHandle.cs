using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace VehiclesTracking.Models
{
    public class DbHandle
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["defaultconnection"].ToString();
            con = new SqlConnection(constring);
        }

        // **************** ADD NEW VEHICLE *********************
        public bool AddVehicle(Vehicle vehicle)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddNewVehicle", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Make", vehicle.Make);
            cmd.Parameters.AddWithValue("@Model", vehicle.Model);
            cmd.Parameters.AddWithValue("@Color", vehicle.Color);
            cmd.Parameters.AddWithValue("@RegistrationNumber", vehicle.RegistrationNumber);
            cmd.Parameters.AddWithValue("@DOR", vehicle.DOR);
            cmd.Parameters.AddWithValue("@FirstName", vehicle.FirstName);
            cmd.Parameters.AddWithValue("@LastName", vehicle.LastName);
            cmd.Parameters.AddWithValue("@PhoneNumber", vehicle.PhoneNumber);
            cmd.Parameters.AddWithValue("@UnitNumber", vehicle.UnitNumber);
            cmd.Parameters.AddWithValue("@AptNumber", vehicle.AptNumber);

            con.Open();

            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // ********** VIEW VEHICLE DETAILS ********************
        public List<Vehicle> GetVehicle()
        {
            connection();
            List<Vehicle> vehicleList = new List<Vehicle>();

            SqlCommand cmd = new SqlCommand("GetVehicleDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                vehicleList.Add(
                    new Vehicle
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Make = Convert.ToString(dr["Make"]),
                        Model = Convert.ToString(dr["Model"]),
                        Color = Convert.ToString(dr["Color"]),
                        RegistrationNumber = Convert.ToInt32(dr["RegistrationNumber"]),
                        DOR = Convert.ToDateTime(dr["DOR"]),
                        FirstName = Convert.ToString(dr["FirstName"]),
                        LastName = Convert.ToString(dr["LastName"]),
                        PhoneNumber = Convert.ToString(dr["PhoneNumber"]),
                        UnitNumber = Convert.ToInt32(dr["UnitNumber"]),
                        AptNumber = Convert.ToInt32(dr["AptNumber"])
                    });
            }
            return vehicleList;
        }

        // ***************** UPDATE VEHICLE DETAILS *********************
        public bool UpdateVehicle(Vehicle vehicle)
        {
            connection();
            SqlCommand cmd = new SqlCommand("UpdateVehicleDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@VehicleId", vehicle.Id);
            cmd.Parameters.AddWithValue("@Make", vehicle.Make);
            cmd.Parameters.AddWithValue("@Model", vehicle.Model);
            cmd.Parameters.AddWithValue("@Color", vehicle.Color);
            cmd.Parameters.AddWithValue("@RegistrationNumber", vehicle.RegistrationNumber);
            cmd.Parameters.AddWithValue("@DOR", vehicle.DOR);
            cmd.Parameters.AddWithValue("@FirstName", vehicle.FirstName);
            cmd.Parameters.AddWithValue("@LastName", vehicle.LastName);
            cmd.Parameters.AddWithValue("@PhoneNumber", vehicle.PhoneNumber);
            cmd.Parameters.AddWithValue("@UnitNumber", vehicle.UnitNumber);
            cmd.Parameters.AddWithValue("@AptNumber", vehicle.AptNumber);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // ********************** DELETE VEHICLE DETAILS *******************
        public bool DeleteVehicle(int id)
        {
            connection();
            SqlCommand cmd = new SqlCommand("DeleteVehicle", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@VehicleId", id);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // ********** SEARCH VEHICLE OWNER'S ********************
        public OwnerContactDto GetVehicleOwner(int registrationNumber)
        {
            connection();

            SqlCommand cmd = new SqlCommand("GetVehicleOwner", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RegistrationNumber", registrationNumber);

            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            if(dt.Rows.Count < 1)
            {
                return null;
            }
            con.Close();

            OwnerContactDto owner = new OwnerContactDto
            {
                FirstName = Convert.ToString(dt.Rows[0]["FirstName"]),
                PhoneNumber = Convert.ToString(dt.Rows[0]["PhoneNumber"]),
                RegistrationNumber = Convert.ToInt32(dt.Rows[0]["RegistrationNumber"])
            };

            return owner;
        }
    }
}