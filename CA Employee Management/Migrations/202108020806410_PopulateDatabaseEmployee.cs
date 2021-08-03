namespace CA_Employee_Management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDatabaseEmployee : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Employees (Name, Designation, Salary, PhoneNumber) VALUES('Apoorv Mengudale', 'Associate Software Engineer', '5000', '9022044731'); ");
        }
        
        public override void Down()
        {
        }
    }
}
