// See https://aka.ms/new-console-template for more information

using Video.Convertor;
const string videoPath = @"InputVideoFIlePath";
const string saveIn = @"OutPutVideoFilePath";
const string ffmpegArg = $"-i \"{videoPath}\" -vf scale=-1:720 \"{saveIn}\"";
const string ffmpegPath = @"C:\FilePath\ffmpeg.exe";
var ffmpegTask = new FFmpegTask(ffmpegPath, ffmpegArg);
ffmpegTask.Start();