namespace Ordering.Domain.ValueObjects
{
    public class CustomerId
    {
        public Guid Value { get; }
        private CustomerId(Guid value) => Value = value;
        public static CustomerId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value, nameof(value));
            if (value == Guid.Empty)
            {
                throw new DomainException("CustomerId cannot be an empty.");
            }

            return new CustomerId(value);
        }
    }
}
