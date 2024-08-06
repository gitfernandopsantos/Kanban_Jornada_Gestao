using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiKanbanGestao.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoColunaXAtividade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ColunaXAtividade_AtividadeId",
                schema: "public",
                table: "ColunaXAtividade",
                column: "AtividadeId");

            migrationBuilder.CreateIndex(
                name: "IX_ColunaXAtividade_ColunaId",
                schema: "public",
                table: "ColunaXAtividade",
                column: "ColunaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ColunaXAtividade_Atividade_AtividadeId",
                schema: "public",
                table: "ColunaXAtividade",
                column: "AtividadeId",
                principalSchema: "public",
                principalTable: "Atividade",
                principalColumn: "IdAtividade",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColunaXAtividade_Coluna_ColunaId",
                schema: "public",
                table: "ColunaXAtividade",
                column: "ColunaId",
                principalSchema: "public",
                principalTable: "Coluna",
                principalColumn: "IdColuna",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColunaXAtividade_Atividade_AtividadeId",
                schema: "public",
                table: "ColunaXAtividade");

            migrationBuilder.DropForeignKey(
                name: "FK_ColunaXAtividade_Coluna_ColunaId",
                schema: "public",
                table: "ColunaXAtividade");

            migrationBuilder.DropIndex(
                name: "IX_ColunaXAtividade_AtividadeId",
                schema: "public",
                table: "ColunaXAtividade");

            migrationBuilder.DropIndex(
                name: "IX_ColunaXAtividade_ColunaId",
                schema: "public",
                table: "ColunaXAtividade");
        }
    }
}
