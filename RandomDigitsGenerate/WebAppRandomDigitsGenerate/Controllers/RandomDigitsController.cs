using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRandomDigitsGenerate.Controllers
{
    [ApiController]
    [Route("random-digits")]
    public class RandomDigitsController : ControllerBase
    {
        private const string CacheKey = "RandomDigitsStore";

        private readonly ILogger<RandomDigitsController> _logger;
        private IMemoryCache _memoryCache;
        private List<int> _randomDigitsList = new List<int>();
        public RandomDigitsController(ILogger<RandomDigitsController> logger, IMemoryCache memoryCache)
        {
            _logger = logger;

            _memoryCache = memoryCache;
        }
        public List<int> RandomDigitsList
        {
            get
            {
                return _randomDigitsList;
            }
        }

        [HttpPost]
        public IActionResult TakeOutRandomDigitsList(List<int> list)
        {
            _randomDigitsList = list;

            if (RandomDigitsList.Count == 0)
            {
                return NotFound("Нет данных");
            }

            _memoryCache.Set(CacheKey, RandomDigitsList);
            return Ok();
        }
        [HttpGet]
        public IEnumerable<int> GetRandomDigitsList()
        {
            return (List<int>)_memoryCache.Get(CacheKey);
        }
    }
}
