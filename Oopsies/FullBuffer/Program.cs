// See https://aka.ms/new-console-template for more information
using FullBuffer;

MyBuffer buffer = new MyBuffer();
buffer.data = "1234567890"; // Overflowing the buffer

Console.WriteLine("Buffer Data: " + buffer.data);