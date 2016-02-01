﻿using Microsoft.EntityFrameworkCore.FunctionalTests;

namespace ErikEJ.Data.Entity.SqlServerCe.FunctionalTests
{
    public class GraphUpdatesWithIdentitySqlCeTest : GraphUpdatesSqlCeTestBase<GraphUpdatesWithIdentitySqlCeTest.GraphUpdatesWithIdentitySqlCeFixture>
    {
        public GraphUpdatesWithIdentitySqlCeTest(GraphUpdatesWithIdentitySqlCeFixture fixture)
            : base(fixture)
        {
        }

        public class GraphUpdatesWithIdentitySqlCeFixture : GraphUpdatesSqlCeFixtureBase
        {
            protected override string DatabaseName => "GraphIdentityUpdatesTest";
        }
    }
}
