#pragma checksum "C:\Users\DEEPAK ALUGU\source\repos\TwitterCaseStudy\TwitterCaseStudy\Views\Twitter\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a537f6a4cc9592a9113177bc3a515d617cf6cef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Twitter_Login), @"mvc.1.0.view", @"/Views/Twitter/Login.cshtml")]
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
#line 1 "C:\Users\DEEPAK ALUGU\source\repos\TwitterCaseStudy\TwitterCaseStudy\Views\_ViewImports.cshtml"
using TwitterCaseStudy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DEEPAK ALUGU\source\repos\TwitterCaseStudy\TwitterCaseStudy\Views\_ViewImports.cshtml"
using TwitterCaseStudy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a537f6a4cc9592a9113177bc3a515d617cf6cef", @"/Views/Twitter/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7967913d5adc1805014e398589bab49d2e89a17", @"/Views/_ViewImports.cshtml")]
    public class Views_Twitter_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\DEEPAK ALUGU\source\repos\TwitterCaseStudy\TwitterCaseStudy\Views\Twitter\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1>\r\n");
#nullable restore
#line 7 "C:\Users\DEEPAK ALUGU\source\repos\TwitterCaseStudy\TwitterCaseStudy\Views\Twitter\Login.cshtml"
 using (Html.BeginForm("Login","Twitter","POST"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""form-group"">
    <label class=""control-label"">UserName</label>
    <input class=""form-control"" required name=""uname""/>
</div>
<div class=""form-group"">
    <label class=""control-label"">Password</label>
    <input type=""password"" class=""form-control"" required name=""pwd""/>
</div>
<div class=""form-group"">
    <input type=""submit"" value=""SignIn"" class=""btn btn-primary"" />
    <span class=""text-danger"">");
#nullable restore
#line 19 "C:\Users\DEEPAK ALUGU\source\repos\TwitterCaseStudy\TwitterCaseStudy\Views\Twitter\Login.cshtml"
                         Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n");
#nullable restore
#line 21 "C:\Users\DEEPAK ALUGU\source\repos\TwitterCaseStudy\TwitterCaseStudy\Views\Twitter\Login.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
