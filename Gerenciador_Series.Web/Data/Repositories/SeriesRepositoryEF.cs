using Gerenciador_Series.Web.Models;

namespace Gerenciador_Series.Web.Data.Repositories
{
    public class SeriesRepositoryEF : RepositoryEF<Serie>
    {
        public SeriesRepositoryEF(LCFilmesDataContext context) : base(context)
        {
        }
    }
}
