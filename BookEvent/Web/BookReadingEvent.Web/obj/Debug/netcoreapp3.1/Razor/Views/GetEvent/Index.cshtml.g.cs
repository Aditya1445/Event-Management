#pragma checksum "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2de2a9e77d7a42bd61858d4c8f0aed683a5351ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GetEvent_Index), @"mvc.1.0.view", @"/Views/GetEvent/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\_ViewImports.cshtml"
using BookReadingEvent.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\_ViewImports.cshtml"
using BookReadingEvent.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2de2a9e77d7a42bd61858d4c8f0aed683a5351ce", @"/Views/GetEvent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0133f9920160cf33e87e1cf2f1ee78f6f4792d4c", @"/Views/_ViewImports.cshtml")]
    public class Views_GetEvent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UpdateEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteByEventId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GetEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:30px;margin-top:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
  
    if (ViewBag.checkLayout == "Home")
    {
        Layout = "_Layout";
    }
    else
    {

        Layout = "_LayoutEvent";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3 class=\"display-4 \" style=\"text-align:center\">Event Details</h3>\r\n<hr />\r\n<div class=\"card\" style=\"width:80%; margin-bottom: 3px; align-content:center; margin-left:30px;\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 17 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\"><b>Description:-&nbsp;</b>");
#nullable restore
#line 18 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\"><b>Date:-&nbsp;</b>");
#nullable restore
#line 19 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                Write(Model.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\"><b>Duration:-&nbsp;</b>");
#nullable restore
#line 20 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                    Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" hrs</h6>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\"><b>Location:-&nbsp;</b>");
#nullable restore
#line 21 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                    Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\"><b>StartTime:-&nbsp;</b>");
#nullable restore
#line 22 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                     Write(Model.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\"><b>OtherDetails:-&nbsp;</b>");
#nullable restore
#line 23 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                        Write(Model.OtherDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\"><b>CreatedBy:-&nbsp;</b>");
#nullable restore
#line 24 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                     Write(Model.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n");
#nullable restore
#line 29 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
     if (ViewBag.emailId != null && ViewBag.check == "MyEvent" && Model.Date >= DateTime.Now)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2de2a9e77d7a42bd61858d4c8f0aed683a5351ce10388", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                                                                       WriteLiteral(Model.EventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2de2a9e77d7a42bd61858d4c8f0aed683a5351ce13018", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                    WriteLiteral(Model.EventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
 if (ViewBag.emailId != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2de2a9e77d7a42bd61858d4c8f0aed683a5351ce15979", async() => {
                WriteLiteral("Add Comment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                                                                               WriteLiteral(Model.EventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
 if (ViewBag.count == 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"" style=""margin-top:50px; margin-bottom:50px; width:80%; margin-left:30px; margin-bottom:50px;"">
        <table class=""table table-bordered"">
            <thead style=""background-color:grey; color:white;"">
                <tr class=""fs-5"">
                    <th colspan=""2"">Comments</th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 52 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                 foreach (var comment in ViewBag.Comments)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"fs-5\" style=\"margin-bottom:10px;\">\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                       Write(comment.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                       Write(comment.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 59 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 63 "C:\Users\adityanarayan\Desktop\BookEvent\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
