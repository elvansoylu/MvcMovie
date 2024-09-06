using Microsoft.AspNetCore.Mvc;
using MvcMovie.Helper;
using MvcMovie.Models;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index(int? id)
    {
        if (id == null)
        {
            return "This is my default action...";
        }
        else
        {
            return "This is my default action..." + id;
        }
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    //public string Welcome(string name, int numTimes = 1)
    //{
    //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    //}

    public ViewResult Welcome()
    {
        ViewData["Bilgi"] = "Adana";
        ViewData["Fiyat"] = 200;
        return View(); 
    }

    public ViewResult Bilgi(int id)
    {
        VeriIslem vi=new VeriIslem();
        Yemek ymk=vi.YemekGetir(id);

        if (ymk != null)
        {
            ViewData["Bilgi"] = ymk.Ad;
            ViewData["Fiyat"] = ymk.Fiyat;
        }
        else
        {
            ViewData["Bilgi"] = null;
        }
        return View();
    }
}
