#pragma checksum "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcf8da19eda9e88b8131bafb553e1bd51635e724"
// <auto-generated/>
#pragma warning disable 1591
namespace OrderManagement.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\_Imports.razor"
using OrderManagement.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\_Imports.razor"
using OrderManagement.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
using OrderManagement.UI.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
using OrderManagement.UI.Services.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/supplier")]
    public partial class Supplier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "width", "100%");
            __builder.AddAttribute(3, "style", "background:#05163D;color:honeydew");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "<td width=\"20\"></td>\r\n        ");
            __builder.AddMarkupContent(6, "<td><h2>Create Supplier</h2></td>\r\n        <td></td>\r\n       \r\n            ");
            __builder.OpenElement(7, "td");
            __builder.AddAttribute(8, "align", "right");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-info");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
                                                        AddNewSupplier

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Add new supplier");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n<hr>");
#nullable restore
#line 51 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
 if ((List<SupplierDto>)allSupplier.Data==null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<h3> No Supplier Found </h3>\r\n    <div class=\"spinner\"></div>");
#nullable restore
#line 55 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<h3>Suppliers List</h3>\r\n    ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table");
            __builder.AddMarkupContent(18, @"<thead><tr><th hidden=""hidden"">Supplier Id</th>
                <th>Supplier Name</th>
                <th>Address 1</th>
                <th>Adress 2</th>
                <th>State</th>
                <th>City</th>
                <th>Action</th></tr></thead>
        ");
            __builder.OpenElement(19, "tbody");
#nullable restore
#line 72 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
             foreach (var supplierDto in allSupplier.Data)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "tr");
            __builder.OpenElement(21, "td");
            __builder.AddAttribute(22, "hidden", "hidden");
#nullable restore
#line 75 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
__builder.AddContent(23, supplierDto.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
#nullable restore
#line 76 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
__builder.AddContent(26, supplierDto.SupplierName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
#nullable restore
#line 77 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
__builder.AddContent(29, supplierDto.AddressLine1);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
#nullable restore
#line 78 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
__builder.AddContent(32, supplierDto.AddressLine2);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
#nullable restore
#line 79 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
__builder.AddContent(35, supplierDto.StateDto.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
#nullable restore
#line 80 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
__builder.AddContent(38, supplierDto.CityDto.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "href", "/supplier/edit/" + (
#nullable restore
#line 83 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
                                                  supplierDto.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "class", "btn btn-outline-dark");
            __builder.AddAttribute(44, "role", "button");
            __builder.AddMarkupContent(45, "\r\n                            Edit\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                      ");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
                                      async () => await Delete((int)supplierDto.Id,supplierDto.SupplierName)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "class", "btn btn-outline-danger");
            __builder.AddAttribute(50, "role", "button");
            __builder.AddMarkupContent(51, "\r\n                            Delete\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 92 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 95 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, @"<style type=""text/css"">
    .spinner {
    border: 16px solid silver;
    border-top: 16px solid #337AB7;
    border-radius: 50%;
    width: 80px;
    height: 80px;
    animation: spin 700ms linear infinite;
    top: 40%;
    left: 55%;
    position: absolute;
}

@keyframes spin {
    0% {
        transform: rotate(0deg)
    }

    100% {
        transform: rotate(360deg)
    }
}
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\Projects\InterviewProjects\OrderManagement\OrderManagement.UI\Pages\Supplier.razor"
       
    private ResponseDto<List<SupplierDto>> allSupplier=new();
    protected override async Task OnInitializedAsync()
    {
        allSupplier = await _supplierService.GetAll();
        //await base.OnInitializedAsync();
    }
    private async Task Delete(int id,string supplierName)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure do you want to delete? "+supplierName+" supplier");
        if (confirmed)
        {
            var result = await _supplierService.Delete(id);
            if (result)
            {
                allSupplier = await _supplierService.GetAll();
            }
        }
    }
    private void AddNewSupplier()
    {
        NavManager.NavigateTo("/supplier/add");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICityService _cityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStateService _stateService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISupplierService _supplierService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
