// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ExpenseTracker.Client.Components.Income
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\_Imports.razor"
using ExpenseTracker.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\_Imports.razor"
using ExpenseTracker.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Income\AddIncome.razor"
using ExpenseTracker.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addincome")]
    public partial class AddIncome : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Income\AddIncome.razor"
            
    Income income = new Income();
    protected async Task CreateIncome()
    {
        await Http.PostAsJsonAsync("/api/Expense/CreateIncome", income);
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
