#pragma checksum "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "338efadc1d087a2547786b6ab23d8975e893b7c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Details), @"mvc.1.0.view", @"/Views/Clients/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Details.cshtml", typeof(AspNetCore.Views_Clients_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"338efadc1d087a2547786b6ab23d8975e893b7c1", @"/Views/Clients/Details.cshtml")]
    public class Views_Clients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 42, true);
            WriteLiteral("\n<h2>Appointment Details:</h2>\n\n<h3>Name: ");
            EndContext();
            BeginContext(103, 41, false);
#line 9 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
     Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(144, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(146, 40, false);
#line 9 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
                                                Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(186, 20, true);
            WriteLiteral("</h3>\n<h3>Services: ");
            EndContext();
            BeginContext(207, 40, false);
#line 10 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
         Write(Html.DisplayFor(model => model.Services));

#line default
#line hidden
            EndContext();
            BeginContext(247, 87, true);
            WriteLiteral("</h3>\n\n<input type=\"button\" class=\"btn btn-outline-info\" value=\"Edit This Appointment!\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 334, "\"", 402, 3);
            WriteAttributeValue("", 344, "location.href=\'", 344, 15, true);
#line 12 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
WriteAttributeValue("", 359, Url.Action("Edit", new { id = Model.Id }), 359, 42, false);

#line default
#line hidden
            WriteAttributeValue("", 401, "\'", 401, 1, true);
            EndWriteAttribute();
            BeginContext(403, 86, true);
            WriteLiteral(" />\n<input type=\"button\" class=\"btn btn-outline-info\" value=\"Delete This Appointment!\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 489, "\"", 559, 3);
            WriteAttributeValue("", 499, "location.href=\'", 499, 15, true);
#line 13 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Details.cshtml"
WriteAttributeValue("", 514, Url.Action("Delete", new { id = Model.Id }), 514, 44, false);

#line default
#line hidden
            WriteAttributeValue("", 558, "\'", 558, 1, true);
            EndWriteAttribute();
            BeginContext(560, 3, true);
            WriteLiteral(" />");
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
