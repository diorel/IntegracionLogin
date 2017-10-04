namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfileImageURlDefautlValue : DbMigration
    {
        public override void Up()
        {
           // AlterColumn("Sist.Candidatos", "ImgProfileUrl", c => c.String(nullable: false, defaultValue:""));
        }
        
        public override void Down()
        {
        }
    }
}
