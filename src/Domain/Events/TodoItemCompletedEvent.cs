using Randevu.Domain.Common;
using Randevu.Domain.Entities;

namespace Randevu.Domain.Events;

public class TodoItemCompletedEvent : BaseEvent
{
    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}