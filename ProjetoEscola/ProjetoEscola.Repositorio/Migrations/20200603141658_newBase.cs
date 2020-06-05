using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoEscola.Repositorio.Migrations
{
    public partial class newBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "escola",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    descricao = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_escola", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "turma",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    nome = table.Column<string>(maxLength: 300, nullable: false),
                    vagas = table.Column<int>(nullable: false),
                    EscolaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_turma_escola_EscolaId",
                        column: x => x.EscolaId,
                        principalTable: "escola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_turma_EscolaId",
                table: "turma",
                column: "EscolaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "turma");

            migrationBuilder.DropTable(
                name: "escola");
        }
    }
}
