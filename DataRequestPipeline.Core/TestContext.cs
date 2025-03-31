﻿namespace DataRequestPipeline.Core
{
    /// <summary>
    /// Context for the Cleanup stage.
    /// </summary>
    public class TestContext : DataRequestBaseContext
    {
        // Add cleanup-specific properties if needed.
        public bool TestsPassed;

        public List<Dictionary<string, object>> TestsResults;
    }
}
