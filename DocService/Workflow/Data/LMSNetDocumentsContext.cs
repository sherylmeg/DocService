using System;
using Microsoft.EntityFrameworkCore;
using DocService.Workflow.Documents;


namespace DocService.Workflow.Data
{
    public class LMSNetDocumentsContext : Microsoft.EntityFrameworkCore.DbContext
    {        
        public DbSet<NewDocumentManagement> NewDocumentManagement { get; set; }

        public LMSNetDocumentsContext(DbContextOptions<LMSNetDocumentsContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewDocumentManagement>(entity =>
            {
                entity.HasKey(e => e.DocGUID);
                
            });
        }
    }
}