
# Video.Convertor

## Introduction
`Video.Convertor` is a C# console application designed to simplify the process of converting high-resolution videos to lower resolutions using FFmpeg. Ideal for efficient video resizing.

## Prerequisites
- **FFmpeg**: Must be installed on your system. Download from [FFmpeg's official website](http://www.ffmpeg.org/).
- **.NET 6 SDK**: Required for running the application. Download from [Microsoft's .NET download page](https://dotnet.microsoft.com/download/dotnet/6.0).

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/Hu238n/Video.Convertor
   ```
2. Navigate to the cloned directory.

## Configuration
Before running the application, configure the following in `Program.cs`:
- `videoPath`: Path to the input video file.
- `saveIn`: Path for the output video.
- `ffmpegPath`: Path to your FFmpeg executable.

## Usage
To run the application:
1. Open a command line or terminal.
2. Navigate to the project directory.
3. Execute using .NET CLI:
   ```bash
   dotnet run
   ```

## How It Works
Leverages FFmpeg for video processing. Initializes a process to run FFmpeg with specified arguments for video resolution conversion.

## Contributing
Contributions are welcome. Please fork the repository and submit pull requests for any enhancements or fixes.
