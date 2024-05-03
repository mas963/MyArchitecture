using Randevu.Domain.Common;
using Randevu.Domain.Entities;

namespace Randevu.Domain.Events;

public class TodoItemDeletedEvent : BaseEvent
{
    public TodoItemDeletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}