namespace XPike.Contracts
{
    /// <summary>
    /// A purely decorative/categorical interface to identify a class as being a Model.
    /// 
    /// Models are intended to be used throughout business logic and/or exposed via an SDK.
    /// 
    /// This differs from Records, which are not intended to be used throughout business logic or exposed via an SDK.
    /// </summary>
    public interface IModel
    {
    }
}