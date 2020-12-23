using Microsoft.AspNetCore.Mvc;
using Supermarket.SERVER.Data;
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
        [HttpGet]
        public IActionResult GetAllArticles(int? id,int? code)
        {
            Response<Article> response = new Response<Article>();
            if(id!=null)    response = ArticlesRepository.GetArticleById(id); //obtenemos un articulo  mediante su id
            if(code!=null)  response = ArticlesRepository.GetArticleByCode(code); //obtenemos un articulo mediante su codigo
            else            response = ArticlesRepository.GetAllArticles(); //obtenemos todos los articulos    



            if (response.Sucess) return Ok(response);
            else                 return Problem(response.Message); //si ocurrio un error
        }
        [HttpPost("add")]
        public IActionResult InsertArticle(Article newArticle) //para introducir un nuevo articulo
        {
            var response = ArticlesRepository.InsertArticle(newArticle);
            if (response.Sucess) return Ok(response);
            else                 return Problem(response.Message);
        }
        [HttpPut]
        public IActionResult UpdateArticle(Article article) //api/articles
        {
            var response = ArticlesRepository.UpdateArticle(article);
            if (response.Sucess) return Ok(response);
            else                 return Problem(response.Message);
        }
        [HttpDelete]
        public IActionResult DeleteArticle(int id)
        {
            var response = ArticlesRepository.DeleteArticle(id); //eliminamos el articulo mediante su id
            if (response.Sucess) return Ok(response);
            else                 return Problem(response.Message);
        }
         
    }
}
