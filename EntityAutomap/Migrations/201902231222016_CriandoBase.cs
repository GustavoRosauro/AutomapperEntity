namespace EntityAutomap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroPedido = c.String(),
                        Clinte = c.String(),
                        IdProduto = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtoes", t => t.IdProduto)
                .Index(t => t.IdProduto);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidoes", "IdProduto", "dbo.Produtoes");
            DropIndex("dbo.Pedidoes", new[] { "IdProduto" });
            DropTable("dbo.Produtoes");
            DropTable("dbo.Pedidoes");
        }
    }
}
