using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using System;

namespace Lab2TRKVD.Controllers
{
    
    public class HomeController : Controller
    {
        //1
        //public IActionResult Index(string name)   
        //{
        //    return Content($"Hello, {name}!");    ///Home/Index?name=Bilbo    
        //}
        //2
        //public IActionResult Index(string name, int age)
        //{
        //    return Content($"Person: {name} {age} y.o!");   ///Home/Index?name=Bilbo&age=20
        //}
        //3
        //[HttpGet]
        //public async Task Index()
        //{
        //    string content = @"<form method='post'>
        //        <label>Name:</label><br />
        //        <input name='name' /><br />
        //        <label>Age:</label><br />
        //        <input type='number' name='age' /><br />
        //        <input type='submit' value='Send' />
        //        </form>";
        //        Response.ContentType = "text/html;charset=utf-8";
        //        await Response.WriteAsync(content);
        //}
        //[HttpPost]
        //public string Index(string name, int age) => $"{name}, {age} y.o";
        //4
        public async Task Index()
        {
            string form = @"<form method='post'>
                <p><input name='names[3]' /></p>
                <p><input name='names[2]' /></p>
                <p><input name='names[1]' /></p>
                <p><input name='names[0]' /></p>
                <input type='submit' value='Send' />
                </form>";
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync(form);
        }
        [HttpPost]
        public string Index(string[] names)
        {
            string result = "";
            foreach (string name in names)
            {
                result = $"{result} {name}";
            }
            return result;
        }
    }
}

