using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class Activity : BaseEntity
    {
        public int Number { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public PriorityEnum Priority { get; private set; }

        public Activity()
        { }

        public Activity(string title, string description, PriorityEnum priority)
        {
            Title = title;
            Description = description;
            Priority = priority;
        }

        public void SetDescription(string desc)
        {
            Description = desc;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }
        public void SetPriority(PriorityEnum priority)
        {
            Priority = priority;
        }
        public void SetCompleted()
        {
            CompleteDate = DateTime.UtcNow;
        }
    }
}