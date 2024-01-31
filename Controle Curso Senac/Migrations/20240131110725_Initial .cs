﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Curso_Senac.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Inicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fim = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Dias = table.Column<string>(type: "TEXT", nullable: false),
                    Meta = table.Column<string>(type: "TEXT", nullable: true),
                    Realizado = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<string>(type: "TEXT", nullable: true),
                    Horario = table.Column<string>(type: "TEXT", nullable: true),
                    Turma = table.Column<string>(type: "TEXT", nullable: true),
                    Sala = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendas");
        }
    }
}
