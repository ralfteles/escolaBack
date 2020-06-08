using Moq;
using ProjetoEscola.Aplicacao.Aplicacao;
using ProjetoEscola.Dominio.Entidade;
using ProjetoEscola.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjetoEscola.Test.TurmaTest
{
    public class EscolaServiceTest
    {
        [Fact(DisplayName = "Adicionar Escola com sucesso")]
        [Trait("Categoria", "Escola Service Test")]
        public void EscolaService_Adicionar_RetornarSucesso()
        {
            //Arrange
            var escolaRepo = new Mock<IEscolaRepository>();
            var escolaApplication = new EscolaApplication(escolaRepo.Object);

            var escola = new Escola("CIEP 2200");

            //Act 
            escolaApplication.Adicionar(escola);

            //Assert
            escolaRepo.Verify(e => e.Adicionar(escola), Times.Once);


        }



        [Fact(DisplayName = "Atualizar Escola com sucesso")]
        [Trait("Categoria", "Escola Service Test")]
        public void EscolaService_Atualizar_RetornarSucesso()
        {
            //Arrange
            var escolaRepo = new Mock<IEscolaRepository>();
            var escolaApplication = new EscolaApplication(escolaRepo.Object);

            var escola = new Escola("CIEP 2200");

            //Act 
            escolaApplication.Atualizar(escola);

            //Assert
            escolaRepo.Verify(e => e.Atualizar(escola), Times.Once);


        }
    }
}
