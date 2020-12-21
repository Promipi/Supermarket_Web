using Microsoft.AspNetCore.Mvc;
using Supermarket.SERVER.Models;
using Supermarket.SERVER.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.SERVER.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticlesController : Controller
    {
        
        [HttpPost("add")]
        public IActionResult InsertArticle(Article newArticle) //para introducir un nuevo articulo
        {
            return Ok(ArticlesRepository.InsertArticle(newArticle));
        }
        [HttpGet]
        public IActionResult GetAllArticles()
        {
            return Ok(ArticlesRepository.GetAllArticles() );
        }
        [HttpPut]
        public IActionResult UpdateArticle(Article article) //api/articles
        {
            return Ok(ArticlesRepository.UpdateArticle(article));  //actualizamos el articulo
        }
        [HttpDelete]
        public IActionResult DeleteArticle(int id)
        {
            return Ok(ArticlesRepository.DeleteArticle(id)); //eliminamos el articulo
        }
         
    }
}
