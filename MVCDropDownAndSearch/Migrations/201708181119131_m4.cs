namespace MVCDropDownAndSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "department");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "department", c => c.String());
        }
    }
}
