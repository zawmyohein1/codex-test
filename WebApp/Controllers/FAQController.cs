using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class FAQController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var faqs = new List<FaqItem>
        {
            new() { Question = "What is this site?", Answer = "A simple ASP.NET Core MVC application." },
            new() { Question = "How do I contact support?", Answer = "Use the Contact page." },
            new() { Question = "Can I leave feedback?", Answer = "Yes, visit the Feedback page." }
        };

        return View(faqs);
    }
}

