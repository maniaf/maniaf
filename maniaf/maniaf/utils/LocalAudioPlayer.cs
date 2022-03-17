using NAudio;
using NAudio.Wave;

namespace maniaf
{
    internal class LocalAudioPlayer
    {
		public static async Task Play(string filename)
        {
            await Task.Run(() =>
            {
                using (var audioFile = new AudioFileReader(Path.Combine("./assets/audio", filename)))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                }
            });
        }
    }
}
