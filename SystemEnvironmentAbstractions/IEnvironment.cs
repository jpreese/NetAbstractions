using System;

namespace SystemEnvironmentAbstractions
{
    public interface IEnvironment
    {
        string CommandLine { get; }
        string CurrentDirectory { get; }
        int CurrentManagedThreadId { get; }
        int ExitCode { get; }
        bool HasShutdownStarted { get; }
        bool Is64BitOperatingSystem { get; }
        bool Is64BitProcess { get; }
        string MachineName { get; }
        string NewLine { get; }
        OperatingSystem OSVersion { get; }
        int ProcessorCount { get; }
        string StackTrace { get; }
        string SystemDirectory { get; }
        int SystemPageSize { get; }
        int TickCount { get; }
        string UserDomainName { get; }
        bool UserInteractive { get; }
        string UserName { get; }
        Version Version { get; }
        long WorkingSet { get; }
    }
}
