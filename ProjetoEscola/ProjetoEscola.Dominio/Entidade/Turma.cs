using ProjetoEscola.Dominio.Entidade.Base;
using System;

namespace ProjetoEscola.Dominio.Entidade
{
    public class Turma : EntityBase
    {
        public string Nome { get; private set; }
        public int Vagas { get; private set; }

        public Guid EscolaId { get;  set; }
        public virtual Escola Escola { get; private set; }

        protected Turma() { }


        public Turma(string nome, int totalVagas, Guid escolaId)
        {
            SetNomeTurma(nome);
            SetVagasDisponiveis(totalVagas);
            SetEscolaId(escolaId);
        }

        public void SetNomeTurma(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("Informe o nome da turma");

            Nome = nome;
        }

        public void SetVagasDisponiveis(int total)
        {
            if (total <= 0)
                throw new Exception("Quantidade de vagas precisa ser acima de zero");

            Vagas = total;
        }

        public void SetEscolaId(Guid escolaId)
        {
            if (escolaId == Guid.Empty)
                throw new Exception("Informe a escola");

            EscolaId = escolaId;
        }

    }
}
