#pragma checksum "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0901268a1b468ec73b58669cc3373dfb02fe4670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Edit), @"mvc.1.0.view", @"/Views/Clients/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Edit.cshtml", typeof(AspNetCore.Views_Clients_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0901268a1b468ec73b58669cc3373dfb02fe4670", @"/Views/Clients/Edit.cshtml")]
    public class Views_Clients_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 38, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this Client: ");
            EndContext();
            BeginContext(99, 41, false);
#line 9 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
                 Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(140, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(142, 40, false);
#line 9 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
                                                            Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(182, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(220, 33, false);
#line 13 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(258, 39, false);
#line 15 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(301, 40, false);
#line 16 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.EditorFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(346, 39, false);
#line 18 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.LabelFor(model => model.StylistId));

#line default
#line hidden
            EndContext();
            BeginContext(389, 30, false);
#line 19 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.DropDownList("StylistId"));

#line default
#line hidden
            EndContext();
            BeginContext(421, 39, true);
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 22 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(462, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(466, 40, false);
#line 23 "/Users/frederickernest/Desktop/Epicodus/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(506, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
