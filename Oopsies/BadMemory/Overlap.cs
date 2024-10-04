using System.Runtime.InteropServices;

namespace BadMemory
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct Overlap
    {
        [FieldOffset(0)]
        public int intValue;
        [FieldOffset(0)]
        public float floatValue;
    }
}
