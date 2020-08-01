using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyArticle.Core
{
    public class Article
    {
        [Key]
        public int ID { get; set; }
        public string WritterId { get; set; }
        /// <summary>
        /// What is the artical all about
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Topic { get; set; }
        /// <summary>
        /// Who is the writter
        /// </summary>
        /// 
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string WritterName { get; set; }
        /// <summary>
        /// what type of artical it is
        /// </summary>
        public ArticleType Type { get; set; }
        /// <summary>
        /// This will be the Glimps of the article in 100 words
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public string MiniView { get; set; }
        /// <summary>
        /// complete artical data
        /// </summary>
        [Column(TypeName ="nvarchar(max)")]
        public string ArticleDate { get; set; }
        //public byte[] WritterImage { get; set; }
    }
}
