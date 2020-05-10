using System.Collections.Generic;
using FluentMigrator;

namespace Database.Migrations
{
    [Migration(20200510_03)]
    public class Migration_20200510_03_Seed : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Departments")
                .Row(new {department_id = 1, name = "Department 1"})
                .Row(new {department_id = 2, name = "Department 2"})
                .Row(new {department_id = 3, name = "Department 3"});

            Insert.IntoTable("Users")
                .Row(new {user_id = 1, name = "Name 1", surname = "Surname 1", department_id = 1})
                .Row(new {user_id = 2, name = "Name 2", surname = "Surname 2", department_id = 1})
                .Row(new {user_id = 3, name = "Name 3", surname = "Surname 3", department_id = 2});
        }

        public override void Down()
        {
            
        }
    }
}