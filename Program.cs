namespace Design_Patterns___Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        
            ClassA classA = new ClassA(); 
            ClassB classB = new ClassB();

            classA.Database = DatabaseSingleton.GetInstance();
            classB.Database = DatabaseSingleton.GetInstance(); 


            classA.Database.Query("SELECT * FROM Persons");
            classB.Database.Query("SELECT * FROM SavingAccounts");  


        }
    }
}
