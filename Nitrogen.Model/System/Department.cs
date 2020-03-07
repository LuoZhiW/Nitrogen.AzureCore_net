using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nitrogen.Model
{
    /// <summary>
    /// 部门。
    /// </summary>
    public class Department
    {
        /// <summary>
        /// 部门Id。
        /// </summary>
        [Column("F_DepartmentId")]
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [Column("F_DepartmentName")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [Column("F_Description")]
        public string Description { get; set; }

        /// <summary>
        /// 上级部门Id。
        /// </summary>
        [Column("F_ParentId")]
        public Guid ParentId { get; set; }

        /// <summary>
        /// 左值。
        /// </summary>
        [Column("F_Left")]
        public int Left { get; set; }

        /// <summary>
        /// 右值。
        /// </summary>
        [Column("F_Rigth")]
        public int Rigth { get; set; }

        /// <summary>
        /// 深度。
        /// </summary>
        [Column("F_Depth")]
        public int Depth { get; set; }

        /// <summary>
        /// 创建用户Id。
        /// </summary>
        [Column("F_CreateUserId")]
        public Guid CreateUserId { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [Column("F_CreateTime")]
        public DateTime CreateTime { get; set; }

        public void Create()
        {
            this.DepartmentId = Guid.NewGuid();
            this.CreateTime = DateTime.Now;
        }
    }
}
