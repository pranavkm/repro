using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of series
    /// </summary>
    [Table("series")]
    [DataContract]
    public partial class Series
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Series"/>的构造函数
        /// </summary>
        public Series()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        [DataMember(Order = 1)]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 2)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 3)]
        [StringLength(2000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 品牌id
        /// </summary>
        [Column("brand_id")]
        [DataMember(Order = 4)]
        public int BrandId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="series"></param>        
        public virtual void CopyTo(Series series)
        {
            series.Id = Id;
            series.Name = Name;
            series.State = State;
            series.Description = Description;
            series.BrandId = BrandId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Series Clone()
        {
            var obj = new Series();
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
            var sb = new System.Text.StringBuilder("Series{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", BrandId='");
            sb.Append(BrandId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}