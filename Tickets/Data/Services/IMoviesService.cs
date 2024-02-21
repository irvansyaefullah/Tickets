using System.Linq.Expressions;
using Tickets.Data.Base;
using Tickets.Models;

namespace Tickets.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
    }
}
