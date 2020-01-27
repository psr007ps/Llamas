#pragma checksum "/Users/pranshushrivastava/Projects/Zappos/Zappos/Pages/AboutMe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6732beb41bec1baec75c3f1abae3e14d636050bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zappos.Pages.Pages_AboutMe), @"mvc.1.0.razor-page", @"/Pages/AboutMe.cshtml")]
namespace Zappos.Pages
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
#line 1 "/Users/pranshushrivastava/Projects/Zappos/Zappos/Pages/_ViewImports.cshtml"
using Zappos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6732beb41bec1baec75c3f1abae3e14d636050bd", @"/Pages/AboutMe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcacbb4980ed3418da3a92c4fc5691503f848738", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AboutMe : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "/Users/pranshushrivastava/Projects/Zappos/Zappos/Pages/AboutMe.cshtml"
      
        ViewData["Title"] = "About Me";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 9 "/Users/pranshushrivastava/Projects/Zappos/Zappos/Pages/AboutMe.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <div>
        <h3 class=""h3Class"" style=""font-family: Courier New, Courier, monospace""> About Me! </h3>
        <p class=""para"">
            I am a Graduate student at the University of California, Riverside pursuing a masters degree in Computer Science.
        </p>
        <h3 class=""h3Class"" style=""font-family: Courier New, Courier, monospace""> Why front-end? </h3>
        <p class=""para"">
            The design of a system is something which makes the impressions last. Also, it determines how the users will respond to the content and how often will they visit it. The generation of fresh new ideas and how the smallest detail matters is something that inspires me to choose this field.
        </p>

        <h3 class=""h3Class"" style=""font-family: Courier New, Courier, monospace""> Why I built the site this way</h3>
        <p class=""para"">
            Basic UX/UI design principles are implemented for building this website. A white theme is used to maintain consistency and accessibility ");
            WriteLiteral(@"while giving it a sense of style using typography. This is done targetting the user base. As this is a site related to a specific species, the users can be sensitive and sympathetic. What they would want is a simple website giving out the relevant details in a clear manner. Hierarchy is maintained across the site using the navigation bar and hyperlinks. A feedback form is introduced so that the users can express there views while browsing. There is also a page for facts which will help the users to connect with the contents of the site.
        </p>
        <h3 class=""h3Class"" style=""font-family: Courier New, Courier, monospace""> Frameworks that I used</h3>
        <p class=""para"">
            I used the .NET framework for building this website in which I used ASP.NET combined with HTML, CSS, javascript, razor, etc.
        </p>
        
    </div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutMeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutMeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutMeModel>)PageContext?.ViewData;
        public AboutMeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
