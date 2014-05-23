using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LikeCounter.Data.Model
{
    public class LikeRecord
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string PageId { get; set; }
    }

    public class LikeRecordMap : EntityTypeConfiguration<LikeRecord>
    {
        public LikeRecordMap()
        {
            ToTable("likes");

            HasKey(d => d.Id);
            Property(d => d.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(d => d.Created)
                .HasColumnName("created")
                .IsRequired();

            Property(d => d.PageId)
                .HasColumnName("page_id")
                .IsRequired();
        }
    }
}
