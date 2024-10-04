using System.Runtime.InteropServices;

IntPtr unmanagedMemory = Marshal.AllocHGlobal(100);
for (int i = 0; i < 100; i++)
{
    Marshal.WriteByte(unmanagedMemory, i, (byte)i);
}

for (int i = 0; i < 100; i++)
{
    byte value = Marshal.ReadByte(unmanagedMemory, i);
    Console.Write(value + " ");
}

Marshal.FreeHGlobal(unmanagedMemory);