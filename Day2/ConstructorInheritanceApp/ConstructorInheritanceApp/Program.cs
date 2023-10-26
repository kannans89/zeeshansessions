using System;
using System.IO;

MemoryStream stream = new MemoryStream();
StreamWriter writer = new StreamWriter(stream);

writer.WriteLine("hello world");
writer.WriteLine("good bye");
writer.Flush();
// Reset the stream position to the beginning.
stream.Position = 0;

// Create a StreamReader to read from the MemoryStream.
using (StreamReader reader = new StreamReader(stream))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}
