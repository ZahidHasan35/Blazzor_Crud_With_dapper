#pragma checksum "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\Pages\ListEmployees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69c5097792e8ed778cea8bd65318f13352931a26"
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
#line 1 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\Pages\ListEmployees.razor"
using BlazorDapperCrud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listemployees")]
    public partial class ListEmployees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "H:\Core Tutorial\BlazorDapperCrud\BlazorDapperCrud\Pages\ListEmployees.razor"
       
    IEnumerable<EmployeeModel> employees;

    protected override async Task OnInitializedAsync()
    {
        employees = await EmployeeService.GetEmployees();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeService EmployeeService { get; set; }
    }
}
#pragma warning restore 1591
