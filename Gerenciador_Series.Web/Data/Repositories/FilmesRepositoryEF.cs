using Gerenciador_Series.Web.Models;

namespace Gerenciador_Series.Web.Data.Repositories
{
    public class FilmesRepositoryEF : RepositoryEF<Filme>
    {
        public FilmesRepositoryEF(LCFilmesDataContext ctx) : base(ctx)
        {

        }
    
    }
}
