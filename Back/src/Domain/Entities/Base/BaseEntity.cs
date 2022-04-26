using System;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? CompleteDate { get; set; } = null;
    }
}
