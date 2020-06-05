using Microsoft.EntityFrameworkCore;
using ProjetoEscola.Dominio.Entidade;
using ProjetoEscola.Dominio.Interface;
using ProjetoEscola.Repositorio.Contexto;
using ProjetoEscola.Repositorio.Repositorios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Repositorio.Repositorios
{
    public class EscolaRepository : Repository<Escola>, IEscolaRepository
    {

    }
}
