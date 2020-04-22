using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QnSMusicStore.Logic.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Account");

            migrationBuilder.EnsureSchema(
                name: "App");

            migrationBuilder.CreateTable(
                name: "Identity",
                schema: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: false),
                    Guid = table.Column<string>(maxLength: 36, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Email = table.Column<string>(maxLength: 128, nullable: false),
                    EnableJwtAuth = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Designation = table.Column<string>(maxLength: 64, nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artist",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActionLog",
                schema: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    IdentityId = table.Column<int>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true),
                    Info = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionLog_Identity_IdentityId",
                        column: x => x.IdentityId,
                        principalSchema: "Account",
                        principalTable: "Identity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoginSession",
                schema: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    IdentityId = table.Column<int>(nullable: false),
                    SessionToken = table.Column<string>(maxLength: 256, nullable: false),
                    LoginTime = table.Column<DateTime>(nullable: false),
                    LastAccess = table.Column<DateTime>(nullable: false),
                    LogoutTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginSession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginSession_Identity_IdentityId",
                        column: x => x.IdentityId,
                        principalSchema: "Account",
                        principalTable: "Identity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IdentityXRole",
                schema: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    IdentityId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityXRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityXRole_Identity_IdentityId",
                        column: x => x.IdentityId,
                        principalSchema: "Account",
                        principalTable: "Identity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IdentityXRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Account",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Album",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    ArtistId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Album_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalSchema: "App",
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Track",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    AlbumId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 1024, nullable: false),
                    Composer = table.Column<string>(maxLength: 512, nullable: true),
                    Milliseconds = table.Column<long>(nullable: false),
                    Bytes = table.Column<long>(nullable: false),
                    UnitPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Track_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalSchema: "App",
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Track_Genre_GenreId",
                        column: x => x.GenreId,
                        principalSchema: "App",
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionLog_IdentityId",
                schema: "Account",
                table: "ActionLog",
                column: "IdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_Identity_Email",
                schema: "Account",
                table: "Identity",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IdentityXRole_IdentityId",
                schema: "Account",
                table: "IdentityXRole",
                column: "IdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityXRole_RoleId",
                schema: "Account",
                table: "IdentityXRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginSession_IdentityId",
                schema: "Account",
                table: "LoginSession",
                column: "IdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Designation",
                schema: "Account",
                table: "Role",
                column: "Designation",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Album_ArtistId",
                schema: "App",
                table: "Album",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Album_Title",
                schema: "App",
                table: "Album",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artist_Name",
                schema: "App",
                table: "Artist",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genre_Name",
                schema: "App",
                table: "Genre",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Track_AlbumId",
                schema: "App",
                table: "Track",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Track_GenreId",
                schema: "App",
                table: "Track",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Track_Title",
                schema: "App",
                table: "Track",
                column: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionLog",
                schema: "Account");

            migrationBuilder.DropTable(
                name: "IdentityXRole",
                schema: "Account");

            migrationBuilder.DropTable(
                name: "LoginSession",
                schema: "Account");

            migrationBuilder.DropTable(
                name: "Track",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Account");

            migrationBuilder.DropTable(
                name: "Identity",
                schema: "Account");

            migrationBuilder.DropTable(
                name: "Album",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Genre",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Artist",
                schema: "App");
        }
    }
}
