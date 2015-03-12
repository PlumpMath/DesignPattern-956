using System;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 缓存同步任务抽象类
    /// </summary>
    internal abstract class SwallowSyncTask : SyncTask
    {
        #region Private Member

        /// <summary>
        /// 通用缓存时间戳属性名
        /// </summary>
        private const string TimestampPropery = "Timestamp";

        private const string MsgInvalidTimestamp  = "缓存刷新任务[{0}]错误: 按DateTime类型在[{1}]对象中读取[" + TimestampPropery + "]属性失败！";

        /// <summary>
        /// 缓存反射缓存对象获得的Timestamp属性，以提升性能
        /// Key:    Type.FullName
        /// Value:  PropertyInfo
        /// </summary>
        private static Hashtable _htTimestampProperties = Hashtable.Synchronized(new Hashtable());

        #endregion

        #region Virtual Member

        /// <summary>
        /// 根据key从缓存获取数据
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        protected abstract IList GetCachedValues(string key);

        /// <summary>
        /// 根据key读取数据并刷新缓存
        /// </summary>
        /// <param name="key"></param>
        protected abstract void RefreshCachedItems(string key);

        #endregion
        
        /// <summary>
        /// 缓存刷新
        /// </summary>
        /// <param name="syncDataItem">时间戳</param>
        internal override void Sync(SyncData syncDataItem)
        {
            // 执行自身同步
            SyncSelf(syncDataItem);

            // 执行子任务同步
            var subTasks = this.SubTasks;
            if (subTasks != null && subTasks.Count > 0)
            {
                subTasks.ForEach(subTask => subTask.Sync(syncDataItem));
            }
        }

        #region Private Method

        /// <summary>
        /// 执行自身任务（取出对应缓存，比较时间戳，若时间戳已过期，则刷新缓存）
        /// </summary>
        /// <param name="syncDataItem"></param>
        private void SyncSelf(SyncData syncDataItem)
        {
            string key = syncDataItem.Key;

            string timestamp = syncDataItem.TimeStamp;
            if (string.IsNullOrEmpty(timestamp))
            {
                // 如果时间戳为Null, 直接刷缓存
                RefreshCachedItems(key);
                return;
            }

            DateTime syncTime;
            bool isTimestampValid = DateTime.TryParse(timestamp, out syncTime);
            if (!isTimestampValid)
            {
                // 如果时间戳转换失败, 直接退出, 不刷缓存
                return;
            }

            var cachedValues = GetCachedValues(key);
            if (cachedValues != null && cachedValues.Count > 0)
            {
                foreach (var cachedValue in cachedValues)
                {
                    if (null == cachedValue)
                    {
                        continue;
                    }

                    // 判断并刷新缓存
                    if (ShouldRefreshCache(cachedValue, syncTime))
                    {
                        RefreshCachedItems(key);
                    }
                }
            }
        }

        /// <summary>
        /// 判断缓存是否需要刷新
        /// </summary>
        /// <param name="cachedObject"></param>
        /// <param name="syncTime"></param>
        /// <returns></returns>
        private bool ShouldRefreshCache(object cachedObject, DateTime syncTime)
        {
            bool shouldRefreshCache = false;

            // 检查缓存对象是否直接包含有效的时间戳属性
            DateTime cacheTimestamp;
            bool hasValidTimestamp = ExtractCacheTimestamp(cachedObject, out cacheTimestamp);

            if (hasValidTimestamp)
            {
                // 如果同步的时间戳存在且大于缓存的时间戳，则标记刷新缓存
                shouldRefreshCache = syncTime > cacheTimestamp;
            }

            return shouldRefreshCache;
        }

        /// <summary>
        /// 提取缓存刷新时间
        /// </summary>
        /// <param name="cachedObject"></param>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        private bool ExtractCacheTimestamp(object cachedObject, out DateTime timestamp)
        {
            bool hasValidTimestamp = false;
            timestamp = DateTime.MinValue;
            if (cachedObject != null)
            {
                var type = cachedObject.GetType();
                var cacheObjectTypeName = type.FullName;
                PropertyInfo propertyInfo = null;
                if (!_htTimestampProperties.Contains(cacheObjectTypeName))
                {
                    propertyInfo = type.GetProperty(TimestampPropery);
                    _htTimestampProperties[cacheObjectTypeName] = propertyInfo;
                }
                else
                {
                    propertyInfo = (PropertyInfo)_htTimestampProperties[cacheObjectTypeName];
                }

                timestamp = (DateTime)propertyInfo.GetValue(cachedObject, null);
                hasValidTimestamp = true;
            }

            return hasValidTimestamp;
        }

        #endregion
    }
}
