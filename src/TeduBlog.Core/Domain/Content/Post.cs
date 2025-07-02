using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduBlog.Core.Domain.Helper;
namespace TeduBlog.Core.Domain.Content
{
    [Table("Posts")]
    [Index(nameof(Slug), IsUnique = true)]
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(250)]
        /// <summary>
        /// Tên bài viết
        /// </summary>
        public required string Name { get; set; }
        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar(250)")]
        /// <summary>
        /// Slogan
        /// </summary>
        public required string Slug { get; set; }
        [MaxLength(500)]
        /// <summary>
        /// Mô tả
        /// </summary>
        public string? Descrition { get; set; }
        [Required]
        /// <summary>
        /// Mã danh mục
        /// </summary>
        public Guid CategoryId { get; set; }
        /// <summary>
        /// Ảnh nhỏ
        /// </summary>
        public string? Thumbnail { get; set; }
        /// <summary>
        /// Nội dung
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// Người viết
        /// </summary>
        public Guid AuthorUserId { get; set; }
        [MaxLength(128)]
        /// <summary>
        /// Nguồn
        /// </summary>
        public string? Source { get; set; }
        [MaxLength(250)]
        /// <summary>
        /// Tag
        /// </summary>
        public string? Tag { get; set; }
        [MaxLength(160)]
        /// <summary>
        /// Seo mô tả
        /// </summary>
        public string? SeoDesciption { get; set; }
        /// <summary>
        /// Số lượt xem
        /// </summary>
        public int ViewCount { get; set; }
        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// Ngày chỉnh sửa
        /// </summary>
        public DateTime? DateModified { get; set; }
        /// <summary>
        /// Đã thanh toán cho người đăng bài chưa
        /// </summary>
        public bool IsPaid { get; set; }
        /// <summary>
        /// Tiền nhuận bút
        /// </summary>
        public double RoyaltyAmount { get; set; }
        /// <summary>
        /// Trạng thái
        /// </summary>
        public EStatus Status { get; set; }
    }
}
