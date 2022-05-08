using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using FizzBuzz;

namespace BrianSmall.Function
{
    public static class FizzBuzzFxn
    {
        [FunctionName("FizzBuzzFxn")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            
            string name = req.Query["name"];
            string numbers = req.Query["numbers"];
            string primeQuartz = req.Query["primeQuartz"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            numbers = numbers ?? data?.numbers;
            primeQuartz = primeQuartz ?? data?.primeQuartz;

            string responseMessage = "";
            
            var fb = new FizzBuzzer();
            var s = new ViceSoftware.Services.PrimeService();
            string[] result;
            if(primeQuartz is not null && primeQuartz.ToLower() == "true"){
                result = fb.doTheFizzBuzz(numbers.Split(','), new Func<int, string>[]{s.IsPrime});
            } else {
                result = fb.doTheFizzBuzz(numbers.Split(','));
            }
            foreach(var str in result) {
                responseMessage += (str + "\n");
                Console.Write(str + "\n");
            }
            return new OkObjectResult(responseMessage);
        }
    }
}
