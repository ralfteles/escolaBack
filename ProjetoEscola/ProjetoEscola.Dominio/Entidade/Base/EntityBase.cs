using Flunt.Notifications;
using System;

namespace ProjetoEscola.Dominio.Entidade.Base
{
    public abstract class EntityBase : Notifiable
    {
        public Guid Id { get; private set; }

        public EntityBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
