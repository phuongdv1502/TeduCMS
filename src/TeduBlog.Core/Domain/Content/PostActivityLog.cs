using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduBlog.Core.Domain.Helper;

namespace TeduBlog.Core.Domain.Content
{
    [Table("PostActivityLogs")]
    public class PostActivityLog
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PostId { get; set; }

        public EStatus FromStatus { set; get; }

        public EStatus ToStatus { set; get; }

        public DateTime DateCreated { get; set; }

        [MaxLength(500)]
        public string? Note { set; get; }

        public Guid UserId { get; set; }
    }
}
