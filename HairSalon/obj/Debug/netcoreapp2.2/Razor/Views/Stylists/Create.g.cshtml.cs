#pragma checksum "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acfc8c72ef1f407feb0af657fc3f15abb94ad8a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Create), @"mvc.1.0.view", @"/Views/Stylists/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Create.cshtml", typeof(AspNetCore.Views_Stylists_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acfc8c72ef1f407feb0af657fc3f15abb94ad8a4", @"/Views/Stylists/Create.cshtml")]
    public class Views_Stylists_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 37, true);
            WriteLiteral("\n<h2>Register as a new Stylist:</h2>\n");
            EndContext();
#line 8 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(125, 19, true);
            WriteLiteral("    <p>First Name: ");
            EndContext();
            BeginContext(145, 41, false);
#line 10 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
              Write(Html.TextBoxFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(186, 23, true);
            WriteLiteral("</p>\n    <p>Last Name: ");
            EndContext();
            BeginContext(210, 40, false);
#line 11 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
             Write(Html.TextBoxFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(250, 23, true);
            WriteLiteral("</p>\n    <p>Specialty: ");
            EndContext();
            BeginContext(274, 41, false);
#line 12 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
             Write(Html.TextBoxFor(model => model.Specialty));

#line default
#line hidden
            EndContext();
            BeginContext(315, 78, true);
            WriteLiteral("</p>\n    <input type=\"submit\" class=\"btn btn-outline-info\" value=\"Sign Up!\"/>\n");
            EndContext();
#line 14 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
