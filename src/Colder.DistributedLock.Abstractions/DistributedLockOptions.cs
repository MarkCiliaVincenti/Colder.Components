﻿namespace Colder.DistributedLock.Abstractions
{
    /// <summary>
    /// 分布式锁选项
    /// </summary>
    public class DistributedLockOptions
    {
        /// <summary>
        /// 锁类型
        /// </summary>
        public LockTypes LockType { get; set; }
    }
}
