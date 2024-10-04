using System.Runtime.InteropServices;

namespace FullBuffer
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    internal struct MyBuffer
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string data;
    }
}
