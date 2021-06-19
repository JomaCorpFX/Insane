﻿using Insane.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insane.AspNet.Identity.Model1.Context.Factory
{
    public class IdentityOracleDbContextFactory : IDesignTimeDbContextFactory<IdentityOracleDbContext>
    {
        public IdentityOracleDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().
                   SetBasePath(Directory.GetCurrentDirectory())
                   .AddUserSecrets<IdentityDbContextBase>()
                   .AddJsonFile(IdentityConstants.DefaultConfigurationFile, false, true)
                   .Build();
            DbContextSettings dbSetting = new DbContextSettings();
            configuration.Bind(nameof(DbContextSettings), dbSetting);

            DbContextOptions<IdentityOracleDbContext> options = new DbContextOptionsBuilder<IdentityOracleDbContext>()
                .UseOracle(dbSetting.OracleConnectionString)
                .EnableSensitiveDataLogging(true)
                .EnableDetailedErrors(true)
                .Options;

            return new IdentityOracleDbContext(options);
        }
    }
}
