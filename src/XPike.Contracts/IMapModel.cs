namespace XPike.Contracts
{
    /// <summary>
    /// An interface to identify a Record Mapper which can convert from a Model into a Record.
    /// 
    /// It's recommended to use this instead of IMap when converting from a Model to a Record
    /// since this ensures that TInput implements IModel and TOutput implements IRecord.
    /// </summary>
    /// <typeparam name="TInput">The IModel to convert into an IRecord.</typeparam>
    /// <typeparam name="TOutput">The IRecord converted from the IModel.</typeparam>
    public interface IMapModel<in TInput, out TOutput>
        : IMap<TInput, TOutput>
        where TInput : IModel
        where TOutput : IRecord
    {
    }
}