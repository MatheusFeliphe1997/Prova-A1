using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class NomeAtts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 1, 12, 1, 0, 142, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "6d091456-5a2f-4b5a-98fc-f1a3b50a627d",
                column: "CriadoEm",
                value: new DateTime(2024, 6, 30, 12, 1, 0, 142, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd",
                column: "CriadoEm",
                value: new DateTime(2024, 6, 29, 12, 1, 0, 142, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 1, 12, 1, 0, 142, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 5, 12, 1, 0, 142, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 12, 12, 1, 0, 142, DateTimeKind.Local).AddTicks(640));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 1, 11, 33, 28, 164, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "6d091456-5a2f-4b5a-98fc-f1a3b50a627d",
                column: "CriadoEm",
                value: new DateTime(2024, 6, 30, 11, 33, 28, 164, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd",
                column: "CriadoEm",
                value: new DateTime(2024, 6, 29, 11, 33, 28, 164, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 1, 11, 33, 28, 164, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 5, 11, 33, 28, 164, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 12, 11, 33, 28, 164, DateTimeKind.Local).AddTicks(6640));
        }
    }
}
