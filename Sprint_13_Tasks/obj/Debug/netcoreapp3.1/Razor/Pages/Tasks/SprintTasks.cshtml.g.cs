#pragma checksum "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\Tasks\SprintTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6f587b1d1c346aca3bd76c8a881bca34ce6ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Sprint_13_Tasks.Pages.Tasks.Pages_Tasks_SprintTasks), @"mvc.1.0.razor-page", @"/Pages/Tasks/SprintTasks.cshtml")]
namespace Sprint_13_Tasks.Pages.Tasks
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\_ViewImports.cshtml"
using Sprint_13_Tasks;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6f587b1d1c346aca3bd76c8a881bca34ce6ca6", @"/Pages/Tasks/SprintTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9116d78a03d8f95b219fa4edfa0e76243e8f13e0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Tasks_SprintTasks : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\Tasks\SprintTasks.cshtml"
  
    ViewData["Title"] = "Sprint 13 - ViewTask";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<ul>
    <li><a href=""/Tasks/Greetings/"">Greetings</a></li>
    <li><a href=""/Tasks/ProductInfo"">Product</a></li>
    <li><a href=""contact.asp"">Supermarkets</a></li>
    <li><a href=""about.asp"">Shopping list</a></li>
    <li><a href=""about.asp"">Shopping cart</a></li>
</ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sprint_13_Tasks.Pages.SprintTasksModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sprint_13_Tasks.Pages.SprintTasksModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sprint_13_Tasks.Pages.SprintTasksModel>)PageContext?.ViewData;
        public Sprint_13_Tasks.Pages.SprintTasksModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
