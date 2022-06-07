using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net03_API_DB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

#region EFC.SQLServer packageAndTools_Installation -v5.0.1.0 
// Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 5.0.10
// Install-Package Microsoft.EntityFrameworkCore.Tools -Version 5.0.10
#endregion

#region PM>
// Add-Migration TransferTableModelsTo_MSSQL
// Update-Database
#endregion