namespace RePro.Infrastructure {
    public class SellerNotFoundException : InfrastructureException {
        internal SellerNotFoundException (string message) : base (message) { }
    }
}