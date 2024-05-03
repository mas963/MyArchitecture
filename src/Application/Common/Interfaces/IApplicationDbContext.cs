using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Randevu.Domain.Entities;

namespace Randevu.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }
    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}