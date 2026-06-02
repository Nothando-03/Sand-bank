using System;
using NAudio.Wave;

namespace CyberSecurityAwarenessBotGUI.Services
{
    public class AudioPlayer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the path to the MP3 file:");
            string mp3FilePath = Console.ReadLine();

            if (string.IsNullOrEmpty(mp3FilePath))
            {
                                Console.WriteLine("No file path provided. Exiting.");
                return;
            }

            try
            {
                using (var audioFile = new AudioFileReader(mp3FilePath))
                {
                    using (var outputDevice = new WaveOutEvent())
                    {
                        outputDevice.Init(audioFile);
                        outputDevice.Play();
                        while (outputDevice.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        