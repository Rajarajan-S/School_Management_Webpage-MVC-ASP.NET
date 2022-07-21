namespace MVC_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetailsClasses", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.DetailsClasses", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DetailsClasses", "Name", c => c.String());
            DropColumn("dbo.DetailsClasses", "Email");
        }
    }
}
