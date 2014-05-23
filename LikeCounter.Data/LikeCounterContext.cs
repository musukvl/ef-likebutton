using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LikeCounter.Data.Model;

namespace LikeCounter.Data
{
    public class LikeCounterContext : DbContext
    {
        public DbSet<LikeRecord> LikeRecords { get; set; }


        public LikeCounterContext()
        {
            Debug.Write(Database.Connection.ConnectionString);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LikeRecordMap());
        }
    }
}
