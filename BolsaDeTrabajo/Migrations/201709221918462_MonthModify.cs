namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MonthModify : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("Sist.Months");
            AlterColumn("Sist.Months", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("Sist.Months", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("Sist.Months");
            AlterColumn("Sist.Months", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("Sist.Months", "Id");
        }
    }
}
