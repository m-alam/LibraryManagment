#pragma checksum "E:\practice\LibraryManagment\LibraryManagment\Areas\Admin\Views\Shared\_ActionMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d89cfb22e40885a670feb7b44f614d9ea6385a17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__ActionMessage), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_ActionMessage.cshtml")]
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
#line 1 "E:\practice\LibraryManagment\LibraryManagment\Areas\Admin\Views\_ViewImports.cshtml"
using LibraryManagment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\practice\LibraryManagment\LibraryManagment\Areas\Admin\Views\_ViewImports.cshtml"
using LibraryManagment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89cfb22e40885a670feb7b44f614d9ea6385a17", @"/Areas/Admin/Views/Shared/_ActionMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"162eb03c4d0587a92ffa8bc83734639c5af20fa8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__ActionMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryManagment.Areas.Admin.Models.ResponseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\practice\LibraryManagment\LibraryManagment\Areas\Admin\Views\Shared\_ActionMessage.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 212, "\"", 264, 3);
            WriteAttributeValue("", 220, "alert", 220, 5, true);
            WriteAttributeValue(" ", 225, "alert-dismissible", 226, 18, true);
#nullable restore
#line 7 "E:\practice\LibraryManagment\LibraryManagment\Areas\Admin\Views\Shared\_ActionMessage.cshtml"
WriteAttributeValue(" ", 243, Model.StyleCssClass, 244, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>\r\n        <h5><i");
            BeginWriteAttribute("class", " class=\"", 384, "\"", 420, 3);
            WriteAttributeValue("", 392, "icon", 392, 4, true);
            WriteAttributeValue(" ", 396, "fas", 397, 4, true);
#nullable restore
#line 9 "E:\practice\LibraryManagment\LibraryManagment\Areas\Admin\Views\Shared\_ActionMessage.cshtml"
WriteAttributeValue(" ", 400, Model.IconCssClass, 401, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 9 "E:\practice\LibraryManagment\LibraryManagment\Areas\Admin\Views\Shared\_ActionMessage.cshtml"
                                                    Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        ");
#nullable restore
#line 10 "E:\practice\LibraryManagment\LibraryManagment\Areas\Admin\Views\Shared\_ActionMessage.cshtml"
   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 12 "E:\practice\LibraryManagment\LibraryManagment\Areas\Admin\Views\Shared\_ActionMessage.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryManagment.Areas.Admin.Models.ResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591