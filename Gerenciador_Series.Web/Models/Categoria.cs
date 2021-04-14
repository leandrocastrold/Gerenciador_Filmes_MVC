using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Series.Web.Models
{
    public class Categoria : Entity
    {
        public virtual ICollection<Filme> Filmes { get; set; }
    }
}
