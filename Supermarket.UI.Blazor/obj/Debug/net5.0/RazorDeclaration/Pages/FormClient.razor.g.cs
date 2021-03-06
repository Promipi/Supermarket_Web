// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/clientForm")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/clientForm/{id:int}")]
    public partial class FormClient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "G:\Programacion_General\Proyectos de programacion\Supermarket_Web\Supermarket.UI.Blazor\Pages\FormClient.razor"
       
    [Parameter] public int id { get; set; }

    Client client = new Client();

    protected async override Task OnInitializedAsync()
    {
        if(id != 0) //cargaremos los datos
        {

            client = (await httpClient.GetFromJsonAsync<Response<Client>>($"/api/Clients?id={id}") ).Content.First();
            if (client.Id != 0) await InvokeAsync(StateHasChanged);
        }
        else
        {
            client.Name = ""; client.PhoneNumber = null; client.Ruc = null; client.Gmail = "";
        }
    }

    public async void SaveClient()
    {
        if(id == 0) //siginiica que crearemos un cliente
        {
            await httpClient.PostAsJsonAsync<Client>("/api/Clients/add", client); //enviamos el cliente
        }
        else
        {
            await httpClient.PutAsJsonAsync<Client>("/api/Clients", client); //actualizamos al cliente
        }
        Navigation.NavigateTo("/clientsList");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
