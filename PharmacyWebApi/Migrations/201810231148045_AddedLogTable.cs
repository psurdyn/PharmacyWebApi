namespace PharmacyWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLogTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Log = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyLogs");
        }
    }
}
