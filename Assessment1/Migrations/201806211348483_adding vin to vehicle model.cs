namespace Assessment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingvintovehiclemodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "Vin", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "Vin");
        }
    }
}
