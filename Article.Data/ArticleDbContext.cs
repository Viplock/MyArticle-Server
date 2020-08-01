using Microsoft.EntityFrameworkCore;
using MyArticle.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyArticle.Data
{
    public class ArticleDbContext:DbContext
    {
        public ArticleDbContext(DbContextOptions<ArticleDbContext> options):base(options)
        {
                
        }
        public DbSet<Article> Article { get; set; }
    }
}
