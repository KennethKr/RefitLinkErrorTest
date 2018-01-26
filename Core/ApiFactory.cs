using System;
using System.Threading;
using Refit;

namespace Core
{
    public class ApiFactory
    {
        public static string GetSomething() {
            IOrderApi api = RestService.For<IOrderApi>("http://test.no");
            return api.List(new CancellationToken()).GetAwaiter().GetResult();
        }
    }
}
