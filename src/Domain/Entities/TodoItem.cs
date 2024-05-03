using System;
using Randevu.Domain.Common;
using Randevu.Domain.Enums;
using Randevu.Domain.Events;

namespace Randevu.Domain.Entities;

public class TodoItem : BaseAuditableEntity
{
    public int ListId { get; set; }
    
    public string? Title { get; set; }
    
    public string? Note { get; set; }
    
    public PriorityLevel Priority { get; set; }
    
    public DateTime? Reminder { get; set; }

    public bool _done;

    public bool Done
    {
        get => _done;
        set
        {
            if (value && !_done)
            {
                AddDomainEvent(new TodoItemCompletedEvent(this));
            }

            _done = value;
        }
    }

    public TodoList List { get; set; } = null!;
}