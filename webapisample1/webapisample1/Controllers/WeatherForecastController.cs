using Microsoft.AspNetCore.Mvc;
using webapisample1.Models;

namespace webapisample1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        static List<string> names = new List<string>();
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly Itimerclass _timer;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,Itimerclass timerclass)
        {
            _timer = timerclass;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<string> Get(int n)
        {
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
            //List<string> names= new List<string>();
            //names.Add("s");
            //names.Add("sha");
            //names.Add("sa");
            //names.Add("sj");
            //names.Add(employee()
            //    {
            //    id=1,
            //        name="asd",

            //});
            return names;

        }
        [HttpPost]
        public IActionResult Post(string name)
        {
            names.Add(name);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(string name, string newName)
        {

            if (names.Count > 0)
            {
                int index = -1;
                //for (int i = 0; i < names.Count; i++)
                //{
                //    if (names[i] == name)
                //    {
                //        index = i;
                //        break;
                //    }
                //}
                foreach(string s in names)
                {
                    if (s == name){
                        index = names.IndexOf(s);
                        break;
                    }
                }
                if (index!=-1)
                      names[index] = newName;
                else
                    return BadRequest("Name not found");
            }
            else
            {
                return BadRequest("Name is empty");
            }
            return Ok(names);

        }
        [HttpDelete]
        public IActionResult Delete(string name)
        {
            if (names.Count > 0)
            {
                foreach (string s in names)
                {
                    if (s == name)
                    {
                        names.Remove(s);
                        return Ok("deleted");

                    }
                    else
                    {
                        return BadRequest();
                    }
                }
            }
            
             return NotFound("no records");
            

        }
    }
}