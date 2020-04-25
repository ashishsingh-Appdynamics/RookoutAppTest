using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Rook;

namespace RookoutAppTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rook.RookOptions options = new Rook.RookOptions()
            {
                token = "8e32a608b8a3d5a383f6e457022c7e27a22732130133fa0d629bbd1dcb5c5965",
                labels = new Dictionary<string, string> { { "env", "dev" } },
                log_level = "Trace",
                log_to_stderr = true,
                debug = true,
                log_file = @"C:\AppdLogs\dotnet-rook.log",
                throw_errors = true,
                log_to_file = true

            };
            Rook.API.Start(options);

            CreateHostBuilder(args).Build().Run();
        }
        public static void Start(RookOptions opts)
        {
           
            //opts.host = "demo-nodejs-57bf5c9888-49rmv";
            //opts.token.
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
