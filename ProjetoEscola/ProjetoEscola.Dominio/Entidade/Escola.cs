using ProjetoEscola.Dominio.Entidade.Base;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoEscola.Dominio.Entidade
{
    public class Escola : EntityBase
    {
        public string Descricao { get; private set; }

        public virtual ICollection<Turma> Turmas { get; set; }

        protected Escola() { }

        public Escola(string descricao)
        {
            SetNomeEscola(descricao);
        }

        public void SetNomeEscola(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
                AddNotification("Descricao", "Favor informe a descrição");
            
            Descricao = descricao;
        }
    }
}
