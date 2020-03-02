using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class Refactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Workers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Watchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 200, nullable: false),
                    LastName = table.Column<string>(maxLength: 200, nullable: false),
                    UserName = table.Column<string>(maxLength: 200, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    PriorityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.PriorityID);
                    table.ForeignKey(
                        name: "FK_Priorities_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamWatcher",
                columns: table => new
                {
                    TeamID = table.Column<int>(nullable: false),
                    WatcherID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamWatcher", x => new { x.TeamID, x.WatcherID });
                    table.ForeignKey(
                        name: "FK_TeamWatcher_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamWatcher_Watchers_WatcherID",
                        column: x => x.WatcherID,
                        principalTable: "Watchers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Difficulty = table.Column<string>(maxLength: 4000, nullable: true),
                    StartTime = table.Column<DateTimeOffset>(nullable: true),
                    EndTime = table.Column<DateTimeOffset>(nullable: true),
                    PriorityId = table.Column<int>(nullable: true),
                    TeamId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignments_Priorities_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priorities",
                        principalColumn: "PriorityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignments_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentTag",
                columns: table => new
                {
                    AssignmentID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentTag", x => new { x.AssignmentID, x.TagID });
                    table.ForeignKey(
                        name: "FK_AssignmentTag_Assignments_AssignmentID",
                        column: x => x.AssignmentID,
                        principalTable: "Assignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentTag_Tags_TagID",
                        column: x => x.TagID,
                        principalTable: "Tags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentWatcher",
                columns: table => new
                {
                    AssignmentID = table.Column<int>(nullable: false),
                    WatcherID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentWatcher", x => new { x.AssignmentID, x.WatcherID });
                    table.ForeignKey(
                        name: "FK_AssignmentWatcher_Assignments_AssignmentID",
                        column: x => x.AssignmentID,
                        principalTable: "Assignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentWatcher_Watchers_WatcherID",
                        column: x => x.WatcherID,
                        principalTable: "Watchers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentWorker",
                columns: table => new
                {
                    AssignmentID = table.Column<int>(nullable: false),
                    WorkerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentWorker", x => new { x.AssignmentID, x.WorkerID });
                    table.ForeignKey(
                        name: "FK_CurrentWorker_Assignments_AssignmentID",
                        column: x => x.AssignmentID,
                        principalTable: "Assignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentWorker_Workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workers_TeamId",
                table: "Workers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_PriorityId",
                table: "Assignments",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_TeamId",
                table: "Assignments",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentTag_TagID",
                table: "AssignmentTag",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentWatcher_WatcherID",
                table: "AssignmentWatcher",
                column: "WatcherID");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentWorker_WorkerID",
                table: "CurrentWorker",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_Priorities_TeamID",
                table: "Priorities",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamWatcher_WatcherID",
                table: "TeamWatcher",
                column: "WatcherID");

            migrationBuilder.CreateIndex(
                name: "IX_Watchers_UserName",
                table: "Watchers",
                column: "UserName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Teams_TeamId",
                table: "Workers",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Teams_TeamId",
                table: "Workers");

            migrationBuilder.DropTable(
                name: "AssignmentTag");

            migrationBuilder.DropTable(
                name: "AssignmentWatcher");

            migrationBuilder.DropTable(
                name: "CurrentWorker");

            migrationBuilder.DropTable(
                name: "TeamWatcher");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Watchers");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Workers_TeamId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Workers");
        }
    }
}
