using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of manufacturer
    /// </summary>
    [Table("manufacturer")]
    [DataContract]
    public partial class Manufacturer
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.Manufacturer"/>的构造函数
        /// </summary>
        public Manufacturer()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        /// 厂商Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [DataMember(Order = 0)]
        public int Id { get; set; } = 0;      	
        /// <summary>
        /// 厂商名称
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
        public int State { get; set; } = (int)1;      	
        /// <summary>
        /// 描述
        /// </summary>
        [Column("description")]
        [DataMember(Order = 3)]
        [StringLength(2000)]
        public string Description { get; set; } = string.Empty;      	
        /// <summary>
        /// 来源Id
        /// </summary>
        [Column("source_id")]
        [DataMember(Order = 4)]
        public int? SourceId { get; set; } = null;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="manufacturer"></param>        
        public virtual void CopyTo(Manufacturer manufacturer)
        {
            manufacturer.Id = Id;
            manufacturer.Name = Name;
            manufacturer.State = State;
            manufacturer.Description = Description;
            manufacturer.SourceId = SourceId;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual Manufacturer Clone()
        {
            var obj = new Manufacturer();
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
            var sb = new System.Text.StringBuilder("Manufacturer{");
            sb.Append("Id='");
            sb.Append(Id).AppendLine("'");
            sb.Append(", Name='");
            sb.Append(Name).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", Description='");
            sb.Append(Description).AppendLine("'");
            sb.Append(", SourceId='");
            sb.Append(SourceId).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}