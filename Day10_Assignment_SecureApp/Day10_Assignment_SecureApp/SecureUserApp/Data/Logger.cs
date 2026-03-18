using System;
using System.IO;

namespace SecureUserApp.Services
{
    public static class Logger
    {
        private static readonly string path = "app.log";

        public static void Info(string message)
        {
            File.AppendAllText(path, $"[INFO] {DateTime.Now}: {message}\n");
        }

        public static void Error(string message)
        {
            File.AppendAllText(path, $"[ERROR] {DateTime.Now}: {message}\n");
        }
    }
}