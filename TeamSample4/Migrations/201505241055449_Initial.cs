namespace TeamSample4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "PrioritySelect", c => c.Int(nullable: false));
            DropColumn("dbo.Tickets", "Priority");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Priority", c => c.String());
            DropColumn("dbo.Tickets", "PrioritySelect");
        }
    }
}
