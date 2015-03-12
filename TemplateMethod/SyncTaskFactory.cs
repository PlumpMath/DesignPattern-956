using System;

namespace TerrLuo.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 缓存同步任务工厂
    /// </summary>
    internal class SyncTaskFactory
    {
        #region Task Name

        /// <summary>
        /// 任务名称前缀
        /// </summary>
        private const string TaskNamePrefix = "ShoppingService.";

        private const string TaskProductVisa            = TaskNamePrefix + "ProductVisaSync";
        private const string TaskProductImage           = TaskNamePrefix + "ProductImageSync";
        private const string TaskProductVideo           = TaskNamePrefix + "ProductVideoSync";
        private const string TaskProductGroup           = TaskNamePrefix + "ProductGroupSync";
        private const string TaskProductLeader          = TaskNamePrefix + "ProductLeaderSync";
        private const string TaskProductTagID           = TaskNamePrefix + "ProductTagIDSync";
        private const string TaskProductTiming          = TaskNamePrefix + "ProductTimingSync";
        private const string TaskProductMinPrice        = TaskNamePrefix + "ProductMinPriceSync";
        private const string TaskProductSchedule        = TaskNamePrefix + "ProductScheduleSync";
        private const string TaskProductPromotion       = TaskNamePrefix + "ProductPromotionSync";
        private const string TaskProductBasicInfo       = TaskNamePrefix + "ProductBasicInfoSync";
        private const string TaskProductRiskSchedule    = TaskNamePrefix + "ProductRiskScheduleSync";
        private const string TaskProductChildrenPrice   = TaskNamePrefix + "ProductChildrenPriceSync";

        #endregion

        /// <summary>
        /// 简单工厂，创建同步任务
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        internal static SyncTask CreateTask(string task)
        {
            switch (task)
            {
                case TaskProductImage:
                    return ProductImageSyncTask.Instance;

                /*
                 
                case TaskProductVisa:
                    return ProductVisaSyncTask.Instance;

                case TaskProductVideo:
                    return ProductVideoSyncTask.Instance;

                case TaskProductGroup:
                    return ProductGroupSyncTask.Instance;

                case TaskProductLeader:
                    return ProductLeaderSyncTask.Instance;

                case TaskProductTagID:
                    return ProductTagIDSyncTask.Instance;

                case TaskProductTiming:
                    return ProductTimingSyncTask.Instance;

                case TaskProductSchedule:
                    return ProductScheduleSyncTask.Instance;

                case TaskProductPromotion:
                    return ProductPromotionSyncTask.Instance;

                case TaskProductMinPrice:
                    return ProductMinPriceSyncTask.Instance;

                case TaskProductBasicInfo:
                    return ProductBasicInfoSyncTask.Instance;

                case TaskProductRiskSchedule:
                    return ProductRiskScheduleSyncTask.Instance;

                case TaskProductChildrenPrice:
                    return ProductChildrenPriceSyncTask.Instance;
                 
                */

                default:
                    return null;
            }
        }
    }
}
