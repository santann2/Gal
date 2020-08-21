using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using GalGOT.Domain.Entites;
using MongoDB.Driver;
using System.Linq;

namespace GalGOT.Infra
{
    public class Context : DbContext
    {
        public static string ConnectionString { get; set; }
        public static string DatabaseName { get; set; }
        public static bool IsSSL { get; set; }

        private IMongoDatabase _database { get; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConnectionString));
                if (IsSSL)
                {
                    settings.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
                }
                var mongoClient = new MongoClient(settings);
                _database = mongoClient.GetDatabase(DatabaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar com o servidor.", ex);
            }
        }
        
        public IMongoCollection<Casa> Notas
        {
            get
            {
                return _database.GetCollection<Casa>("Casas");
            }
        }
        public DbSet<Casa> Casas { get; set; }

        public override int SaveChanges()
        {   
            return base.SaveChanges();
        }
    }
}
