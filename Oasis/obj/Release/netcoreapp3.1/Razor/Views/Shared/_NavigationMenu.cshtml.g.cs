#pragma checksum "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\Shared\_NavigationMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7785999f108ffa1ecf2d1d81884deebaa542d7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NavigationMenu), @"mvc.1.0.view", @"/Views/Shared/_NavigationMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7785999f108ffa1ecf2d1d81884deebaa542d7e", @"/Views/Shared/_NavigationMenu.cshtml")]
    public class Views_Shared__NavigationMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\t<nav id=\"topnav\">\r\n\t\t<a href=\"/Home\">O</a>\r\n\t\t<a href=\"#\">BL</a>\r\n\t\t<input id=\"search\" autocomplete=\"off\" type=\"text\" placeholder=\"Search..\">\r\n\t\t<a href=\"#\"><img class=\"shoppingcart\" src=\"img/shopping-cart.png\"");
            BeginWriteAttribute("alt", " alt=\"", 331, "\"", 337, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n\t\t<div class=\"dropdown-menu\">\r\n\t\t\t<a id=\"opt\">Opt</a>\r\n\t\t\t<br>\r\n\t\t\t<div class=\"dropdown-options\">\r\n");
#nullable restore
#line 13 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\Shared\_NavigationMenu.cshtml"
                 if(User.Identity.IsAuthenticated)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<a href=\"#\">Profile</a>\r\n\t\t\t\t\t<br>\r\n");
#nullable restore
#line 17 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\Shared\_NavigationMenu.cshtml"
					if(User.IsInRole(Oasis.Configurations.RoleTitle.Buyer))
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<a href=\"../../Lists\">Shopping Lists</a>\r\n\t\t\t\t\t\t<br />\r\n");
#nullable restore
#line 21 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\Shared\_NavigationMenu.cshtml"
					}
					else if(User.IsInRole(Oasis.Configurations.RoleTitle.Seller))
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<a href=\"../../Dashboard\">Dashboard</a>\r\n\t\t\t\t\t\t<br />\r\n\t\t\t\t\t\t<a href=\"#\">Shipment Validation Update</a>\r\n\t\t\t\t\t\t<br />\r\n");
#nullable restore
#line 28 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\Shared\_NavigationMenu.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<a href=\"Signout\">Sign Out</a>\r\n");
#nullable restore
#line 30 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\Shared\_NavigationMenu.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<a href=\"/Signin\">Sign In</a>\r\n\t\t\t\t\t<br />\r\n\t\t\t\t\t<a href=\"#\">Membership Benefits</a>\r\n");
#nullable restore
#line 36 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\Shared\_NavigationMenu.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</nav>\r\n");
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
