namespace Pointers
{
    internal class Pointie
    {
        public unsafe static void Bump() //fair is fair you need the /unsafe flag for this, so your a bit of an idiot for doing this
        {
            int value = 42;
            int* pointer = &value;

            Console.WriteLine("Value: " + value);
            Console.WriteLine("Pointer Address: " + (long)pointer);
            Console.WriteLine("Pointer Value: " + *pointer);

            *pointer = 100;
            Console.WriteLine("Modified Value: " + value);
        }
    }
}
