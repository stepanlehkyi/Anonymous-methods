#pragma checksum "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\Tasks\Greetings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3448975d28545c0c033a4d5ec1850062ef84fb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Sprint_13_Tasks.Pages.Tasks.Pages_Tasks_Greetings), @"mvc.1.0.razor-page", @"/Pages/Tasks/Greetings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3448975d28545c0c033a4d5ec1850062ef84fb1", @"/Pages/Tasks/Greetings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9116d78a03d8f95b219fa4edfa0e76243e8f13e0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Tasks_Greetings : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3448975d28545c0c033a4d5ec1850062ef84fb13141", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 10 "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\Tasks\Greetings.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3448975d28545c0c033a4d5ec1850062ef84fb14376", async() => {
                WriteLiteral("\r\n\r\n    <h1>Greetings</h1>\r\n    <p>The value of myMessage is: ");
#nullable restore
#line 15 "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\Tasks\Greetings.cshtml"
                             Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n    <p>The greeting is: ");
#nullable restore
#line 17 "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\Tasks\Greetings.cshtml"
                   Write(ViewData["Greeting"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> \r\n\r\n    <p>Here in Ukraine: ");
#nullable restore
#line 19 "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\Tasks\Greetings.cshtml"
                   Write(DateTime.Now.DayOfWeek);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n    <p>We wish you:  </p>\r\n\r\n    <p>Today is ");
#nullable restore
#line 23 "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\Tasks\Greetings.cshtml"
           Write(DateTime.Now.DayOfWeek);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n    <table style=\" border: 1px solid black; \">\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Value</th>\r\n        </tr>\r\n        <tr>\r\n            <td>Day</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\Tasks\Greetings.cshtml"
           Write(DateTime.Now.Day);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Hour</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\Tasks\Greetings.cshtml"
           Write(DateTime.Now.Hour);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Minute</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\Tasks\Greetings.cshtml"
           Write(DateTime.Now.Minute);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Second</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\Stepan.Lehkyi\source\repos\Sprint_13_Tasks\Sprint_13_Tasks\Pages\Tasks\Greetings.cshtml"
           Write(DateTime.Now.Second);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n      \r\n\r\n    </table>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sprint_13_Tasks.Pages.Tasks.GreetingsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sprint_13_Tasks.Pages.Tasks.GreetingsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sprint_13_Tasks.Pages.Tasks.GreetingsModel>)PageContext?.ViewData;
        public Sprint_13_Tasks.Pages.Tasks.GreetingsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
