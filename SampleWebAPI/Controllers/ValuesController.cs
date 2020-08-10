using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Models;
using SampleWebAPI.Repository;

namespace SampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICommonRepository commonRepository;
        public ValuesController(ICommonRepository _commonRepository)
        {
            commonRepository = _commonRepository;
        }
        [HttpPost("ProcessData")]
        public ApiResultBase<InputData> ProcessData([FromForm]InputData inputData)
        {
            var result = new ApiResultBase<InputData> { IsSuccess = true };
            if (ModelState.IsValid)
            {
                result.Result = commonRepository.ReverseTheResponse(inputData);
                result.Message = "Data Processed Sucessfully";
            }
            return result;
        }
    }
}
