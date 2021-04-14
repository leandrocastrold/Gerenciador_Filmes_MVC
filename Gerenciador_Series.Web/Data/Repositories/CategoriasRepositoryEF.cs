using Gerenciador_Series.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Series.Web.Data.Repositories
{
    public class CategoriasRepositoryEF : RepositoryEF<Categoria>
    {
        public CategoriasRepositoryEF(LCFilmesDataContext context) : base(context)
        {
        }
    }
}
