#pragma checksum "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\Authentication.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "884a42883526cfb7503b9113d7200690fb770323"
// <auto-generated/>
#pragma warning disable 1591
namespace TestServelessWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using TestServelessWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using TestServelessWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\Authentication.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\Authentication.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authentication/{action}")]
    public partial class Authentication : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticatorView>(0);
            __builder.AddAttribute(1, "Action", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\Authentication.razor"
                                  Action

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "LogOut", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 12 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\Authentication.razor"
          
            var authority = (string)Configuration["Auth0:Authority"];
            var clientId = (string)Configuration["Auth0:ClientId"];

             Navigation.NavigateTo($"{authority}/v2/logout?client_id={clientId}");
        

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\Authentication.razor"
      
    [Parameter] public string Action { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration Configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
