// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RDDIntegrationView.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\_Imports.razor"
using RDDIntegrationView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\_Imports.razor"
using RDDIntegrationView.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\Pages\SetUpMandate.razor"
using RDDIntegration.Service.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\Pages\SetUpMandate.razor"
using RDDIntegration.Service.RDDIServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\Pages\SetUpMandate.razor"
using RDDIntegration.Models.Request.SetUpMandate;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/setup")]
    public partial class SetUpMandate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\SDSD DEV7\source\repos\RDDIntegrationView\Pages\SetUpMandate.razor"
       
	private async Task SetupMandate()
	{
		var result = await rdd.SetUpManDatee(req);
		if (result.statuscode.Equals(true))
			navigationManager.NavigateTo("/");
		await JSRuntime.InvokeVoidAsync("alert", "");
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MandateSetUpRequest req { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RDDIService rdd { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRDDIService rddiService { get; set; }
    }
}
#pragma warning restore 1591