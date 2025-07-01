using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeduBlog.Core.Domain.Content
{
    [Table("PostCategories")]
    [Index(nameof(Slug), IsUnique = true)]
    public class PostCategory
    {
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Tên danh mục
        /// </summary>
        [MaxLength(250)]
        
        public required string Name { set; get; }

        [Column(TypeName = "varchar(250)")]
        public required string Slug { set; get; }

        /// <summary>
        /// ID bài viết cha
        /// </summary>
        public Guid? ParentId { set; get; }
        public bool IsActive { set; get; }
        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime DateCreated { set; get; }
        /// <summary>
        /// Ngày chỉnh sửa
        /// </summary>
        public DateTime? DateModified { set; get; }
        /// <summary>
        /// Mô tả
        /// </summary>
        [MaxLength(160)]
        public string? SeoDescription { set; get; }
        /// <summary>
        /// Sắp xếp theo
        /// </summary>
        public int SortOrder { set; get; }
    }
}
