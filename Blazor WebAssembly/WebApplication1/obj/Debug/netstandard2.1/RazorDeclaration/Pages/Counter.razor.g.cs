#pragma checksum "c:\Users\jhonn\Documents\Personal Repositories\Blazor\Blazor WebAssembly\WebApplication1\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30ed77e1edd51ee75c97a34936367d74e1d45dbb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\jhonn\Documents\Personal Repositories\Blazor\Blazor WebAssembly\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\jhonn\Documents\Personal Repositories\Blazor\Blazor WebAssembly\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\jhonn\Documents\Personal Repositories\Blazor\Blazor WebAssembly\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\jhonn\Documents\Personal Repositories\Blazor\Blazor WebAssembly\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\jhonn\Documents\Personal Repositories\Blazor\Blazor WebAssembly\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\jhonn\Documents\Personal Repositories\Blazor\Blazor WebAssembly\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\jhonn\Documents\Personal Repositories\Blazor\Blazor WebAssembly\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "c:\Users\jhonn\Documents\Personal Repositories\Blazor\Blazor WebAssembly\WebApplication1\Pages\Counter.razor"
       
    private int currentCount = 0;

    [Parameter]
    public int IncrementAmount { get; set; } = 1;

    private void IncrementCount()
    {
        currentCount += IncrementAmount;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
