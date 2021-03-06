﻿using MVS.Template.CSharp.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace MVS.Template.CSharp.FunctionalTest.Setup
{
    public class ScenarioBase
    {
        private const string ApiUrlBase = "api/v1/Solve";

        public static IWebHostBuilder BuildWebHost() =>
            Program.CreateWebHostBuilder(null);

        public TestServer CreateServer()
        {
            return new TestServer(BuildWebHost());
        }

        public TestServer CreateServer(IWebHostBuilder buildWebHost)
        {
            return new TestServer(buildWebHost);
        }

        public static class Post
        {
            public static string Solve()
            {
                return $"{ApiUrlBase}";
            }
        }
    }
}
