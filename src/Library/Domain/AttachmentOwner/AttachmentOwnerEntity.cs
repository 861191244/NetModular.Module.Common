﻿
using System;
using NetModular.Lib.Data.Abstractions.Attributes;
using NetModular.Lib.Data.Core.Entities;

namespace NetModular.Module.Common.Domain.AttachmentOwner
{
    /// <summary>
    /// 附件拥有者
    /// </summary>
    [Table("Attachment_Owner")]
    public class AttachmentOwnerEntity:Entity
    {
        /// <summary>
        /// 附件编号
        /// </summary>
        public Guid AttachmentId { get; set; }

        /// <summary>
        /// 账户编号
        /// </summary>
        public Guid AccountId { get; set; }
    }
}
