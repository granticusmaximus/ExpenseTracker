#pragma checksum "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3643ae06cdaf76936093f6a0ebfe2e54e369be8e"
// <auto-generated/>
#pragma warning disable 1591
namespace ExpenseTracker.Client.Components.Expense
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
#line 3 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
using ExpenseTracker.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/expenses")]
    public partial class ExpenseList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "center");
            __builder.AddMarkupContent(1, "<h1>Expenses</h1>\r\n    ");
            __builder.OpenElement(2, "p");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-outline-success");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
                                                          _ => OpenDialog()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "<span class=\"oi oi-clipboard\" aria-hidden=\"true\">Add New Expense</span>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 11 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
     if (expenses == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>ID</th>\r\n                    <th>Name</th>\r\n                    <th>Amount</th></tr></thead>\r\n            ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 26 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
                 foreach (var expense in expenses)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 29 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
                             expense.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 30 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
                             expense.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 31 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
                             expense.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", "/editexpense/" + (
#nullable restore
#line 33 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
                                                   expense.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "  |\r\n                            ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", "/delete/" + (
#nullable restore
#line 34 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
                                              expense.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.OpenComponent<MatBlazor.MatDialog>(31);
            __builder.AddAttribute(32, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
                          dialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dialogIsOpen = __value, dialogIsOpen))));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatDialogTitle>(35);
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, "Add New Income");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(39);
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<ExpenseTracker.Client.Components.Expense.AddExpense>(41);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogActions>(43);
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatButton>(45);
                    __builder3.AddAttribute(46, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
                            OkClose

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(48, "Close");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "\\Mac\Home\Desktop\Dev\Blazor\ExpenseTracker\ExpenseTracker\Client\Components\Expense\ExpenseList.razor"
       
    Expense[] expenses;
    bool dialogIsOpen = false;

    protected override async Task OnInitializedAsync()
    {
        expenses = await Http.GetFromJsonAsync<Expense[]>("api/Expense/GetExpenses");
    }

    void OpenDialog()
    {
        dialogIsOpen = true;
    }

    void OkClose()
    {
        dialogIsOpen = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
