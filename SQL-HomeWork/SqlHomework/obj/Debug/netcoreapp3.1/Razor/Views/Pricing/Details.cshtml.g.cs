#pragma checksum "C:\Users\User\OneDrive\Desktop\SQL-HomeWork\SqlHomework\Views\Pricing\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "034c0435097f1585d8dae0d08ab1182e5d8c0e38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pricing_Details), @"mvc.1.0.view", @"/Views/Pricing/Details.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Desktop\SQL-HomeWork\SqlHomework\Views\_ViewImports.cshtml"
using SqlHomework.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Desktop\SQL-HomeWork\SqlHomework\Views\_ViewImports.cshtml"
using SqlHomework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\OneDrive\Desktop\SQL-HomeWork\SqlHomework\Views\_ViewImports.cshtml"
using SqlHomework.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"034c0435097f1585d8dae0d08ab1182e5d8c0e38", @"/Views/Pricing/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310c6e82332ffd5600f1bf79e1d8c4e47ff9bd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pricing_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pricing>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<main id=""main"">
    <!-- ======= Breadcrumbs ======= -->
    <div class=""breadcrumbs"" data-aos=""fade-in"">
        <div class=""container"">
            <h2>Pricing Details</h2>
            <p>Est dolorum ut non facere possimus quibusdam eligendi voluptatem. Quia id aut similique quia voluptas sit quaerat debitis. Rerum omnis ipsam aperiam consequatur laboriosam nemo harum praesentium. </p>
        </div>
    </div><!-- End Breadcrumbs -->
    <!-- ======= Pricing Section ======= -->
    <section id=""pricing"" class=""pricing"">
        <div class=""container"" data-aos=""fade-up"">
            <div class=""row"">

                <div class=""col-lg-12 col-md-6"">
                    <div class=""box"">
                        <h3>");
#nullable restore
#line 18 "C:\Users\User\OneDrive\Desktop\SQL-HomeWork\SqlHomework\Views\Pricing\Details.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <h4><sup>$</sup>");
#nullable restore
#line 19 "C:\Users\User\OneDrive\Desktop\SQL-HomeWork\SqlHomework\Views\Pricing\Details.cshtml"
                                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> / month</span></h4>\r\n                        ");
#nullable restore
#line 20 "C:\Users\User\OneDrive\Desktop\SQL-HomeWork\SqlHomework\Views\Pricing\Details.cshtml"
                   Write(Html.Raw(Model.List));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""btn-wrap"">
                            <a href=""#"" class=""btn-buy"">Buy Now</a>
                        </div>
                    </div>
                </div>
                <input style=""background: #3ac162; top: -1px; right: -1px; bottom: -1px; border: 0; background: none; font-size: 16px; padding: 0 20px 2px 20px; background: #5fcf80; color: #fff; transition: 0.3s; border-radius: 50px; box-shadow: 0px 2px 15px rgba(0, 0, 0, 0.1);"" type=""submit"" value=""Write Your Email to Buy Now!"">
            </div>
        </div>
    </section><!-- End Pricing Section -->

</main><!-- End #main -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pricing> Html { get; private set; }
    }
}
#pragma warning restore 1591
