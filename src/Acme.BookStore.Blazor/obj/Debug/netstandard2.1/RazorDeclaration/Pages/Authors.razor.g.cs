#pragma checksum "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/Pages/Authors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d6edbe7fd65d0f3442ff750a4c3b0fb5c8cd41d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Acme.BookStore.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using Volo.Abp.AspNetCore.Components.WebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using Acme.BookStore.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using Blazorise.DataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using Volo.Abp.BlazoriseUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/_Imports.razor"
using Volo.Abp.BlazoriseUI.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/Pages/Authors.razor"
using Acme.BookStore.Authors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/Pages/Authors.razor"
using Acme.BookStore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/Pages/Authors.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/Pages/Authors.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/kynt/develop/projects/netcore-angular/abp-samples-all/abp-samples/BookStore-Blazor-EfCore/src/Acme.BookStore.Blazor/Pages/Authors.razor"
using Volo.Abp.ObjectMapping;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors")]
    public partial class Authors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IObjectMapper ObjectMapper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUiMessageService UiMessageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorizationService AuthorizationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<BookStoreResource> L { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorAppService AuthorAppService { get; set; }
    }
}
#pragma warning restore 1591
