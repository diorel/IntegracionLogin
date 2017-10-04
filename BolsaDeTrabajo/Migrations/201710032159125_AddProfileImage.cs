namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProfileImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.Candidatos", "ImgProfileUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Sist.Candidatos", "ImgProfileUrl");
        }
    }
}
