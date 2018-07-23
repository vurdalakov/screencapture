namespace Vurdalakov
{
    using System;
    using System.Linq;
    using System.Reflection;

    public static class EnumExtensions
    {
        public static String GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()?.GetMember(enumValue.ToString())?.FirstOrDefault()?.GetCustomAttribute<DisplayNameAttribute>()?.Name ?? enumValue.ToString();
        }
    }

    public class DisplayNameAttribute : Attribute
    {
        public String Name { get; }

        public DisplayNameAttribute(String name)
        {
            this.Name = name;
        }
    }
}
