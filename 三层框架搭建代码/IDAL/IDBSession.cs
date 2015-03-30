using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
    /// <summary>
    /// 数据层的 便捷大接口！ 里面包含所有的 数据层 接口访问 方式
    /// </summary>
    public partial interface IDBSession
    {
        int SaveChanges();
    }
}
