using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace eShopSolution.Data.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
    {
        //Cấu hình đọc file json kết nối database 
        public EShopDbContext CreateDbContext(string[] args)
        {
            // Config đọc file setting.json
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsetting.json").Build();
           // Đọc chuỗi kết nối trong json file (setting.json)
            var connectionString = configuration.GetConnectionString("EShopsolutionDatabase");
            
            //Kết nối với database qua connectstring
            var optionsBuilder = new DbContextOptionsBuilder<EShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EShopDbContext(optionsBuilder.Options);
        }

    }
}
