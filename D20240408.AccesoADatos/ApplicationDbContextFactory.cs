using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace D20240408.AccesoADatos
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            const string conn = "workstation id=D20240408DB.mssql.somee.com;packet size=4096;user id=DavidRuano_SQLLogin_1;pwd=uqhbzj5uqi;data source=D20240408DB.mssql.somee.com;persist security info=False;initial catalog=D20240408DB;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(conn);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
