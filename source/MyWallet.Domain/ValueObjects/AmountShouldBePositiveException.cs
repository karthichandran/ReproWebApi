namespace RePro.Domain.ValueObjects {
    public sealed class AmountShouldBePositiveException : DomainException {
        internal AmountShouldBePositiveException (string message) : base (message) { }
    }
}