using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiKanbanGestao.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoNomePropriedadesTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColunaXAtividade_Atividade_AtividadeId",
                schema: "public",
                table: "ColunaXAtividade");

            migrationBuilder.DropForeignKey(
                name: "FK_ColunaXAtividade_Coluna_ColunaId",
                schema: "public",
                table: "ColunaXAtividade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColunaXAtividade",
                schema: "public",
                table: "ColunaXAtividade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coluna",
                schema: "public",
                table: "Coluna");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Atividade",
                schema: "public",
                table: "Atividade");

            migrationBuilder.RenameTable(
                name: "ColunaXAtividade",
                schema: "public",
                newName: "ColunasXAtividades",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Coluna",
                schema: "public",
                newName: "Colunas",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Atividade",
                schema: "public",
                newName: "Atividades",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_ColunaXAtividade_ColunaId",
                schema: "public",
                table: "ColunasXAtividades",
                newName: "IX_ColunasXAtividades_ColunaId");

            migrationBuilder.RenameIndex(
                name: "IX_ColunaXAtividade_AtividadeId",
                schema: "public",
                table: "ColunasXAtividades",
                newName: "IX_ColunasXAtividades_AtividadeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColunasXAtividades",
                schema: "public",
                table: "ColunasXAtividades",
                column: "IdColunaXAtividade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colunas",
                schema: "public",
                table: "Colunas",
                column: "IdColuna");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atividades",
                schema: "public",
                table: "Atividades",
                column: "IdAtividade");

            migrationBuilder.AddForeignKey(
                name: "FK_ColunasXAtividades_Atividades_AtividadeId",
                schema: "public",
                table: "ColunasXAtividades",
                column: "AtividadeId",
                principalSchema: "public",
                principalTable: "Atividades",
                principalColumn: "IdAtividade",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColunasXAtividades_Colunas_ColunaId",
                schema: "public",
                table: "ColunasXAtividades",
                column: "ColunaId",
                principalSchema: "public",
                principalTable: "Colunas",
                principalColumn: "IdColuna",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColunasXAtividades_Atividades_AtividadeId",
                schema: "public",
                table: "ColunasXAtividades");

            migrationBuilder.DropForeignKey(
                name: "FK_ColunasXAtividades_Colunas_ColunaId",
                schema: "public",
                table: "ColunasXAtividades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColunasXAtividades",
                schema: "public",
                table: "ColunasXAtividades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colunas",
                schema: "public",
                table: "Colunas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Atividades",
                schema: "public",
                table: "Atividades");

            migrationBuilder.RenameTable(
                name: "ColunasXAtividades",
                schema: "public",
                newName: "ColunaXAtividade",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Colunas",
                schema: "public",
                newName: "Coluna",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Atividades",
                schema: "public",
                newName: "Atividade",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_ColunasXAtividades_ColunaId",
                schema: "public",
                table: "ColunaXAtividade",
                newName: "IX_ColunaXAtividade_ColunaId");

            migrationBuilder.RenameIndex(
                name: "IX_ColunasXAtividades_AtividadeId",
                schema: "public",
                table: "ColunaXAtividade",
                newName: "IX_ColunaXAtividade_AtividadeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColunaXAtividade",
                schema: "public",
                table: "ColunaXAtividade",
                column: "IdColunaXAtividade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coluna",
                schema: "public",
                table: "Coluna",
                column: "IdColuna");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atividade",
                schema: "public",
                table: "Atividade",
                column: "IdAtividade");

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
    }
}
