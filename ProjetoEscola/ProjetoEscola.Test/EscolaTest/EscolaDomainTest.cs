using ProjetoEscola.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjetoEscola.Test.DominioTeste
{
    public class EscolaDomainTest
    {
        [Fact(DisplayName = "Adicionar Escola com sucesso")]
        [Trait("Categoria","Escola Trait Test")]
        public void Escola_InformarONome_RetornaSucesso()
        {
            //Arrange
            string nomeEscola = "Ciep 001";

            //Act
            var escola = new Escola(nomeEscola);

            //Assert
            Assert.NotNull(escola);
        }

        [Fact(DisplayName = "Escola não informada tem que retornar erro")]
        [Trait("Categoria", "Escola Trait Test")]
        public void Escola_NaoInformarONome_RetornaErro()
        {
            //Arrange
            string nomeEscola = "";

            //Assert
            Assert.Throws<Exception>(() => new Escola(nomeEscola));
        }
    }
}
