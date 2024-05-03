using System.Collections.Generic;
using Randevu.Domain.Common;
using Randevu.Domain.ValueObjects;

namespace Randevu.Domain.Entities;

public class TodoList : BaseAuditableEntity
{
    public string? Title { get; set; }

    public Colour Colour { get; set; } = Colour.White;

    public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
}