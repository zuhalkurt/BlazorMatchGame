#pragma checksum "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84f5b3ffecbc019b21554c4fc67da4129d3d2dd7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMatchGame.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using BlazorMatchGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using BlazorMatchGame.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    .container {\n        width: 400px;\n    }\n\n    button {\n        width: 100px;\n        height: 100px;\n        font-size: 50px;\n    }\n</style>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
#nullable restore
#line 17 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
         foreach (var animal in shuffleAnimals)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-3");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "type", "button");
            __builder.AddAttribute(9, "class", "btn btn-outline-dark");
            __builder.OpenElement(10, "h1");
#nullable restore
#line 21 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
__builder.AddContent(11, animal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/Users/zoe/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
       
    List<string> animalEmoji = new List<string>()
{
        "🐶", "🐶",
        "🐺", "🐺",
        "🐮", "🐮",
        "🦊", "🦊",
        "🐱", "🐱",
        "🦁", "🦁",
        "🐯", "🐯",
        "🐹", "🐹",
    };

    List<string> shuffleAnimals = new List<string>();

    protected override void OnInitialized()
    {
        SetUpGame();
    }

    private void SetUpGame()
    {
        Random random = new Random();
        shuffleAnimals = animalEmoji
            .OrderBy(item => random.Next())
            .ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
