namespace ExamProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Movies", "Picture", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Picture", c => c.String());
            AlterColumn("dbo.Movies", "Genre", c => c.String());
            AlterColumn("dbo.Movies", "Title", c => c.String());
        }
    }
}
