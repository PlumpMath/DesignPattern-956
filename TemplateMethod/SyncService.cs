using System;

namespace TerrLuo.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 缓存刷新服务类
    /// </summary>
    public partial class SyncService /* : ServiceContract */
    {
        /// <summary>
        /// API called by external sync jobs
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /* 
        
        [Action(DoSyncTaskCOC.Action)] 
        
        */
        public void SyncCache(SyncData syncData)
        {
            var syncTask = SyncTaskFactory.CreateTask(syncData.TaskName);

            if (syncTask != null)
            {
                syncTask.Sync(syncData);
            }
        }
    }
}
