#pragma checksum "e:\Blazor\ShootingRange\ShootingRange.Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3064c3e66db652413f79e6940048074bbb24cdf4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ShootingRange.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "e:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "e:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "e:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "e:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "e:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using ShootingRange.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "e:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using ShootingRange.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "e:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "e:\Blazor\ShootingRange\ShootingRange.Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
