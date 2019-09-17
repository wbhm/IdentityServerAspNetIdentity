#pragma checksum "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b804845269353674b8cbe23b5a5bdc82f5b353"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grants_Index), @"mvc.1.0.view", @"/Views/Grants/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grants/Index.cshtml", typeof(AspNetCore.Views_Grants_Index))]
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
#line 1 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4b804845269353674b8cbe23b5a5bdc82f5b353", @"/Views/Grants/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4c1f8a331756813dc62d0a9e9a6b6778f02506", @"/Views/_ViewImports.cshtml")]
    public class Views_Grants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GrantsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Revoke", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 326, true);
            WriteLiteral(@"
<div class=""grants"">
    <div class=""row page-header"">
        <div class=""col-sm-10"">
            <h1>
                Client Application Access
            </h1>
            <div>Below is the list of applications you have given access to and the names of the resources they have access to.</div>
        </div>
    </div>

");
            EndContext();
#line 13 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
     if (Model.Grants.Any() == false)
    {

#line default
#line hidden
            BeginContext(393, 231, true);
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-sm-8\">\n                <div class=\"alert alert-info\">\n                    You have not given access to any applications\n                </div>\n            </div>\n        </div>\n");
            EndContext();
#line 22 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
    }
    else
    {
        foreach (var grant in Model.Grants)
        {

#line default
#line hidden
            BeginContext(699, 75, true);
            WriteLiteral("            <div class=\"row grant\">\n                <div class=\"col-sm-2\">\n");
            EndContext();
#line 29 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                     if (grant.ClientLogoUrl != null)
                    {

#line default
#line hidden
            BeginContext(850, 28, true);
            WriteLiteral("                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 878, "\"", 904, 1);
#line 31 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
WriteAttributeValue("", 884, grant.ClientLogoUrl, 884, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(905, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 32 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(929, 106, true);
            WriteLiteral("                </div>\n                <div class=\"col-sm-8\">\n                    <div class=\"clientname\">");
            EndContext();
            BeginContext(1036, 16, false);
#line 35 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                                       Write(grant.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(1052, 95, true);
            WriteLiteral("</div>\n                    <div>\n                        <span class=\"created\">Created:</span> ");
            EndContext();
            BeginContext(1148, 36, false);
#line 37 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                                                         Write(grant.Created.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 28, true);
            WriteLiteral("\n                    </div>\n");
            EndContext();
#line 39 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                     if (grant.Expires.HasValue)
                    {

#line default
#line hidden
            BeginContext(1283, 96, true);
            WriteLiteral("                        <div>\n                            <span class=\"expires\">Expires:</span> ");
            EndContext();
            BeginContext(1380, 42, false);
#line 42 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                                                             Write(grant.Expires.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 32, true);
            WriteLiteral("\n                        </div>\n");
            EndContext();
#line 44 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1476, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 45 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                     if (grant.IdentityGrantNames.Any())
                    {

#line default
#line hidden
            BeginContext(1555, 136, true);
            WriteLiteral("                        <div>\n                            <div class=\"granttype\">Identity Grants</div>\n                            <ul>\n");
            EndContext();
#line 50 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                                 foreach (var name in grant.IdentityGrantNames)
                        {

#line default
#line hidden
            BeginContext(1797, 40, true);
            WriteLiteral("                                    <li>");
            EndContext();
            BeginContext(1838, 4, false);
#line 52 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                                   Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(1842, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 53 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1882, 65, true);
            WriteLiteral("                            </ul>\n                        </div>\n");
            EndContext();
#line 56 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1969, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 57 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                     if (grant.ApiGrantNames.Any())
                    {

#line default
#line hidden
            BeginContext(2043, 131, true);
            WriteLiteral("                        <div>\n                            <div class=\"granttype\">API Grants</div>\n                            <ul>\n");
            EndContext();
#line 62 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                                 foreach (var name in grant.ApiGrantNames)
                                {

#line default
#line hidden
            BeginContext(2283, 40, true);
            WriteLiteral("                                    <li>");
            EndContext();
            BeginContext(2324, 4, false);
#line 64 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                                   Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(2328, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 65 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2368, 65, true);
            WriteLiteral("                            </ul>\n                        </div>\n");
            EndContext();
#line 68 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2455, 82, true);
            WriteLiteral("                </div>\n                <div class=\"col-sm-2\">\n                    ");
            EndContext();
            BeginContext(2537, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "890065ccb06f457799aa36041db18bf6", async() => {
                BeginContext(2563, 61, true);
                WriteLiteral("\n                        <input type=\"hidden\" name=\"clientId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2624, "\"", 2647, 1);
#line 72 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
WriteAttributeValue("", 2632, grant.ClientId, 2632, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2648, 100, true);
                WriteLiteral(">\n                        <button class=\"btn btn-danger\">Revoke Access</button>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2755, 43, true);
            WriteLiteral("\n                </div>\n            </div>\n");
            EndContext();
#line 77 "/home/wbhm/working/dotnet/IdentityServer4/IdentityServerAspNetIdentity/Views/Grants/Index.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(2814, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GrantsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
