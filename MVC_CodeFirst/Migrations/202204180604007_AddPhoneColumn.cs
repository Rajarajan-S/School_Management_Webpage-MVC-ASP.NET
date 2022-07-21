namespace MVC_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DetailsClasses", "Phone", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DetailsClasses", "Phone", c => c.Int(nullable: false));
        }
    }
}
