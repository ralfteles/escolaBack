using ProjetoEscola.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjetoEscola.Test.DominioTeste
{
    public class EscolaDomainTest
    {
        [Fact(DisplayName = "Adicionar Escola retorna sucesso")]
        [Trait("Categoria","Escola Trait Test")]
        public void Escola_InformarONome_RetornaSucesso()
        {
            //Arrange
            string nomeEscola = "Ciep 001";

            //Act
            var escola = new Escola(nomeEscola);

            //Assert
            Assert.True(escola.Valid);
        }

        [Fact(DisplayName = "Escola não informada tem que retornar invalido")]
        [Trait("Categoria", "Escola Trait Test")]
        public void Escola_NaoInformarONome_RetornaInvalido()
        {
            //Arrange
            string nomeEscola = "";

             //Act
            var escola = new Escola(nomeEscola);

            //Assert
            Assert.True(escola.Invalid);
        }
    }
}
