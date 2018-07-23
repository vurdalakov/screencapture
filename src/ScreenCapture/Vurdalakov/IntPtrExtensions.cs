namespace Vurdalakov
{
    using System;

    public static class IntPtrExtensions
    {
        public static UInt32 LoWord(this IntPtr value)
        {
            return unchecked((UInt16)((Int64)value & 0xFFFF));
        }

        public static UInt32 HiWord(this IntPtr value)
        {
            return unchecked((UInt16)((((Int64)value) >> 16) & 0xFFFF));
        }

        public static UInt32 LoWord(this UIntPtr value)
        {
            return unchecked((UInt16)((Int64)value & 0xFFFF));
        }

        public static UInt32 HiWord(this UIntPtr value)
        {
            return unchecked((UInt16)((((Int64)value) >> 16) & 0xFFFF));
        }
    }
}
