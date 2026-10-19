using System;
using System.IO;
using System.Windows.Forms;
using Serilog;

namespace Bai_3;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        string logDir = Path.Combine(AppContext.BaseDirectory, "Logs");
        Directory.CreateDirectory(logDir);

        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File(
                Path.Combine(logDir, "log-.txt"),
                rollingInterval: RollingInterval.Day,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
            )
            .CreateLogger();

        try
        {
            Log.Information("Ứng dụng Kế hoạch dã ngoại khởi động.");
            ApplicationConfiguration.Initialize();
            Application.Run(new FormChuyenDi());
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Lỗi nghiêm trọng khi khởi động ứng dụng.");
        }
        finally
        {
            Log.Information("Ứng dụng Kế hoạch dã ngoại kết thúc.");
            Log.CloseAndFlush();
        }
    }
}