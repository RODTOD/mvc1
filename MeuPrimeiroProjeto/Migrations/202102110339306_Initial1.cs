namespace MeuPrimeiroProjeto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Universidade", "Cidade", c => c.String());
            AlterColumn("dbo.Universidade", "UF", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Universidade", "UF", c => c.Int(nullable: false));
            AlterColumn("dbo.Universidade", "Cidade", c => c.Int(nullable: false));
        }
    }
}
