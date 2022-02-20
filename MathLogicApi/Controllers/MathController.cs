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
        private readonly MathLogic _MathLogic;
        int result;


        public MathController(ILogger<MathController> logger)
        {
            _logger = logger;
            _MathLogic = new MathLogic();
            result = 0;
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
            return _MathLogic.Add(value1, value2);
        }


        /// <summary>
        /// Subtract function
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        [HttpPost]
        public int Subtract(int value1, int value2)
        {
            return _MathLogic.Subtract(value1, value2);
        }

        /// <summary>
        /// Multiply function
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        [HttpPost]
        public int Multiply(int value1, int value2)
        {
            return _MathLogic.Multiply(value1, value2);
        }

        /// <summary>
        /// Division Function
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        [HttpPost]
        public object Division(int value1, int value2)
        {
            
            try
            {
                result = _MathLogic.Division(value1, value2);
            }
            catch (DivideByZeroException e)
            {
                return BadRequest(error: e.Message);
            }

            return _MathLogic.Division(value1, value2).ToString();
        }



    }
}
