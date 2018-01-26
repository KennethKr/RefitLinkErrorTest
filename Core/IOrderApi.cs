using System;
using System.Threading;
using System.Threading.Tasks;
using Refit;

namespace Core
{
    public interface IOrderApi
    {
        [Get("/")]
        Task<string> List(CancellationToken? token);
    }
}
