using FluentMigrator;

namespace Database.Migrations
{
    [Migration(20200510_01)]
    public class Migration_20200510_01_AddUserTable : Migration
    {
        public override void Up()
        {
            Create.Table("Users")
                .WithColumn("user_id").AsInt64().PrimaryKey()
                .WithColumn("name").AsFixedLengthString(256).NotNullable()
                .WithColumn("surname").AsFixedLengthString(256).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Users");
        }
    }
}