<<<<<<< HEAD
#pragma checksum "E:\Blazor\ShootingRange\ShootingRange.Client\Pages\LoadingBackground.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be450c4fcfc5f9994e20dafe1645a596e11e2f1a"
=======
#pragma checksum "C:\Users\kenabrus\Desktop\Blazor\ShootingRange\ShootingRange.Client\Pages\LoadingBackground.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be450c4fcfc5f9994e20dafe1645a596e11e2f1a"
>>>>>>> 22b4480249bd0ad61ca7e936bb48b9a1e2c5bd6c
// <auto-generated/>
#pragma warning disable 1591
namespace ShootingRange.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using ShootingRange.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using ShootingRange.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class LoadingBackground : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"triangle-container\">\r\n    <div class=\"triangles\">\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 6 "E:\Blazor\ShootingRange\ShootingRange.Client\Pages\LoadingBackground.razor"
 if (ShowLogoBox)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "loading-container");
            __builder.AddMarkupContent(4, "\r\n        <img src=\"/images/blazorboilerplate.svg\" style=\"width:100px;\"><br>\r\n        \r\n        ");
            __builder.AddContent(5, 
#nullable restore
#line 11 "E:\Blazor\ShootingRange\ShootingRange.Client\Pages\LoadingBackground.razor"
         ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 13 "E:\Blazor\ShootingRange\ShootingRange.Client\Pages\LoadingBackground.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "E:\Blazor\ShootingRange\ShootingRange.Client\Pages\LoadingBackground.razor"
       
    [Parameter]
    public bool ShowLogoBox { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
