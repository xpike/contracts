namespace XPike.Contracts
{
    /// <summary>
    /// An interface to identify a Record Mapper which can convert from a Record into a Model.
    /// 
    /// It's recommended to use this instead of IMap when converting from a Record to a Model
    /// since this ensures that TInput implements IRecord and TOutput implements IModel.
    /// </summary>
    /// <typeparam name="TInput">The IRecord converted from the IModel.</typeparam>
    /// <typeparam name="TOutput">The IModel to convert into an IRecord.</typeparam>
    public interface IMapRecord<in TInput, out TOutput>
        : IMap<TInput, TOutput>
        where TInput : IRecord
        where TOutput : IModel
    {
    }
}