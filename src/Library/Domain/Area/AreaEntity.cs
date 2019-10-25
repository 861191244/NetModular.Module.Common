using NetModular.Lib.Data.Abstractions.Attributes;
using NetModular.Lib.Data.Core.Entities;

namespace NetModular.Module.Common.Domain.Area
{
    /// <summary>
    /// 区划代码
    /// </summary>
    [Table("Area")]
    public partial class AreaEntity : Entity<int>
    {
        /// <summary>
        /// 父节点
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 区域代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Length(100)]
        public string Name { get; set; }

        /// <summary>
        /// 拼音
        /// </summary>
        [Length(400)]
        public string Pinyin { get; set; }

        /// <summary>
        /// 简拼
        /// </summary>
        [Nullable]
        public string Jianpin { get; set; }

        /// <summary>
        /// 区号
        /// </summary>
        [Nullable]
        public string AreaCode { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [Nullable]
        public string ZipCode { get; set; }

        /// <summary>
        /// 精度
        /// </summary>
        [Nullable]
        public string Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [Nullable]
        public string Latitude { get; set; }
    }
}
