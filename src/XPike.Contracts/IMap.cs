namespace XPike.Contracts
{
    /// <summary>
    /// An interface to indicate a class capable of mapping between two other differing types.
    /// These two types can be of any type - class, enum, interface or intrinsic data type.
    ///
    /// When mapping between a Record and a Model, it's recommended to use either
    /// IMapRecord or IMapModel instead, to add a layer of safety.
    /// </summary>
    /// <typeparam name="TInput">The type to convert into TOutput.</typeparam>
    /// <typeparam name="TOutput">The type to convert from TInput.</typeparam>
    public interface IMap<in TInput, out TOutput>
        : IRecordMapper
    {
        /// <summary>
        /// Converts from TInput to TOutput.
        /// </summary>
        /// <param name="input">The TInput value to be converted into TOutput.</param>
        /// <returns>The TOutput value converted from the TInput.</returns>
        TOutput Map(TInput input);
    }
}