using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string messageLine = logLine.Substring(logLine.IndexOf(" ") + 1);
        return messageLine.Trim();
    }

    public static string LogLevel(string logLine)
    {
        string capitalLogLevel = logLine.Substring(logLine.IndexOf("[") + 1, logLine.IndexOf("]") - 1);
        string cleanLogLevel = capitalLogLevel.Trim();
        return cleanLogLevel.ToLower();
    }

    public static string Reformat(string logLine)
    {
        return LogLine.Message(logLine) + " (" + LogLine.LogLevel(logLine) + ")";
    }
}
