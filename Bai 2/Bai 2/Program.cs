using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Serilog;

namespace Bai_2;

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

        // 7. Xử lý lỗi toàn cục (9.3)
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

        Application.ThreadException += (sender, e) =>
        {
            Log.Error(e.Exception, "Bắt được ngoại lệ luồng UI chưa được xử lý (ThreadException)");
            MessageBox.Show("Đã xảy ra lỗi, thông tin đã được ghi lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        };

        AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
        {
            if (e.ExceptionObject is Exception ex)
            {
                Log.Fatal(ex, "Bắt được ngoại lệ tên miền chưa được xử lý (UnhandledException)");
            }
            MessageBox.Show("Đã xảy ra lỗi, thông tin đã được ghi lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        };

        try
        {
            Log.Information("Ứng dụng Quản lý nhà trọ khởi động.");
            ApplicationConfiguration.Initialize();
            Application.Run(new FormKhachThue());
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Lỗi nghiêm trọng khi khởi động ứng dụng.");
        }
        finally
        {
            Log.Information("Ứng dụng Quản lý nhà trọ kết thúc.");
            Log.CloseAndFlush();
        }
    }
}