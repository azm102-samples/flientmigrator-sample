using FluentMigrator;

namespace Database.Migrations
{
    [Migration(20200510_02)]
    public class Migration_20200510_02_AddDepartmentTable : Migration
    {
        public override void Up()
        {
            Create.Table("Departments")
                .WithColumn("department_id").AsInt64().PrimaryKey()
                .WithColumn("name").AsFixedLengthString(256);

            Create.Column("department_id")
                .OnTable("Users")
                .AsInt64()
                .Nullable();

            Create.ForeignKey()
                .FromTable("Users").ForeignColumn("department_id")
                .ToTable("Departments").PrimaryColumn("department_id");
        }

        public override void Down()
        {
            Delete.ForeignKey().FromTable("Users").ForeignColumn("department_id");
            Delete.Column("department_id").FromTable("Users");
            Delete.Table("Departments");
        }
    }
}