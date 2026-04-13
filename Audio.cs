using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string inputMp4 = "Sandile.mp4";  // Your MP4 file here
        string outputWav = "Sandile.wav";

        if (!File.Exists(inputMp4))
        {
            Console.WriteLine($"Error: {inputMp4} not found. Place MP4 in project root.");
            return;
        }

        Console.WriteLine($"Converting {inputMp4} to {outputWav}...");

        await FFMpegArguments
            .FromFileInput(inputMp4)
            .OutputToFile(outputWav, true, options => options
                .WithAudioCodec("pcm_s16le")  // Uncompressed WAV PCM 16-bit [web:97]
                .WithAudioBitrate("128k")
                .ForceFormat("wav"))
            .ProcessAsynchronously();  // Async for large files [web:100]

        Console.WriteLine("Done! greeting.wav ready for chatbot.");
    }
}
