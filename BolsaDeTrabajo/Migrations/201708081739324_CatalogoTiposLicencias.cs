namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogoTiposLicencias : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sist.TiposLicencias VALUES(1,'A','Automovilista / Pasaje y exclusivo de Turismo'), " +
                "(2,'B','Chofer / Carga en sus diferentes modalidades, excepto los materiales y residuos peligrosos.'), " +
                "(3,'C','Carga de dos o tres ejes (Torton o Rabón).'), " +
                "(4,'D','Chofer-Guía de turista.'), " +
                "(5,'E','Carga de materiales y residuos peligrosos.'), " +
                "(6,'F','De y hacia los puertos marítimos y aeropuertos federales.')");
        }
        
        public override void Down()
        {
        }
    }
}
