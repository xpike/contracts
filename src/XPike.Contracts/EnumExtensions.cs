using System;
using System.ComponentModel;
using System.Linq;

namespace XPike.Contracts
{
    /// <summary>
    /// Extension methods for working with Enums.
    ///
    /// Exposes:
    /// - GetDescription()
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Retrieves the value of a DescriptionAttribute that is attached to an Enum Member (aka "name", "value", or "field").
        /// By default, if no Description is present, a null string will be returned.
        /// You can optionally specify a default value, or indicate that an exception should be thrown (eg, if the Description is required).
        /// </summary>
        /// <typeparam name="TEnum">The type of the Enum whose Member is being provided to retrieve a Description from.</typeparam>
        /// <param name="value">The Enum Member to retrieve a Description from.</param>
        /// <param name="defaultValue">An optional default value to return if no DescriptionAttribute is attached to the Enum Member.</param>
        /// <param name="throwIfMissing">An optional parameter which, if true, will cause an InvalidOperationException to be thrown if no Description is able to be retrieved from the Enum Member.</param>
        /// <returns></returns>
        public static string GetDescription<TEnum>(this TEnum value, string defaultValue = null, bool throwIfMissing = false)
            where TEnum : Enum
        {
            string valueOrDefault = null;

            try
            {
                var enumType = typeof(TEnum);
                var memberInfos = enumType.GetMember(value.ToString());
                var enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == enumType);
                var valueAttributes = enumValueMemberInfo?.GetCustomAttributes(typeof(DescriptionAttribute), false);
                valueOrDefault = (valueAttributes?.FirstOrDefault() as DescriptionAttribute)?.Description ?? defaultValue;
            }
            catch (Exception)
            {
                // Intentional no-op
            }

            if (valueOrDefault == null && throwIfMissing)
                throw new InvalidOperationException($"No Description attribute found for Enum Member {typeof(TEnum)}.{value}!");

            return valueOrDefault;
        }
    }
}