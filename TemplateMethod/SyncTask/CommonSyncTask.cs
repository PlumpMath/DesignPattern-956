using System;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 同步任务抽象类
    /// </summary>
    internal abstract class CommonSyncTask : SyncTask
    {
        #region Virtual Member

        /// <summary>
        /// 执行具体任务
        /// </summary>
        /// <param name="syncDataItem"></param>
        protected abstract void DoTask(SyncData syncDataItem);

        #endregion
        
        /// <summary>
        /// 缓存刷新
        /// </summary>
        /// <param name="syncDataItem">时间戳</param>
        internal override void Sync(SyncData syncDataItem)
        {
            // 执行任务
            DoTask(syncDataItem);

            // 执行子任务
            var subTasks = this.SubTasks;
            if (subTasks != null && subTasks.Count > 0)
            {
                subTasks.ForEach(subTask => subTask.Sync(syncDataItem));
            }
        }
    }
}
