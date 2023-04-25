using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers;



[ApiController]
[Route("[controller]")]
public class UrlController : ControllerBase
{
    // GET
    public IEnumerable<string> Get()
    {

        IList<string> urls = new List<string>();
        urls.Add("http://google");
        urls.Add("http://youtube");
        
        return urls.ToArray();
    }
}