using System;
using System.Collections;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 产品图片同步任务
    /// </summary>
    internal class ProductImageSyncTask : SwallowSyncTask
    {
        #region 单例模式

        private static readonly ProductImageSyncTask _syncJob = new ProductImageSyncTask();

        private ProductImageSyncTask()
        {
        }

        internal static ProductImageSyncTask Instance
        {
            get { return _syncJob; }
        }

        #endregion
        
        /// <summary>
        /// 从缓存获取产品图片
        /// </summary>
        /// <param name="key"></param>
        protected override IList GetCachedValues(string key)
        {
            /*
            
            var productIDs = new List<int> { Convert.ToInt32(key) };
            var cachedItems = MemcachedProvider.ProductImage.GetFromCache(productIDs);
            return cachedItems != null ? cachedItems.ToList() : null;
            
            */

            return null;
        }

        /// <summary>
        /// 刷新产品图片缓存
        /// </summary>
        /// <param name="key"></param>
        protected override void RefreshCachedItems(string key)
        {
            /*
            
            var productIDs = new List<int> { Convert.ToInt32(key) };
            var freshItems = new ProductImageService().GetImages(productIDs);
            MemcachedProvider.ProductImage.SaveToCache(freshItems);
            
            */
        }

    }
}
