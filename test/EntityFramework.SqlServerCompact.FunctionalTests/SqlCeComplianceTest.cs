﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Query;

namespace Microsoft.EntityFrameworkCore
{
    public class SqlCeComplianceTest : RelationalComplianceTestBase
    {
        protected override ICollection<Type> IgnoredTestBases { get; } = new HashSet<Type>
        {
            typeof(AsyncFromSqlSprocQueryTestBase<>),
            typeof(FromSqlSprocQueryTestBase<>),
            typeof(SqlExecutorTestBase<>),
            //No roundtrip of GUIDs with SQL CE
            typeof(StoreGeneratedFixupTestBase<>),

            //TODO ErikEJ await fixes to base test, see #513
            typeof(WithConstructorsTestBase<>),
            typeof(QueryFilterFuncletizationTestBase<>),
        };

        protected override Assembly TargetAssembly { get; } = typeof(SqlCeComplianceTest).Assembly;
    }
}
