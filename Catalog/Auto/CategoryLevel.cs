using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of category_level
    /// </summary>
    [Table("category_level")]
    [DataContract]
    public partial class CategoryLevel
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.CategoryLevel"/>的构造函数
        /// </summary>
        public CategoryLevel()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 父分类Id
        /// </summary>
        [Key]
        [Column("parent_id")]
        [DataMember(Order = 0)]
        public int ParentId { get; set; } = 0;      	
        /// <summary>
        /// 子分类Id
        /// </summary>
        [Key]
        [Column("child_id")]
        [DataMember(Order = 1)]
        public int ChildId { get; set; } = 0;      	
        /// <summary>
        /// 相对层级
        /// </summary>
        [Column("relative_level")]
        [DataMember(Order = 2)]
        public int RelativeLevel { get; set; } = 0;      	
        /// <summary>
        /// 排序号,升序
        /// </summary>
        [Column("sort_no")]
        [DataMember(Order = 3)]
        public int SortNo { get; set; } = 0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 4)]
        public long UserId { get; set; } = 0;      	
        /// <summary>
        /// 数据标识
        /// </summary>
        [Column("data_flags")]
        [DataMember(Order = 5)]
        public long DataFlags { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="categoryLevel"></param>        
        public virtual void CopyTo(CategoryLevel categoryLevel)
        {
            categoryLevel.ParentId = ParentId;
            categoryLevel.ChildId = ChildId;
            categoryLevel.RelativeLevel = RelativeLevel;
            categoryLevel.SortNo = SortNo;
            categoryLevel.UserId = UserId;
            categoryLevel.DataFlags = DataFlags;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual CategoryLevel Clone()
        {
            var obj = new CategoryLevel();
            CopyTo(obj);
            return obj;
        }
        #endregion
        
        #region 重载方法
        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var sb = new System.Text.StringBuilder("CategoryLevel{");
            sb.Append("ParentId='");
            sb.Append(ParentId).AppendLine("'");
            sb.Append(", ChildId='");
            sb.Append(ChildId).AppendLine("'");
            sb.Append(", RelativeLevel='");
            sb.Append(RelativeLevel).AppendLine("'");
            sb.Append(", SortNo='");
            sb.Append(SortNo).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append(", DataFlags='");
            sb.Append(DataFlags).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}