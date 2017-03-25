using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Manha01.Sabado.Presentation.ConsoleApp.Templates
{
    public interface IRepositoryBase<TEntity>
    {
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPorId(Guid? id);

        void Adicionar(TEntity entidade);
        void Alterar(TEntity entidade);
        void Excluir(TEntity entidade);
    }
}
