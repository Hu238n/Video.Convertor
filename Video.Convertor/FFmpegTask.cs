using System.Diagnostics;

namespace Video.Convertor
{
    public class FFmpegTask
    {
        public Process Process = new Process();

        public FFmpegTask(string ffmpegPath, string arguments)
        {
            Process.StartInfo.FileName = ffmpegPath;
            Process.StartInfo.Arguments = arguments;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.CreateNoWindow = false;
            Process.StartInfo.UseShellExecute = false;
        }
        public bool Start()
        {
            return Process.Start();
        }
    }
}
