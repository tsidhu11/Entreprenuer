using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace Entrepreneur_App
{
    class DataBaseConnection
    {
        //private OdbcConnection connection;
        public SqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private List<string>[] nameList = new List<string>[3];
        private List<string>[] inventionList = new List<string>[3];
        private List<string> industryNameList = new List<string>();
        private List<ValuePropositions> valuePropositionList = new List<ValuePropositions>();
        private List<EDdistribution> EDDistributionList = new List<EDdistribution>();
        private List<string> locationList = new List<string>();



        //Constructor
        public DataBaseConnection()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "";
            database = "game";
            uid = "root";
            password = "testpassword";
            /*server = "entrepreneur.database.windows.net";
            database = "testTable";
            uid = "entrepreneur";
            password = "TestPassword1";*/
            string connectionString;
            //connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; SSL mode = none;";

            //connection = new MySqlConnection(connectionString);
            connectionString = "Driver={ODBC Driver 13 for SQL Server}; Server=tcp:entrepreneur.database.windows.net,1433; Database=entrepreneur; Uid=entrepreneur@entrepreneur; Pwd=TestPassword1; Encrypt=yes; TrustServerCertificate=no; Connection Timeout=30;";
            connectionString = @"Data Source = (LocalDb)\entrepreneur; Initial Catalog = game; Integrated Security = True";
            connection = new SqlConnection(connectionString);
            /*string queryString =
              "INSERT INTO testTable (numb) Values(100)";
            OdbcCommand command = new OdbcCommand(queryString);

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();

                // The connection is automatically closed at 
                // the end of the Using block.
            }*/

            nameList[0] = new List<string>();
            nameList[1] = new List<string>();
            nameList[2] = new List<string>();

            inventionList[0] = new List<string>();
            inventionList[1] = new List<string>();
            inventionList[2] = new List<string>();

            fullNameDB();
            inventionDB();
            industryNameDB();
            valuePropositionDB();
            edDistributionDB();
            locationDB();
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Close();
                connection.Open();
                return true;
            }
            catch (OdbcException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                /*switch (ex)
                {
                    MessageBox.Show("");
                }*/
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        public void fullNameDB()
        {
            if (this.OpenConnection() == false)
            {
                OpenConnection();
            }
            string fullName = "";
            string query = "SELECT * FROM nametable";

            //Create a list to store the result
            /*List<string>[] nameList = new List<string>[3];
            nameList[0] = new List<string>();
            nameList[1] = new List<string>();
            nameList[2] = new List<string>();*/

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    nameList[0].Add(dataReader["Title"] + "");
                    nameList[1].Add(dataReader["FirstName"] + "");
                    nameList[2].Add(dataReader["LastName"] + "");
                }

                //random generation of title
                /*Random randTitle = new Random();
                int titleListSize = nameList[0].Count;
                int randomTitleNumber = randTitle.Next(0, titleListSize);
                string title = nameList[0][randomTitleNumber];

                //random generation of first name
                Random randFirstName = new Random();
                int firstNameListSize = nameList[1].Count;
                int randomFirstNameNumber = randFirstName.Next(0, firstNameListSize);
                while(randomFirstNameNumber == randomTitleNumber)//making sure the random numbers are not all the same
                {
                    randomFirstNameNumber = randFirstName.Next(0, firstNameListSize);
                }
                string firstName = nameList[1][randomFirstNameNumber];

                //random generation of last name
                Random randLastName = new Random();
                int lastNameListSize = nameList[2].Count;
                int randomLastNameNumber = randLastName.Next(0, lastNameListSize);
                while(randomLastNameNumber == randomTitleNumber || randomLastNameNumber == randomFirstNameNumber)//making sure the random numbers are not all the same
                {
                    randomLastNameNumber = randLastName.Next(0, lastNameListSize);
                }
                string lastName = nameList[2][randomLastNameNumber]; */             

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed

                //fullName = title + " " + firstName + " " + lastName;
                
            }
            else
            {
                MessageBox.Show("Error in getting name database");
            }
        }

        public void locationDB()
        {
            if (this.OpenConnection() == false)
            {
                OpenConnection();
            }
            string query = "SELECT * FROM locations";
            

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    locationList.Add(dataReader["loc"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
            else
            {
                MessageBox.Show("Error in getting locations database");
            }
        }

        public string locationGenerator()
        {
            Random randLoc = new Random();
            int locListSize = locationList.Count;
            int randomLocNumber = randLoc.Next(0, locListSize);
            string location = locationList[randomLocNumber];

            return location;
        }

        public string fullNameGenerator()
        {
            Random randTitle = new Random();
            int titleListSize = nameList[0].Count;
            int randomTitleNumber = randTitle.Next(0, titleListSize);
            string title = nameList[0][randomTitleNumber];

            //random generation of first name
            Random randFirstName = new Random();
            int firstNameListSize = nameList[1].Count;
            int randomFirstNameNumber = randFirstName.Next(0, firstNameListSize);
            while (randomFirstNameNumber == randomTitleNumber)//making sure the random numbers are not all the same
            {
                randomFirstNameNumber = randFirstName.Next(0, firstNameListSize);
            }
            string firstName = nameList[1][randomFirstNameNumber];

            //random generation of last name
            Random randLastName = new Random();
            int lastNameListSize = nameList[2].Count;
            int randomLastNameNumber = randLastName.Next(0, lastNameListSize);
            while (randomLastNameNumber == randomTitleNumber || randomLastNameNumber == randomFirstNameNumber)//making sure the random numbers are not all the same
            {
                randomLastNameNumber = randLastName.Next(0, lastNameListSize);
            }
            string lastName = nameList[2][randomLastNameNumber];

            string fullname = title + " " + firstName + " " + lastName;
            return fullname;
        }

        public void inventionDB()
        {
            if (this.OpenConnection() == false)
            {
                OpenConnection();
            }
            string invention = "";
            string query = "SELECT * FROM inventions";

            //Create a list to store the result
            /*List<string>[] inventionList = new List<string>[3];
            inventionList[0] = new List<string>();
            inventionList[1] = new List<string>();
            inventionList[2] = new List<string>();*/

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    inventionList[0].Add(dataReader["Adjective"] + "");
                    inventionList[1].Add(dataReader["Descriptive"] + "");
                    inventionList[2].Add(dataReader["Item"] + "");
                }

                //random generation of adjective
                /*Random randAdjective = new Random();
                int adjectiveListSize = inventionList[0].Count;
                int randomAdjectiveNumber = randAdjective.Next(0, adjectiveListSize);
                string adjective = inventionList[0][randomAdjectiveNumber];

                //random generation of descriptive
                Random randDescriptive = new Random();
                int descriptiveListSize = inventionList[1].Count;
                int randomDescriptiveNumber = randDescriptive.Next(0, descriptiveListSize);
                while (randomDescriptiveNumber == randomAdjectiveNumber)//making sure the random numbers are not all the same
                {
                    randomDescriptiveNumber = randDescriptive.Next(0, descriptiveListSize);
                }
                string descriptive = inventionList[1][randomDescriptiveNumber];

                //random generation of item
                Random randItem = new Random();
                int itemListSize = inventionList[2].Count;
                int randomItemNumber = randItem.Next(0, itemListSize);
                while (randomItemNumber == randomAdjectiveNumber || randomItemNumber == randomDescriptiveNumber)//making sure the random numbers are not all the same
                {
                    randomItemNumber = randItem.Next(0, itemListSize);
                }
                string itemName = inventionList[2][randomItemNumber];*/

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return string to be displayed

                /*invention = adjective + " " + descriptive + " " + itemName;
                return invention;*/
            }
            else
            {
                MessageBox.Show("ERROR IN GETTING INVENTION");
            }
        }

        public string inventionGenerator()
        {
            Random randAdjective = new Random();
            int adjectiveListSize = inventionList[0].Count;
            int randomAdjectiveNumber = randAdjective.Next(0, adjectiveListSize);
            string adjective = inventionList[0][randomAdjectiveNumber];

            //random generation of descriptive
            Random randDescriptive = new Random();
            int descriptiveListSize = inventionList[1].Count;
            int randomDescriptiveNumber = randDescriptive.Next(0, descriptiveListSize);
            while (randomDescriptiveNumber == randomAdjectiveNumber)//making sure the random numbers are not all the same
            {
                randomDescriptiveNumber = randDescriptive.Next(0, descriptiveListSize);
            }
            string descriptive = inventionList[1][randomDescriptiveNumber];

            //random generation of item
            Random randItem = new Random();
            int itemListSize = inventionList[2].Count;
            int randomItemNumber = randItem.Next(0, itemListSize);
            while (randomItemNumber == randomAdjectiveNumber || randomItemNumber == randomDescriptiveNumber)//making sure the random numbers are not all the same
            {
                randomItemNumber = randItem.Next(0, itemListSize);
            }
            string itemName = inventionList[2][randomItemNumber];

            //return string to be displayed

            string invention = adjective + " " + descriptive + " " + itemName;
            return invention;
        }



        public void industryNameDB()
        {
            if (this.OpenConnection() == false)
            {
                OpenConnection();
            }
            string industryName = "";
            string query = "SELECT * FROM industryname";

            //Create a list to store the result
            //List<string> industryNameList = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    industryNameList.Add(dataReader["industryname"] + "");
                }

                /*Random randIndustryName = new Random();
                int industryNameListSize = industryNameList.Count;
                int randomIndustryNameNumber = randIndustryName.Next(0, industryNameListSize);
                industryName = industryNameList[randomIndustryNameNumber];

                return industryName;*/
            }
            else
            {
                MessageBox.Show("Error in industry name DB");//return "ERROR IN GETTING INDUSTRY NAME";
            }
        }

        public string industryNameGenerator()
        {
            Random randIndustryName = new Random();
            int industryNameListSize = industryNameList.Count;
            int randomIndustryNameNumber = randIndustryName.Next(0, industryNameListSize);
            string industryName = industryNameList[randomIndustryNameNumber];

            return industryName;
        }


        public void valuePropositionDB()
        {
            if (this.OpenConnection() == false)
            {
                OpenConnection();
            }
            
            string query = "SELECT * FROM valuepropositions";

            //Create a list to store the result
            //List<ValuePropositions> valuePropositionList = new List<ValuePropositions>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    string explanation = dataReader["Explanation"] + "";
                    double valuePropMath = double.Parse(dataReader["math"] + "");
                    ValuePropositions vp = new ValuePropositions(explanation, valuePropMath);
                    valuePropositionList.Add(vp);
                }

                //put randomization into here instead of form1



                //return valuePropositionList;
            }
            else
            {
                MessageBox.Show("Error in value proposition DB");//return null;
            }
        }

        public ValuePropositions valuePropositionsGenerator()
        {
            Random randValueProp = new Random();
            int valuePropListSize = valuePropositionList.Count;
            int randomValuePropNumber = randValueProp.Next(0, valuePropListSize);
            ValuePropositions valueProp = valuePropositionList[randomValuePropNumber];
            return valueProp;
        }



        public void edDistributionDB()
        {
            if (this.OpenConnection() == false)
            {
                OpenConnection();
            }

            string query = "SELECT * FROM EDDistribution";

            //Create a list to store the result
            //List<EDdistribution> EDDistributionList = new List<EDdistribution>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    string variable = dataReader["variable"] + "";
                    int expectedLowerLimit = int.Parse(dataReader["expectedlowerlimit"] + "");
                    int expectedUpperLimit = int.Parse(dataReader["expectedupperlimit"] + "");
                    int pessimisticLowerLimit = int.Parse(dataReader["pessimisticlowerlimit"] + "");
                    int pessimisticUpperLimit = int.Parse(dataReader["pessimisticupperlimit"] + "");
                    int optimisticLowerLimit = int.Parse(dataReader["optimisticlowerlimit"] + "");
                    int optimisticUpperLimit = int.Parse(dataReader["optimisticupperlimit"] + "");
                    
                    /*Random expectedRand = new Random();
                    int expectedVal = expectedRand.Next(expectedLowerLimit, expectedUpperLimit);
                    int pessimisticVal = expectedRand.Next(pessimisticLowerLimit, pessimisticUpperLimit);
                    int optimisticVal = expectedRand.Next(optimisticLowerLimit, optimisticUpperLimit);*/

                    EDdistribution edDist = new EDdistribution(variable, expectedLowerLimit, expectedUpperLimit, pessimisticLowerLimit, pessimisticUpperLimit, optimisticLowerLimit, optimisticUpperLimit);
                    //EDdistribution edDist = new EDdistribution(variable, expectedVal, pessimisticVal, optimisticVal);
                    EDDistributionList.Add(edDist);
                }

                //return EDDistributionList;
            }
            else
            {
                MessageBox.Show("Error in ED Distribution DB");//return null;
            }
        }

        public EDdistribution edDistributionGenerator()
        {
            Random randedDist = new Random();
            int EdDistListSize = EDDistributionList.Count;
            int randomEDNumber = randedDist.Next(0, EdDistListSize);
            //EDdistribution EDDist = EDDistributionList[randomEDNumber];

            EDdistribution ed = EDDistributionList[0];
            string edVar = ed.getVariable();
            int expected = randedDist.Next(ed.getExpectedLowerLimit(), ed.getExpectedUpperLimit());
            int pessimistic = randedDist.Next(ed.getPessimisticLowerLimit(), ed.getPessimisticUpperLimit());
            int optimistic = randedDist.Next(ed.getOptimisitcLowerLimit(), ed.getOptimisticUpperLimit());



            EDdistribution edDist = new EDdistribution(edVar, expected, pessimistic, optimistic);

            return edDist;
        }


        public void writeNamesToDatabase(string name, string className, int id)
        {
            string connectionString = @"Data Source = (LocalDb)\entrepreneur; Initial Catalog = game; Integrated Security = True";
            connection = new SqlConnection(connectionString);
            if (this.OpenConnection() == true)
            {
                string query = "INSERT INTO studentnames (name, class, id) VALUES (@name, @class, @id);";
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@class", className);
                cmd.Parameters.AddWithValue("@id", id);

                //Create a data reader and Execute the command
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            this.CloseConnection();
        }

        public void writeOpportunitiesToDatabase(int id, List<Opportunity> pastOpportunities)
        {
            string connectionString = @"Data Source = (LocalDb)\entrepreneur; Initial Catalog = game; Integrated Security = True";
            connection = new SqlConnection(connectionString);
            string query = "INSERT INTO student_opportunity (student_ID, opportunity, accept, explanation) VALUES ";
            for(int x = 0; x < pastOpportunities.Count-1; x++)
            {
                query += "(" + id + ", '" + pastOpportunities[x].getStory() + "', ";
                if(pastOpportunities[x].getAcceptBool())
                {
                    query += "'yes', ";
                }
                else
                {
                    query += "'no', '";
                }
                query += pastOpportunities[x].getPlayerExplanation() + "'), ";
            }
            query = query.Remove(query.Length - 2);

            if (this.OpenConnection() == true)
            {
                
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);

                /*cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@class", className);
                cmd.Parameters.AddWithValue("@id", id);
                */
                //Create a data reader and Execute the command
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            this.CloseConnection();
        }
    }
}
