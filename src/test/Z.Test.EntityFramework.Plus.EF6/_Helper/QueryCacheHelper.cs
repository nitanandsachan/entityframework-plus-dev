﻿// Description: Entity Framework Bulk Operations & Utilities (EF Bulk SaveChanges, Insert, Update, Delete, Merge | LINQ Query Cache, Deferred, Filter, IncludeFilter, IncludeOptimize | Audit)
// Website & Documentation: https://github.com/zzzprojects/Entity-Framework-Plus
// Forum & Issues: https://github.com/zzzprojects/EntityFramework-Plus/issues
// License: https://github.com/zzzprojects/EntityFramework-Plus/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using Z.EntityFramework.Plus;

#if EFCORE
using Microsoft.Extensions.Caching.Memory;

#endif

namespace Z.Test.EntityFramework.Plus
{
    public static class QueryCacheHelper
    {
        public static long GetCacheCount()
        {
#if EF5 || EF6
            return 1; //return QueryCacheManager.Cache.GetCount();
#elif EFCORE
            return ((MemoryCache) QueryCacheManager.Cache).Count;
#endif
        }
    }
}