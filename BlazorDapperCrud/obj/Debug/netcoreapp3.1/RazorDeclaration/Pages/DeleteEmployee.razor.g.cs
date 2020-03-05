#pragma checksum "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\Pages\DeleteEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d95135cd321bbd21a0cd7663ec54bef44fab25"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDapperCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using BlazorDapperCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using BlazorDapperCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\Pages\DeleteEmployee.razor"
using BlazorDapperCrud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deleteemployee/{id:int}")]
    public partial class DeleteEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\Pages\DeleteEmployee.razor"
       

    [Parameter]
    public int id { get; set; }
    EmployeeModel employee = new EmployeeModel();

    protected override async Task OnInitializedAsync()
    {
        employee = await EmployeeService.SingleEmployee(id);
    }

    protected async Task Delete()
    {
        await EmployeeService.DeleteEmployee(id);
        NavigationManager.NavigateTo("listemployees");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("listemployees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeService EmployeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
