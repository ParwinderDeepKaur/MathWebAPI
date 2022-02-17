using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using MathLibrary;
using System.Threading.Tasks;

namespace MathApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MathController : ControllerBase
    {

        private readonly ILogger<MathController> _logger;

        public MathController(ILogger<MathController> logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// Add function
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(int value1, int value2)
        {

            MathLogic add = new MathLogic();

            return add.Add(value1, value2);
        }


    }
}
