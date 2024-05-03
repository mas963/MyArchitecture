using Randevu.Domain.Common;
using Randevu.Domain.Entities;

namespace Randevu.Domain.Events;

public class TodoItemCreatedEvent : BaseEvent
{
    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}