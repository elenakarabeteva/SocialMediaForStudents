using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMediaForStudents.Data.Migrations
{
    public partial class AddDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_Subject_SubjectId",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Subject_SubjectId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Town_TownId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroup_Group_GroupId",
                table: "StudentGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroup_Student_StudentId",
                table: "StudentGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Student_StudentId",
                table: "StudentSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Subject_SubjectId",
                table: "StudentSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeacher_Student_StudentId",
                table: "StudentTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeacher_Teacher_TeacherId",
                table: "StudentTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTest_Student_StudentId",
                table: "StudentTest");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTest_Test_TestId",
                table: "StudentTest");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Subject_SubjectId",
                table: "Teacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Town_TownId",
                table: "Teacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Test_Subject_SubjectId",
                table: "Test");

            migrationBuilder.DropForeignKey(
                name: "FK_Test_Teacher_TeacherId",
                table: "Test");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Town",
                table: "Town");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Test",
                table: "Test");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentTest",
                table: "StudentTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentTeacher",
                table: "StudentTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSubject",
                table: "StudentSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentGroup",
                table: "StudentGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "Town",
                newName: "Towns");

            migrationBuilder.RenameTable(
                name: "Test",
                newName: "Tests");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "Teachers");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "StudentTest",
                newName: "StudentTests");

            migrationBuilder.RenameTable(
                name: "StudentTeacher",
                newName: "StudentTeachers");

            migrationBuilder.RenameTable(
                name: "StudentSubject",
                newName: "StudentSubjects");

            migrationBuilder.RenameTable(
                name: "StudentGroup",
                newName: "StudentGroups");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "Groups");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Town_IsDeleted",
                table: "Towns",
                newName: "IX_Towns_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Test_TeacherId",
                table: "Tests",
                newName: "IX_Tests_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Test_SubjectId",
                table: "Tests",
                newName: "IX_Tests_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Test_IsDeleted",
                table: "Tests",
                newName: "IX_Tests_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_TownId",
                table: "Teachers",
                newName: "IX_Teachers_TownId");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_SubjectId",
                table: "Teachers",
                newName: "IX_Teachers_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_IsDeleted",
                table: "Teachers",
                newName: "IX_Teachers_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_IsDeleted",
                table: "Subjects",
                newName: "IX_Subjects_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTest_TestId",
                table: "StudentTests",
                newName: "IX_StudentTests_TestId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTest_IsDeleted",
                table: "StudentTests",
                newName: "IX_StudentTests_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTeacher_TeacherId",
                table: "StudentTeachers",
                newName: "IX_StudentTeachers_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTeacher_IsDeleted",
                table: "StudentTeachers",
                newName: "IX_StudentTeachers_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSubject_SubjectId",
                table: "StudentSubjects",
                newName: "IX_StudentSubjects_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSubject_IsDeleted",
                table: "StudentSubjects",
                newName: "IX_StudentSubjects_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGroup_IsDeleted",
                table: "StudentGroups",
                newName: "IX_StudentGroups_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGroup_GroupId",
                table: "StudentGroups",
                newName: "IX_StudentGroups_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_TownId",
                table: "Students",
                newName: "IX_Students_TownId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_IsDeleted",
                table: "Students",
                newName: "IX_Students_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Post_SubjectId",
                table: "Posts",
                newName: "IX_Posts_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_IsDeleted",
                table: "Posts",
                newName: "IX_Posts_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Group_SubjectId",
                table: "Groups",
                newName: "IX_Groups_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Group_IsDeleted",
                table: "Groups",
                newName: "IX_Groups_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PostId",
                table: "Comments",
                newName: "IX_Comments_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_IsDeleted",
                table: "Comments",
                newName: "IX_Comments_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Towns",
                table: "Towns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tests",
                table: "Tests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentTests",
                table: "StudentTests",
                columns: new[] { "StudentId", "TestId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentTeachers",
                table: "StudentTeachers",
                columns: new[] { "StudentId", "TeacherId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSubjects",
                table: "StudentSubjects",
                columns: new[] { "StudentId", "SubjectId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentGroups",
                table: "StudentGroups",
                columns: new[] { "StudentId", "GroupId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Subjects_SubjectId",
                table: "Groups",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Subjects_SubjectId",
                table: "Posts",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroups_Groups_GroupId",
                table: "StudentGroups",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroups_Students_StudentId",
                table: "StudentGroups",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Towns_TownId",
                table: "Students",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Students_StudentId",
                table: "StudentSubjects",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Subjects_SubjectId",
                table: "StudentSubjects",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeachers_Students_StudentId",
                table: "StudentTeachers",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeachers_Teachers_TeacherId",
                table: "StudentTeachers",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTests_Students_StudentId",
                table: "StudentTests",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTests_Tests_TestId",
                table: "StudentTests",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Subjects_SubjectId",
                table: "Teachers",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Towns_TownId",
                table: "Teachers",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Subjects_SubjectId",
                table: "Tests",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Teachers_TeacherId",
                table: "Tests",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Subjects_SubjectId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Subjects_SubjectId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroups_Groups_GroupId",
                table: "StudentGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroups_Students_StudentId",
                table: "StudentGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Towns_TownId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Students_StudentId",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Subjects_SubjectId",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeachers_Students_StudentId",
                table: "StudentTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeachers_Teachers_TeacherId",
                table: "StudentTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTests_Students_StudentId",
                table: "StudentTests");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTests_Tests_TestId",
                table: "StudentTests");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Subjects_SubjectId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Towns_TownId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Subjects_SubjectId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Teachers_TeacherId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Towns",
                table: "Towns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tests",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentTests",
                table: "StudentTests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentTeachers",
                table: "StudentTeachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSubjects",
                table: "StudentSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentGroups",
                table: "StudentGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Towns",
                newName: "Town");

            migrationBuilder.RenameTable(
                name: "Tests",
                newName: "Test");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "Teacher");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.RenameTable(
                name: "StudentTests",
                newName: "StudentTest");

            migrationBuilder.RenameTable(
                name: "StudentTeachers",
                newName: "StudentTeacher");

            migrationBuilder.RenameTable(
                name: "StudentSubjects",
                newName: "StudentSubject");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "StudentGroups",
                newName: "StudentGroup");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Group");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Towns_IsDeleted",
                table: "Town",
                newName: "IX_Town_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_TeacherId",
                table: "Test",
                newName: "IX_Test_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_SubjectId",
                table: "Test",
                newName: "IX_Test_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_IsDeleted",
                table: "Test",
                newName: "IX_Test_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_TownId",
                table: "Teacher",
                newName: "IX_Teacher_TownId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_SubjectId",
                table: "Teacher",
                newName: "IX_Teacher_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_IsDeleted",
                table: "Teacher",
                newName: "IX_Teacher_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_IsDeleted",
                table: "Subject",
                newName: "IX_Subject_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTests_TestId",
                table: "StudentTest",
                newName: "IX_StudentTest_TestId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTests_IsDeleted",
                table: "StudentTest",
                newName: "IX_StudentTest_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTeachers_TeacherId",
                table: "StudentTeacher",
                newName: "IX_StudentTeacher_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTeachers_IsDeleted",
                table: "StudentTeacher",
                newName: "IX_StudentTeacher_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSubjects_SubjectId",
                table: "StudentSubject",
                newName: "IX_StudentSubject_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSubjects_IsDeleted",
                table: "StudentSubject",
                newName: "IX_StudentSubject_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Students_TownId",
                table: "Student",
                newName: "IX_Student_TownId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_IsDeleted",
                table: "Student",
                newName: "IX_Student_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGroups_IsDeleted",
                table: "StudentGroup",
                newName: "IX_StudentGroup_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGroups_GroupId",
                table: "StudentGroup",
                newName: "IX_StudentGroup_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_SubjectId",
                table: "Post",
                newName: "IX_Post_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_IsDeleted",
                table: "Post",
                newName: "IX_Post_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_SubjectId",
                table: "Group",
                newName: "IX_Group_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_IsDeleted",
                table: "Group",
                newName: "IX_Group_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostId",
                table: "Comment",
                newName: "IX_Comment_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_IsDeleted",
                table: "Comment",
                newName: "IX_Comment_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Town",
                table: "Town",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Test",
                table: "Test",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentTest",
                table: "StudentTest",
                columns: new[] { "StudentId", "TestId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentTeacher",
                table: "StudentTeacher",
                columns: new[] { "StudentId", "TeacherId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSubject",
                table: "StudentSubject",
                columns: new[] { "StudentId", "SubjectId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentGroup",
                table: "StudentGroup",
                columns: new[] { "StudentId", "GroupId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Subject_SubjectId",
                table: "Group",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Subject_SubjectId",
                table: "Post",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Town_TownId",
                table: "Student",
                column: "TownId",
                principalTable: "Town",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroup_Group_GroupId",
                table: "StudentGroup",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroup_Student_StudentId",
                table: "StudentGroup",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Student_StudentId",
                table: "StudentSubject",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Subject_SubjectId",
                table: "StudentSubject",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeacher_Student_StudentId",
                table: "StudentTeacher",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeacher_Teacher_TeacherId",
                table: "StudentTeacher",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTest_Student_StudentId",
                table: "StudentTest",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTest_Test_TestId",
                table: "StudentTest",
                column: "TestId",
                principalTable: "Test",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Subject_SubjectId",
                table: "Teacher",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Town_TownId",
                table: "Teacher",
                column: "TownId",
                principalTable: "Town",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Subject_SubjectId",
                table: "Test",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Teacher_TeacherId",
                table: "Test",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
