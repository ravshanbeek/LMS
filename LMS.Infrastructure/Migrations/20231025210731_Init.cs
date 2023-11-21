using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 26, 2, 7, 31, 660, DateTimeKind.Local).AddTicks(3170)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 26, 2, 7, 31, 662, DateTimeKind.Local).AddTicks(1094)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressTemporary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashedPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 26, 2, 7, 31, 662, DateTimeKind.Local).AddTicks(7018)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressTemporary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashedPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 26, 2, 7, 31, 661, DateTimeKind.Local).AddTicks(8912)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 26, 2, 7, 31, 659, DateTimeKind.Local).AddTicks(2033)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseGroup",
                columns: table => new
                {
                    CoursesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseGroup", x => new { x.CoursesId, x.GroupsId });
                    table.ForeignKey(
                        name: "FK_CourseGroup_Course_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseGroup_Group_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deadline",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaxGrade = table.Column<float>(type: "real", nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 26, 2, 7, 31, 659, DateTimeKind.Local).AddTicks(7873)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deadline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deadline_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lecture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 26, 2, 7, 31, 660, DateTimeKind.Local).AddTicks(6709)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lesson_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskGrade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GradeValue = table.Column<float>(type: "real", nullable: false, defaultValue: 0f),
                    DedlineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsUploaded = table.Column<bool>(type: "bit", nullable: false),
                    IsRated = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 26, 2, 7, 31, 662, DateTimeKind.Local).AddTicks(4160)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskGrade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskGrade_Deadline_DedlineId",
                        column: x => x.DedlineId,
                        principalTable: "Deadline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskGrade_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NB",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 26, 2, 7, 31, 661, DateTimeKind.Local).AddTicks(6758)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NB_Lesson_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NB_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_SubjectId",
                table: "Course",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_TeacherId",
                table: "Course",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseGroup_GroupsId",
                table: "CourseGroup",
                column: "GroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_Deadline_CourseId",
                table: "Deadline",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_CourseId",
                table: "Lesson",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_NB_LessonId",
                table: "NB",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_NB_StudentId",
                table: "NB",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GroupId",
                table: "Student",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskGrade_DedlineId",
                table: "TaskGrade",
                column: "DedlineId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskGrade_StudentId",
                table: "TaskGrade",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseGroup");

            migrationBuilder.DropTable(
                name: "NB");

            migrationBuilder.DropTable(
                name: "TaskGrade");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Deadline");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
