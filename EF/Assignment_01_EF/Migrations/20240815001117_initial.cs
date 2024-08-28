using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_01_EF.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Topics",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Stud_ID",
                table: "Stud_Courses",
                newName: "Stud_Id");

            migrationBuilder.RenameColumn(
                name: "Course_ID",
                table: "Stud_Courses",
                newName: "Course_Id");

            migrationBuilder.RenameColumn(
                name: "Dept_ID",
                table: "Instructors",
                newName: "Dept_Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Instructors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Ins_ID",
                table: "Departments",
                newName: "Ins_Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Departments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Top_ID",
                table: "Courses",
                newName: "Top_Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Courses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Inst_ID",
                table: "Course_Insts",
                newName: "Inst_Id");

            migrationBuilder.RenameColumn(
                name: "Course_ID",
                table: "Course_Insts",
                newName: "Course_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Topics",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Stud_Id",
                table: "Stud_Courses",
                newName: "Stud_ID");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "Stud_Courses",
                newName: "Course_ID");

            migrationBuilder.RenameColumn(
                name: "Dept_Id",
                table: "Instructors",
                newName: "Dept_ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Instructors",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Ins_Id",
                table: "Departments",
                newName: "Ins_ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Departments",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Top_Id",
                table: "Courses",
                newName: "Top_ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Courses",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Inst_Id",
                table: "Course_Insts",
                newName: "Inst_ID");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "Course_Insts",
                newName: "Course_ID");
        }
    }
}
