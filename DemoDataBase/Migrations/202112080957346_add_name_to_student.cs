namespace DemoDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_name_to_student : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Name", c => c.Int(nullable: false));
        }
    }
}
