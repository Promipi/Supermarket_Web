#pragma checksum "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00cbe26429f219133a28926fdf5d79a8ebfc807b"
// <auto-generated/>
#pragma warning disable 1591
namespace Supermarket.UI.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using Supermarket.UI.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using Supermarket.UI.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using Supermarket.SHARED.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using Supermarket.SHARED.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using RestSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/articlesList")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/articlesList/{idOrder:int}")]
    public partial class ArticlesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Lista De Articulos</h1>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"/articleForm\" class=\"btn\" style=\"background-color:cornflowerblue\">Crear Articulo</a>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "height:620px;overflow:scroll");
#nullable restore
#line 11 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
     if (Articles.Count() != 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddAttribute(6, "border", "1");
            __builder.AddMarkupContent(7, "<tr><td style=\"background-color:dodgerblue\"><b>Familia</b></td>\r\n                <td style=\"background-color:dodgerblue\"><b>Descripcion</b></td>\r\n                <td style=\"background-color:dodgerblue\"><b>Precio</b></td></tr>");
#nullable restore
#line 19 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
             foreach (var article in Articles)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 22 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
                         article.Family

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 23 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
                         article.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 24 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
                         article.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 26 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
                         if (idOrder != 0)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", "/orderForm/" + (
#nullable restore
#line 28 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
                                                 idOrder

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 28 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
                                                          article.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "btn");
            __builder.AddAttribute(22, "style", "background-color: dodgerblue");
            __builder.AddContent(23, "Seleccionar");
            __builder.CloseElement();
#nullable restore
#line 29 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "class", "btn btn-success");
            __builder.AddAttribute(26, "href", "/articleForm/" + (
#nullable restore
#line 32 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
                                                                           article.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "btn btn-danger");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
                                                                  () => DeleteArticle(article.Id) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Eliminar");
            __builder.CloseElement();
#nullable restore
#line 34 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 41 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"


    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\ArticlesList.razor"
 
        [Parameter] public int idOrder { get; set; }
        List<Article> Articles { get; set; } = new List<Article>();

        public async void DeleteArticle(int id)
        {
            await httpClient.DeleteAsync($"api/Articles?idArticle={id}");
            var ready = await GetArticles();
            if (ready) await InvokeAsync(StateHasChanged);
        }

        public async Task<bool> GetArticles()
        {
            var response = await httpClient.GetFromJsonAsync<Response<Article>>("/api/Articles");
            Articles = response.Content;
            return true;
        }

        protected async override Task OnInitializedAsync()
        {
            bool ready = await GetArticles();
            if (ready) await InvokeAsync(StateHasChanged);
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RestClient RestClient { get; set; }
    }
}
#pragma warning restore 1591
