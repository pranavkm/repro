using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of model
    /// </summary>
    [Table("model")]
    [DataContract]
    public partial class Model
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Model"/>的构造函数
        /// </summary>
        public Model()
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
        /// 型号名称，如2013款 1.6L 自动时尚型
        /// </summary>
        [Column("name")]
        [DataMember(Order = 1)]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;      	
        /// <summary>
        /// 全称，车系名称+年代款+排量+变速箱类型/驱动方式+型号名称,如速腾 2013款 1.6L 自动时尚型
        /// </summary>
        [Column("full_name")]
        [DataMember(Order = 2)]
        [StringLength(300)]
        public string FullName { get; set; } = string.Empty;      	
        /// <summary>
        /// 系列Id
        /// </summary>
        [Column("series_id")]
        [DataMember(Order = 3)]
        public int SeriesId { get; set; } = 0;      	
        /// <summary>
        /// 品牌Id
        /// </summary>
        [Column("brand_id")]
        [DataMember(Order = 4)]
        public int BrandId { get; set; } = 0;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 5)]
        [StringLength(2000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 来源Id
        /// </summary>
        [Column("source_id")]
        [DataMember(Order = 6)]
        [StringLength(50)]
        public string SourceId { get; set; } = string.Empty;      	
        /// <summary>
        /// 应用Id
        /// </summary>
        [Column("application_id")]
        [DataMember(Order = 7)]
        public int ApplicationId { get; set; } = 0;      	
        /// <summary>
        /// 数据状态
        /// </summary>
        [Column("state")]
        [DataMember(Order = 8)]
        public int State { get; set; } = 0;      	
        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("user_id")]
        [DataMember(Order = 9)]
        public long UserId { get; set; } = 0;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="model"></param>        
        public virtual void CopyTo(Model model)
        {
            model.Id = Id;
            model.Name = Name;
            model.FullName = FullName;
            model.SeriesId = SeriesId;
            model.BrandId = BrandId;
            model.Description = Description;
            model.SourceId = SourceId;
            model.ApplicationId = ApplicationId;
            model.State = State;
            model.UserId = UserId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Model Clone()
        {
            var obj = new Model();
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
            var sb = new System.Text.StringBuilder("Model{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", FullName='");
            sb.Append(FullName).AppendLine("'");
            sb.Append(", SeriesId='");
            sb.Append(SeriesId).AppendLine("'");
            sb.Append(", BrandId='");
            sb.Append(BrandId).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", SourceId='");
            sb.Append(SourceId).AppendLine("'");
            sb.Append(", ApplicationId='");
            sb.Append(ApplicationId).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", UserId='");
            sb.Append(UserId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}