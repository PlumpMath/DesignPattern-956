using System;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 同步任务抽象类
    /// </summary>
    internal abstract class SyncTask
    {
        #region Virtual Member

        /// <summary>
        /// 子任务列表，这些任务用于处理跟该主任务相关的一些任务
        /// 默认返回一个空列表
        /// </summary>
        protected virtual List<SyncTask> SubTasks
        {
            get { return new List<SyncTask>(); }
        }

        #endregion

        /// <summary>
        /// 缓存刷新
        /// </summary>
        /// <param name="syncDataItem">时间戳</param>
        internal abstract void Sync(SyncData syncDataItem);
    }
}
