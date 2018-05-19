namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeName2nd : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Pay as You Go' WHERE Id = 0");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Monthly' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Quaterly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Annually' WHERE Id = 3");
        }

        public override void Down()
        {
        }
    }
}
