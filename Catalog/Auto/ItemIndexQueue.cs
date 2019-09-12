using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Pcs.Entity
{
    /// <summary>
    /// Entity of item_index_queue
    /// </summary>
    [Table("item_index_queue")]
    [DataContract]
    public partial class ItemIndexQueue
    {           
        #region 构造函数
        
        /// <summary>
        /// <see cref="Pcs.Entity.ItemIndexQueue"/>的构造函数
        /// </summary>
        public ItemIndexQueue()
        {
            Init();
        }
        
        #endregion
        
        #region 公共属性

        /// <summary>
        ///
        /// </summary>
        [Key]
        [Column("item_id")]
        [DataMember(Order = 0)]
        public long ItemId { get; set; } = 0;      	
        /// <summary>
        ///
        /// </summary>
        [Column("task_id")]
        [DataMember(Order = 1)]
        public int TaskId { get; set; } = (int)0;      	
        /// <summary>
        ///
        /// </summary>
        [Column("state")]
        [DataMember(Order = 2)]
        public int State { get; set; } = (int)0;      	
        /// <summary>
        ///
        /// </summary>
        [Column("created_on")]
        [DataMember(Order = 3)]
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.MinValue;      	
    
        #endregion	
        
        #region 公共方法
        /// <summary>
        /// 复制当前对象到目标对象
        /// </summary>
        /// <param name="itemIndexQueue"></param>        
        public virtual void CopyTo(ItemIndexQueue itemIndexQueue)
        {
            itemIndexQueue.ItemId = ItemId;
            itemIndexQueue.TaskId = TaskId;
            itemIndexQueue.State = State;
            itemIndexQueue.CreatedOn = CreatedOn;
        }
        
        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>        
        public virtual ItemIndexQueue Clone()
        {
            var obj = new ItemIndexQueue();
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
            var sb = new System.Text.StringBuilder("ItemIndexQueue{");
            sb.Append("ItemId='");
            sb.Append(ItemId).AppendLine("'");
            sb.Append(", TaskId='");
            sb.Append(TaskId).AppendLine("'");
            sb.Append(", State='");
            sb.Append(State).AppendLine("'");
            sb.Append(", CreatedOn='");
            sb.Append(CreatedOn).AppendLine("'");
            sb.Append("}");
            return sb.ToString();
        }
        #endregion
        
        #region 部分方法
        
        partial void Init();
        
        #endregion
    }
}