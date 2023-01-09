namespace BookStore.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual DateTime ModifyDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public void Remove() => IsActive = IsDeleted = true;
        public void SwitchState() => IsActive = !IsActive;

    }
}