#pragma checksum "C:\Users\Grego\OneDrive\Desktop\MSSA\MSSA\ISTA421\labs\ProEntity\EFPartyInvites\Views\Home\ListResponses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25226c8120ada4accfac495c418b9ad4737f3f57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListResponses), @"mvc.1.0.view", @"/Views/Home/ListResponses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListResponses.cshtml", typeof(AspNetCore.Views_Home_ListResponses))]
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
#line 1 "C:\Users\Grego\OneDrive\Desktop\MSSA\MSSA\ISTA421\labs\ProEntity\EFPartyInvites\Views\_ViewImports.cshtml"
using EFPartyInvites.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25226c8120ada4accfac495c418b9ad4737f3f57", @"/Views/Home/ListResponses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b197d6c7b5c06d6d46c76adaa204a725e71a7642", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListResponses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GuestResponse>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 408, true);
            WriteLiteral(@"<h3 class=""bg-primary p-2 text-white text-center"">
    Here is the list of people who have
    responded
</h3>
<div class=""container-fluid"">
    <div class=""row p-1"">
        <div class=""col font-weight-bold"">Name</div>
        <div class=""col font-weight-bold"">Email</div>
        <div class=""col font-weight-bold"">Phone</div>
        <div class=""col font-weight-bold"">Attending</div>
    </div>
");
            EndContext();
#line 13 "C:\Users\Grego\OneDrive\Desktop\MSSA\MSSA\ISTA421\labs\ProEntity\EFPartyInvites\Views\Home\ListResponses.cshtml"
     foreach (GuestResponse r in Model)
    {

#line default
#line hidden
            BeginContext(491, 60, true);
            WriteLiteral("        <div class=\"row p-1\">\r\n            <div class=\"col\">");
            EndContext();
            BeginContext(552, 6, false);
#line 16 "C:\Users\Grego\OneDrive\Desktop\MSSA\MSSA\ISTA421\labs\ProEntity\EFPartyInvites\Views\Home\ListResponses.cshtml"
                        Write(r.Name);

#line default
#line hidden
            EndContext();
            BeginContext(558, 37, true);
            WriteLiteral("</div>\r\n            <div class=\"col\">");
            EndContext();
            BeginContext(596, 7, false);
#line 17 "C:\Users\Grego\OneDrive\Desktop\MSSA\MSSA\ISTA421\labs\ProEntity\EFPartyInvites\Views\Home\ListResponses.cshtml"
                        Write(r.Email);

#line default
#line hidden
            EndContext();
            BeginContext(603, 37, true);
            WriteLiteral("</div>\r\n            <div class=\"col\">");
            EndContext();
            BeginContext(641, 7, false);
#line 18 "C:\Users\Grego\OneDrive\Desktop\MSSA\MSSA\ISTA421\labs\ProEntity\EFPartyInvites\Views\Home\ListResponses.cshtml"
                        Write(r.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(648, 37, true);
            WriteLiteral("</div>\r\n            <div class=\"col\">");
            EndContext();
            BeginContext(687, 35, false);
#line 19 "C:\Users\Grego\OneDrive\Desktop\MSSA\MSSA\ISTA421\labs\ProEntity\EFPartyInvites\Views\Home\ListResponses.cshtml"
                         Write(r.WillAttend == true ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(723, 24, true);
            WriteLiteral("</div>\r\n        </div>\r\n");
            EndContext();
#line 21 "C:\Users\Grego\OneDrive\Desktop\MSSA\MSSA\ISTA421\labs\ProEntity\EFPartyInvites\Views\Home\ListResponses.cshtml"
    }

#line default
#line hidden
            BeginContext(754, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GuestResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
