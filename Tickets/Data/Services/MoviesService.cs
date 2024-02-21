using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Tickets.Data.Base;
using Tickets.Models;

namespace Tickets.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        
    }
}
