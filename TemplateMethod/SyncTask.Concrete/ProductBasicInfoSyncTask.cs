using System;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 产品基本信息同步任务
    /// </summary>
    internal class ProductBasicInfoSyncTask : SwallowSyncTask
    {
        #region 单例模式
    
        private static readonly ProductBasicInfoSyncTask _syncJob = new ProductBasicInfoSyncTask();

        private ProductBasicInfoSyncTask()
        {
        }

        internal static ProductBasicInfoSyncTask Instance
        {
            get { return _syncJob; }
        }

        #endregion
        
        /// <summary>
        /// 子任务列表，这些任务用于处理跟该主任务相关的一些任务
        /// </summary>
        protected override List<SyncTask> SubTasks
        {
            get
            {
                return new List<SyncTask>
                {
                    /*
                    
                    ProductSegmentSyncTask.Instance,
                    ProductDescriptionSyncTask.Instance,
                    ProductAddInfoSyncTask.Instance,
                    ProductUnBookingSyncTask.Instance,
                    ProductDistrictVideoSyncTask.Instance,
                    ProductStructureInfoSyncTask.Instance,
                    ResourceFirstBookDateSyncTask.Instance,
                    ProductPriceAdjustSyncTask.Instance
                    
                    */
                };
            }
        }
                                                                                                      
        /// <summary>
        /// 从缓存获取产品基本信息
        /// </summary>
        /// <param name="key"></param>
        protected override IList GetCachedValues(string key)
        {
            /*
            
            var productIDs = new List<int> { Convert.ToInt32(key) };
            var cachedItems = MemcachedProvider.ProductBasicInfo.GetFromCache(productIDs);
            return cachedItems != null ? cachedItems.ToList() : null;
            
            */

            return null;
        }

        /// <summary>
        /// 刷新产品基本信息缓存
        /// </summary>
        /// <param name="key"></param>
        protected override void RefreshCachedItems(string key)
        {
            /*
            
            var productIDs = new List<int> { Convert.ToInt32(key) };
            var freshItems = new ProductBasicInfoService().GetBasicInfos(productIDs);
            MemcachedProvider.ProductBasicInfo.SaveToCache(freshItems);
            
            */
        }
    }
}
