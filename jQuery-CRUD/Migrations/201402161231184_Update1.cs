namespace jQuery_CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "ContactNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "ContactNo", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Users", "Address", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, unicode: false));
        }
    }
}
