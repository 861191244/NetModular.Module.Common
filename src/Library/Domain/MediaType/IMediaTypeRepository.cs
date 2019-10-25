﻿using System.Collections.Generic;
using System.Threading.Tasks;
using NetModular.Lib.Data.Abstractions;
using NetModular.Module.Common.Domain.MediaType.Models;

namespace NetModular.Module.Common.Domain.MediaType
{
    /// <summary>
    /// 多媒体类型仓储接口
    /// </summary>
    public interface IMediaTypeRepository : IRepository<MediaTypeEntity>
    {
        /// <summary>
        /// 根据后缀名查找
        /// </summary>
        /// <param name="ext"></param>
        /// <returns></returns>
        Task<MediaTypeEntity> GetByExt(string ext);

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IList<MediaTypeEntity>> Query(MediaTypeQueryModel model);

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <returns></returns>
        Task<bool> Exists(string ext, int id = 0);
    }
}
