namespace XPike.Contracts
{
    /// <summary>
    /// A purely decorative/categorical interface to identify classes which are a contract
    /// for interacting with a service through an SDK (such as an HTTP request/response pair).
    ///
    /// This interaction may take place over different communication modes, and so a more
    /// specific interface should usually be applied.
    ///
    /// This differs from Models which may be exposed via an SDK but which are not "root-level"
    /// objects such as a request and response.
    /// </summary>
    public interface IContract
    {
    }
}