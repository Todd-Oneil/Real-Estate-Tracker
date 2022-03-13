using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace RealEstate
{
    class DatabaseConnection
    {

        public static MySqlConnection OpenConnection()
        {
            /*
             * 1. Sets required connection variables and then builds a connection string with those variables
             * 2. Uses the connection string as a parameter to try and connect to the corresponding database
             * 3. If the connection cannot be established throw and error message in a new window and close
             */
            string host = "127.0.0.1";// 1
            string db = "property";// 1
            string username = "root";// 1
            string password = "root";// 1
            string conString = "datasource =" + host + "; database =" + db + "; port=3306; username =" + username + "; password =" + password + "; SslMode=none;";// 1

            MySqlConnection connection = new MySqlConnection(conString);// 2
            try
            {
                connection.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("MySql Connection! \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// 3
            }
            return connection;
        }

        public static void AddUser(User user)
        {
            /*
             * 1. Build parameterized query string
             * 2. Open database connection
             * 3. Add values to the parameters in the query
             * 4. Execute query and add a new user to the database
             * 5. If an error occurs throw and error message in a new window and close
             */
            string query = "INSERT INTO users VALUES (NULL, @username, @password)";// 1
            MySqlConnection connection = OpenConnection();// 2
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = user.GetUsername;// 3
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.GetPassword;// 3

            try
            {
                command.ExecuteNonQuery();// 4
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Database Error! \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// 5
            }
            connection.Close();
        }

        public static bool Auth(ref User user)
        {
            /*
             * 1. Build parameterized query string
             * 2. Open database connection
             * 3. Add values to the parameters in the query
             * 4. Create reader object that will read data from the database using the query
             * 5. Check reader's result to see if a record is returned, if there is a match attach returned values to the user object and return true
             * 6. If no match is found, return false
             * 7. If Username does not match return false
             * 8. If Password does not match return flase
             */
            string username = user.GetUsername;
            string pass = User.ComputeHash(user.GetPassword);
            string query = "SELECT * FROM property.users p WHERE p.username =@username AND p.password =@password";// 1
            bool authenticated = false;
            MySqlConnection connection = OpenConnection();// 2
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;// 3
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = pass;// 3
            try
            {
                MySqlDataReader reader = command.ExecuteReader();// 4
                while (reader.Read())
                {
                    if (username.Equals(reader.GetString("username")) && !pass.Equals(reader.GetString("password")))
                    {
                        authenticated = false;// 8
                    }
                    else if (!username.Equals(reader.GetString("username")) && pass.Equals(reader.GetString("password")))
                    {
                        authenticated = false;// 7
                    }
                    else if (username.Equals(reader.GetString("username")) && pass.Equals(reader.GetString("password")))// 5
                    {
                        authenticated = true;
                        user.SetUsername = reader.GetString("username");
                        user.SetPassword = reader.GetString("password");
                        user.SetID = reader.GetInt32("ID");
                        break;
                    }
                    else
                        authenticated = false;// 6
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Invalid Query", "Login Error! " + e.Message, MessageBoxButtons.OK);
            }
            connection.Close();

            return authenticated;
        }

        public static void AddProperty(Property prop)
        {
            /*
             * 1. Build parameterized query string
             * 2. Open database connection
             * 3. Add values to the parameters in the query
             * 4. Execute query
             * 5. If an error occurs display a message in a new window and close
             */
            string query = "INSERT INTO properties VALUES (NULL, @city, @address, @asking_price, @purchase_price, @down_payment, @mortgage_rate, @mortgage_term, " +
                "@mortgage_payment, @monthly_rent, @condo_fees, @mgmt_fee, @utilities, @prop_tax, @profit_loss, @user)";// 1

            MySqlConnection connection = OpenConnection();// 2
            MySqlCommand command = new MySqlCommand(query, connection);

            command.CommandType = CommandType.Text;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = prop.GetCity;// 3
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = prop.GetAddress;// 3
            command.Parameters.Add("@asking_price", MySqlDbType.Decimal).Value = prop.GetAskingPrice;// 3
            command.Parameters.Add("@purchase_price", MySqlDbType.Decimal).Value = prop.GetPurchasePrice;// 3
            command.Parameters.Add("@down_payment", MySqlDbType.Decimal).Value = prop.GetDownPayment;// 3
            command.Parameters.Add("@mortgage_rate", MySqlDbType.Decimal).Value = prop.GetMortgageRate;// 3
            command.Parameters.Add("@mortgage_term", MySqlDbType.Int32).Value = prop.GetMortgageTerm;// 3
            command.Parameters.Add("@mortgage_payment", MySqlDbType.Decimal).Value = prop.GetMortgagePayment;// 3
            command.Parameters.Add("@monthly_rent", MySqlDbType.Decimal).Value = prop.GetMonthlyRent;// 3
            command.Parameters.Add("@condo_fees", MySqlDbType.Decimal).Value = prop.GetCondoFees;// 3
            command.Parameters.Add("@mgmt_fee", MySqlDbType.Decimal).Value = prop.GetMgmtFee;// 3
            command.Parameters.Add("@utilities", MySqlDbType.Decimal).Value = prop.GetMonthlyUtility;// 3
            command.Parameters.Add("@prop_tax", MySqlDbType.Decimal).Value = prop.GetPropertyTax;// 3
            command.Parameters.Add("@profit_loss", MySqlDbType.Decimal).Value = prop.GetProfitLoss;// 3
            command.Parameters.Add("@user", MySqlDbType.Int32).Value = prop.GetUser;// 3

            try
            {
                command.ExecuteNonQuery();// 4
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Could Not Add Property! \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// 5
            }
            connection.Close();
        }

        public static bool UserCheck(string name)
        {
            /*
             * 1. Build parameterized query string
             * 2. Open database connection
             * 3. Add values to the parameters in the query
             * 4. Create reader object to read data from the database
             * 5. Check database for the passed in username, if it exists return true
             */
            string query = "SELECT * FROM property.users p WHERE p.username =@username";// 1
            bool exists = false;
            MySqlConnection connection = OpenConnection();// 2
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = name;// 3
            try
            {
                MySqlDataReader reader = command.ExecuteReader();// 4
                reader.Read();
                if (name.Equals(reader.GetString("username")))// 5
                {
                    exists = true;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error", "Registration Error! " + e.Message, MessageBoxButtons.OK);
            }
            connection.Close();

            return exists;
        }
        public static bool PropertyCheck(string city, string address, int user)
        {
            /*
             * 1. Build parameterized query string
             * 2. Open database connection
             * 3. Add values to the parameters in the query
             * 4. Create reader object to read data from the database
             * 5. Check database for the property using the CIty, Address, and user_ID, if it exists return true
             */
            string query = "SELECT * FROM property.properties p WHERE p.city =@city AND p.address =@city AND p.users_ID = @user";// 1
            bool exists = false;
            MySqlConnection connection = OpenConnection();// 2
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;// 3
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;// 3
            command.Parameters.Add("@user", MySqlDbType.Int32).Value = user;// 3
            try
            {
                MySqlDataReader reader = command.ExecuteReader();// 4
                while(reader.Read())
                {
                    if (city.Equals(reader.GetString("city")) && address.Equals(reader.GetString("address")) && user.Equals(reader.GetInt32("users_ID")))// 5
                    {
                        exists = true;
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Property Already Exists in Records", "Record Error! " + e.Message, MessageBoxButtons.OK);
            }
            connection.Close();

            return exists;
        }

        public static void Display(int ID, DataGridView dgv)
        {
            /*
             * 1. Build parameterized query string
             * 2. Open database connection
             * 3. Add values to the parameters in the query
             * 4. Create a DataAdapter object to read data from the database and populate a dataset
             * 5. Create a DataTable object
             * 6. Fill the DataTable object with the ResultSet
             * 7. assign the table to the DataGridView entity that was passed in
             */
            string query = "SELECT ID, city, address, asking_price, purchase_price, down_payment, " +
                "mortgage_rate, mortgage_term, mortgage_payment, total_monthly_rent, monthly_condo_fees, monthly_mgmt_fee, " +
                "monthly_utilities, monthly_prop_tax, monthly_profit_loss FROM property.properties p WHERE p.users_ID =@user";// 1

            MySqlConnection connection = OpenConnection();// 2
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@user", MySqlDbType.Int32).Value = ID;// 3

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);// 4
            DataTable tbl = new DataTable();// 5
            adapter.Fill(tbl);// 6
            dgv.DataSource = tbl;// 7

            connection.Close();
        }
    }
}
