namespace XPike.Contracts
{
    /// <summary>
    /// A purely decorative/categorical interface to identify a class that is a Record.
    /// 
    /// A Record is intended for use when accessing data storage and should not be directly
    /// referenced within business logic or exposed via an SDK.
    /// 
    /// This differs from a Model which is intended for use in business logic and/or to be exposed via an SDK.
    /// </summary>
    public interface IRecord
    {
    }
}