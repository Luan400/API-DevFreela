//using System;
//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace DevFreela.Instructure.Persistence.Migrations
//{
//    /// <inheritdoc />
//    public partial class InitialMigration : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "Skills",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Skills", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "Users",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    Active = table.Column<bool>(type: "bit", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Users", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "Project",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IdClient = table.Column<int>(type: "int", nullable: false),
//                    IdFreelancer = table.Column<int>(type: "int", nullable: false),
//                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
//                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    FinishedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    Status = table.Column<int>(type: "int", nullable: false),
//                    UserId = table.Column<int>(type: "int", nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Project", x => x.Id);
//                    table.ForeignKey(
//                        name: "FK_Project_Users_IdClient",
//                        column: x => x.IdClient,
//                        principalTable: "Users",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Restrict);
//                    table.ForeignKey(
//                        name: "FK_Project_Users_IdFreelancer",
//                        column: x => x.IdFreelancer,
//                        principalTable: "Users",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Restrict);
//                    table.ForeignKey(
//                        name: "FK_Project_Users_UserId",
//                        column: x => x.UserId,
//                        principalTable: "Users",
//                        principalColumn: "Id");
//                });

//            migrationBuilder.CreateTable(
//                name: "UserSkills",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    IdUser = table.Column<int>(type: "int", nullable: false),
//                    IdSkill = table.Column<int>(type: "int", nullable: false),
//                    SkillId = table.Column<int>(type: "int", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_UserSkills", x => x.Id);
//                    table.ForeignKey(
//                        name: "FK_UserSkills_Skills_SkillId",
//                        column: x => x.SkillId,
//                        principalTable: "Skills",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                    table.ForeignKey(
//                        name: "FK_UserSkills_Users_IdSkill",
//                        column: x => x.IdSkill,
//                        principalTable: "Users",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Restrict);
//                });

//            migrationBuilder.CreateTable(
//                name: "ProjectComment",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    IdProject = table.Column<int>(type: "int", nullable: false),
//                    IdUser = table.Column<int>(type: "int", nullable: false),
//                    UserId = table.Column<int>(type: "int", nullable: false),
//                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_ProjectComment", x => x.Id);
//                    table.ForeignKey(
//                        name: "FK_ProjectComment_Project_IdProject",
//                        column: x => x.IdProject,
//                        principalTable: "Project",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                    table.ForeignKey(
//                        name: "FK_ProjectComment_Users_UserId",
//                        column: x => x.UserId,
//                        principalTable: "Users",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.CreateIndex(
//                name: "IX_Project_IdClient",
//                table: "Project",
//                column: "IdClient");

//            migrationBuilder.CreateIndex(
//                name: "IX_Project_IdFreelancer",
//                table: "Project",
//                column: "IdFreelancer");

//            migrationBuilder.CreateIndex(
//                name: "IX_Project_UserId",
//                table: "Project",
//                column: "UserId");

//            migrationBuilder.CreateIndex(
//                name: "IX_ProjectComment_IdProject",
//                table: "ProjectComment",
//                column: "IdProject");

//            migrationBuilder.CreateIndex(
//                name: "IX_ProjectComment_UserId",
//                table: "ProjectComment",
//                column: "UserId");

//            migrationBuilder.CreateIndex(
//                name: "IX_UserSkills_IdSkill",
//                table: "UserSkills",
//                column: "IdSkill");

//            migrationBuilder.CreateIndex(
//                name: "IX_UserSkills_SkillId",
//                table: "UserSkills",
//                column: "SkillId");
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "ProjectComment");

//            migrationBuilder.DropTable(
//                name: "UserSkills");

//            migrationBuilder.DropTable(
//                name: "Project");

//            migrationBuilder.DropTable(
//                name: "Skills");

//            migrationBuilder.DropTable(
//                name: "Users");
//        }
//    }
//}
