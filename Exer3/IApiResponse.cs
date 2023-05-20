using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3
{
    internal interface IApiResponse
    {
        [Get("/v6/134725f7b8155064aa5354f8/latest/USD")]
        Task<ApiResponse> GetDataAsync();
    }
}
