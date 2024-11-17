namespace MvcDiscGolf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Course", c => c.String(maxLength: 60));
            AlterColumn("dbo.Games", "Level", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Games", "Rating", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Rating", c => c.String());
            AlterColumn("dbo.Games", "Level", c => c.String());
            AlterColumn("dbo.Games", "Course", c => c.String());
        }
    }
}
