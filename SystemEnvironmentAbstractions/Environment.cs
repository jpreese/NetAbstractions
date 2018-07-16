using System;

namespace SystemEnvironmentAbstractions
{
    public class Environment : IEnvironment
    {
        public string CommandLine => System.Environment.CommandLine;

        public string CurrentDirectory => System.Environment.CurrentDirectory;

        public int CurrentManagedThreadId => System.Environment.CurrentManagedThreadId;

        public int ExitCode => System.Environment.ExitCode;

        public bool HasShutdownStarted => System.Environment.HasShutdownStarted;

        public bool Is64BitOperatingSystem => System.Environment.Is64BitOperatingSystem;

        public bool Is64BitProcess => System.Environment.Is64BitProcess;

        public string MachineName => System.Environment.MachineName;

        public string NewLine => System.Environment.NewLine;

        public OperatingSystem OSVersion => System.Environment.OSVersion;

        public int ProcessorCount => System.Environment.ProcessorCount;

        public string StackTrace => System.Environment.StackTrace;

        public string SystemDirectory => System.Environment.SystemDirectory;

        public int SystemPageSize => System.Environment.SystemPageSize;

        public int TickCount => System.Environment.TickCount;

        public string UserDomainName => System.Environment.UserDomainName;

        public bool UserInteractive => System.Environment.UserInteractive;

        public string UserName => System.Environment.UserName;

        public Version Version => System.Environment.Version;

        public long WorkingSet => System.Environment.WorkingSet;
    }
}
