namespace BOP3_Task_1_DB_and_File_Server_App.Database
{
    public class Customer : Address
    {
        public int customerId;
        public string customerName;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public int active = 1;
    }
}
