using Microsoft.EntityFrameworkCore.Migrations;

namespace LanchesMaC.Migrations
{
    public partial class PopularTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome, Descricao) VALUES('Normal', 'Lanche feito com ingredientes normais')");
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome, Descricao) VALUES('Natural ', 'Lanche feito com ingredientes integrais')");

            migrationBuilder.Sql("INSERT INTO Lanches (DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,Nome,CategoriaId) VALUES('Lanche com pão presunto , queijo e salada','Lanche delicioso para seu almoco,natural e economico', 12.50,'http://www.macoratti.net/Imagens/Lanches/lanchenatural.jpg','http://www.macoratti.net/Imagens/Lanches/lanchenatural.jpg',1,0,'Lanche Natural',(SELECT CategoriaId FROM Categorias WHERE CategoriaNome = 'Natural'))");
            migrationBuilder.Sql("INSERT INTO Lanches (DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,Nome,CategoriaId) VALUES('Hamburguer de carne e muito queijo','Lanche delicioso com muito queijo para seu cafe da tarde, serve até 2 pessoas, economico', 15.50,'http://www.macoratti.net/Imagens/Lanches/cheeseburger1.jp','http://www.macoratti.net/Imagens/Lanches/cheeseburger1.jpg',0,1,'Hamburguer Chesse',(SELECT CategoriaId FROM Categorias WHERE CategoriaNome = 'Natural'))");
            migrationBuilder.Sql("INSERT INTO Lanches (DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,Nome,CategoriaId) VALUES('Hamburguer de carne , queijo e salada','Lanche delicioso para seu almoco, muita carne,MUITO QUEIJO E SALADA,natural e economico', 15.50,'http://www.macoratti.net/Imagens/Lanches/cheesesalada.jpg','http://www.macoratti.net/Imagens/Lanches/cheesesalada.jpg',1,1,'Hamburguer Chesse Salada',(SELECT CategoriaId FROM Categorias WHERE CategoriaNome = 'Normal'))");
            migrationBuilder.Sql("INSERT INTO Lanches (DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,Nome,CategoriaId) VALUES('Lanche com pão presunto e queijo','Lanche delicioso para seu cafe da tarde, economico', 8.50,'http://www.macoratti.net/Imagens/Lanches/mistoquente4.jpg','http://www.macoratti.net/Imagens/Lanches/mistoquente4.jpg',1,1,'Lanche de Presunto e Queijo',(SELECT CategoriaId FROM Categorias WHERE CategoriaNome = 'Natural'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From Categorias");
            migrationBuilder.Sql("Delete From Lanches");
        }
    }
}
