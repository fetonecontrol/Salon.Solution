#pragma checksum "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Shared/NavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc5ea8d633e383e0279e7702c27f1e4c58a6340d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NavBar), @"mvc.1.0.view", @"/Views/Shared/NavBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/NavBar.cshtml", typeof(AspNetCore.Views_Shared_NavBar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5ea8d633e383e0279e7702c27f1e4c58a6340d", @"/Views/Shared/NavBar.cshtml")]
    public class Views_Shared_NavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 142, true);
            WriteLiteral("<div class=\"nav-bar-container\">\n  <nav class=\"navbar navbar-expand-sm bg-light navbar\">\n    <ul class=\"navbar-nav\">\n      <li class=\"nav-item\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 142, "\"", 196, 3);
            WriteAttributeValue("", 152, "location.href=\'", 152, 15, true);
#line 4 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Shared/NavBar.cshtml"
WriteAttributeValue("", 167, Url.Action("Index", "Home"), 167, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 195, "\'", 195, 1, true);
            EndWriteAttribute();
            BeginContext(197, 130, true);
            WriteLiteral(">\n      <div class =\"weHateRazorStyling\">\n        <a class=\"nav-link\">Home</a>\n      </div>\n      </li>\n      <li class=\"nav-item\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 327, "\"", 385, 3);
            WriteAttributeValue("", 337, "location.href=\'", 337, 15, true);
#line 9 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Shared/NavBar.cshtml"
WriteAttributeValue("", 352, Url.Action("Index", "Stylists"), 352, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 384, "\'", 384, 1, true);
            EndWriteAttribute();
            BeginContext(386, 91, true);
            WriteLiteral(">\n        <a class=\"nav-link\">Available Stylists</a>\n      </li>\n      <li class=\"nav-item\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 477, "\"", 534, 3);
            WriteAttributeValue("", 487, "location.href=\'", 487, 15, true);
#line 12 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Shared/NavBar.cshtml"
WriteAttributeValue("", 502, Url.Action("Index", "Clients"), 502, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 533, "\'", 533, 1, true);
            EndWriteAttribute();
            BeginContext(535, 345, true);
            WriteLiteral(@">
        <a class=""nav-link"">Booked Appointments</a>
      </li>
      <form class=""form-inline my-2 my-lg-0"">
      <input class=""form-control mr-sm-2"" type=""search"" placeholder=""Stylists and Appts"" aria-label=""Search"">
      <button class=""btn btn-outline-dark my-2 my-sm-0"" type=""submit"">Search</button>
    </form>
    </ul>
  </nav>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
