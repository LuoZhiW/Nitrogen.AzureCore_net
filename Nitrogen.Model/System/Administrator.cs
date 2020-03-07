using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nitrogen.Model
{
    /// <summary>
    /// 管理员。
    /// </summary>
    public class Administrator
    {
        /// <summary>
        /// 管理员ID。
        /// </summary>
        [Column("F_AdministratorId")]
        public Guid AdministratorId { get; set; }

        /// <summary>
        /// 管理员名。
        /// </summary>
        [Column("F_AdministratorName")]
        public string AdministratorName { get; set; }

        /// <summary>
        /// 管理员昵称。
        /// </summary>
        [Column("F_NickName")]
        public string NickName { get; set; }

        /// <summary>
        /// 微信用户关联的openId。
        /// </summary>
        [Column("F_WeiXinUserOpenId")]
        public string WeiXinUserOpenId { get; set; }

        /// <summary>
        /// 管理员密码。
        /// </summary>
        [Column("F_AdministratorPassword")]
        public string AdministratorPassword { get; set; }

        /// <summary>
        /// 邮箱。
        /// </summary>
        [Column("F_Email")]
        public string Email { get; set; }

        /// <summary>
        /// 手机号。
        /// </summary>
        [Column("F_MobileNumber")]
        public string MobileNumber { get; set; }

        /// <summary>
        /// 头像。
        /// </summary>
        [Column("F_Avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 是否允许多处登录。
        /// </summary>
        [Column("F_EnableMultiLogin")]
        public bool EnableMultiLogin { get; set; }

        /// <summary>
        /// 登录次数。
        /// </summary>
        [Column("F_LoginTimes")]
        public int LoginTimes { get; set; }

        /// <summary>
        /// 部门ID。
        /// </summary>
        [Column("F_DepartmentId")]
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// 所属部门。
        /// </summary>
        [ForeignKey("F_DepartmentId")]
        public virtual Department Department { get; set; }

        /// <summary>
        /// 创建人。
        /// </summary
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
