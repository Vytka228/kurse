#pragma checksum "D:\programms\CourseProject\CourseProject\Views\Owner\AddOwner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b7cc47a1f2220dcc90c4998e876b7b3805cba1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owner_AddOwner), @"mvc.1.0.view", @"/Views/Owner/AddOwner.cshtml")]
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
#line 1 "D:\programms\CourseProject\CourseProject\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\programms\CourseProject\CourseProject\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b7cc47a1f2220dcc90c4998e876b7b3805cba1d", @"/Views/Owner/AddOwner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Owner_AddOwner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Models.OwnerAddViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>\r\n    Добавление записи\r\n</h3>\r\n<hr />\r\n");
#nullable restore
#line 6 "D:\programms\CourseProject\CourseProject\Views\Owner\AddOwner.cshtml"
 using (Html.BeginForm("AddOwner", "Owner", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 9 "D:\programms\CourseProject\CourseProject\Views\Owner\AddOwner.cshtml"
   Write(Html.LabelFor(m => m.Fio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 11 "D:\programms\CourseProject\CourseProject\Views\Owner\AddOwner.cshtml"
       Write(Html.TextBoxFor(m => m.Fio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 15 "D:\programms\CourseProject\CourseProject\Views\Owner\AddOwner.cshtml"
   Write(Html.LabelFor(m => m.NameFone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 17 "D:\programms\CourseProject\CourseProject\Views\Owner\AddOwner.cshtml"
       Write(Html.TextBoxFor(m => m.NameFone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div>\r\n        <div>\r\n            <input type=\"submit\" class=\"btn btn-default\" value=\"Добавить\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "D:\programms\CourseProject\CourseProject\Views\Owner\AddOwner.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Models.OwnerAddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
