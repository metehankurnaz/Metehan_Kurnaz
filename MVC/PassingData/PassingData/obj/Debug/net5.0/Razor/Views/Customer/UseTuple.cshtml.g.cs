#pragma checksum "C:\Users\Metehan\Desktop\MVC\PassingData\PassingData\Views\Customer\UseTuple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f38b7673f1db4b540056dafe9d7ddf24ed6a73b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_UseTuple), @"mvc.1.0.view", @"/Views/Customer/UseTuple.cshtml")]
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
#line 1 "C:\Users\Metehan\Desktop\MVC\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
using PassingData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f38b7673f1db4b540056dafe9d7ddf24ed6a73b1", @"/Views/Customer/UseTuple.cshtml")]
    public class Views_Customer_UseTuple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(Product,List<Customer>,string)>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    Ürün: ");
#nullable restore
#line 5 "C:\Users\Metehan\Desktop\MVC\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
     Write(Model.Item1.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<ul>\r\n");
#nullable restore
#line 9 "C:\Users\Metehan\Desktop\MVC\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
     foreach (Customer item in Model.Item2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 11 "C:\Users\Metehan\Desktop\MVC\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 12 "C:\Users\Metehan\Desktop\MVC\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<p>\r\n    Tarih : ");
#nullable restore
#line 16 "C:\Users\Metehan\Desktop\MVC\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
       Write(Model.Item3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(Product,List<Customer>,string)> Html { get; private set; }
    }
}
#pragma warning restore 1591
