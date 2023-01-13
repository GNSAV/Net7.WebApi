using Net7.WebApi.Entidades;
using System.Linq.Expressions;

namespace Net7.WebApi.Modelos
{
    public class FrutaQuery
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public Expression<Func<Fruta, bool>> Filter { get; set; }
        public List<Expression<Func<Fruta, object>>> Sort { get; set; }

        public FrutaQuery()
        {
            Page = 0;
            PageSize = 10;
            Filter = fruta => true;
            Sort = new List<Expression<Func<Fruta, object>>> { fruta => fruta.Nombre };
        }
    }


}
