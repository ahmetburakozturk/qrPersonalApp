#pragma checksum "/Users/ahmetburakozturk/Projects/deneme/deneme/Views/Personel/List_Personel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5883a0ba8ee3e31485ebe5003e359c01b022fb1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_List_Personel), @"mvc.1.0.view", @"/Views/Personel/List_Personel.cshtml")]
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
#line 1 "/Users/ahmetburakozturk/Projects/deneme/deneme/Views/_ViewImports.cshtml"
using deneme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ahmetburakozturk/Projects/deneme/deneme/Views/_ViewImports.cshtml"
using deneme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5883a0ba8ee3e31485ebe5003e359c01b022fb1a", @"/Views/Personel/List_Personel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be06e78d9d8ce849c9478dc0ac0e1ca49af2983", @"/Views/_ViewImports.cshtml")]
    public class Views_Personel_List_Personel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<deneme.Models.PersonelModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/ahmetburakozturk/Projects/deneme/deneme/Views/Personel/List_Personel.cshtml"
  
    ViewData["Title"] = "Ekle";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container"" style=""padding: 1rem; position: fixed; top: 50%; left: 50%; transform: translate(-50%, -50%); width: 75%; max-width: 75%; height: 550px;"">

    <input type=""text"" id=""search"" onkeyup=""search()"" placeholder=""Search for names.."" title=""Type in a name""
           style=""width: 100%; font-size: 16px; padding: 12px 20px 12px 40px; border: 1px solid #ddd; margin-bottom: 6px;"">

    <table id=""myTable"" class=""table-scroll small-first-col"" style=""display: block; empty-cells: show; border-spacing: 0; border: 1px solid;"">
        <thead style=""background-color: #f1f1f1; position: relative; display: block; width: 100%; overflow-y: scroll;"">
            <tr style=""width: 100%; display: flex;"">
                <th style=""flex-basis: 100%; flex-grow: 2; display: block; padding: 1rem; text-align: center;"">Ad</th>
                <th style=""flex-basis: 100%; flex-grow: 2; display: block; padding: 1rem; text-align: center;"">Soyad</th>
                <th style=""flex-basis: 100%; flex-grow: 2; display");
            WriteLiteral(@": block; padding: 1rem; text-align: center;"">TC</th>
                <th style=""flex-basis: 100%; flex-grow: 2; display: block; padding: 1rem; text-align: center;"">Tel</th>
                <th style=""flex-basis: 100%; flex-grow: 2; display: block; padding: 1rem; text-align: center;"">QR Kod</th>
                <th style=""flex-basis: 100%; flex-grow: 2; display: block; padding: 1rem; text-align: center;"">Sil</th>
            </tr>
        </thead>
        <tbody id=""myTable_body"" class=""body-half-screen"" style=""display: block; position: relative; width: 100%; overflow-y: scroll; border-top: 1px solid rgba(0,0,0,0.2); max-height: 550px; background-color: #343a40; "">
");
#nullable restore
#line 25 "/Users/ahmetburakozturk/Projects/deneme/deneme/Views/Personel/List_Personel.cshtml"
             foreach (var i in Model.personel)
            {
                foreach (var a in Model.qr)
                {
                    if (i.id == a.perId)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr style=\"width: 100%; display: flex;\">\n                            <td style=\"flex-basis: 100%; flex-grow: 2; display: block; padding: 1rem; text-align: center; color: white; vertical-align: middle; height: auto; \">");
#nullable restore
#line 32 "/Users/ahmetburakozturk/Projects/deneme/deneme/Views/Personel/List_Personel.cshtml"
                                                                                                                                                                           Write(i.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"flex-basis: 100%; flex-grow: 2; display: block; padding: 1rem; text-align: center; color: white; vertical-align: middle; height: auto; \">");
#nullable restore
#line 33 "/Users/ahmetburakozturk/Projects/deneme/deneme/Views/Personel/List_Personel.cshtml"
                                                                                                                                                                           Write(i.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"flex-basis: 100%; flex-grow: 2; display: block; padding: 1rem; text-align: center; color: white; vertical-align: middle; height: auto; \">");
#nullable restore
#line 34 "/Users/ahmetburakozturk/Projects/deneme/deneme/Views/Personel/List_Personel.cshtml"
                                                                                                                                                                           Write(i.tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"flex-basis: 100%; flex-grow: 2; display: block; padding: 1rem; text-align: center; color: white; vertical-align: middle; height: auto; \">");
#nullable restore
#line 35 "/Users/ahmetburakozturk/Projects/deneme/deneme/Views/Personel/List_Personel.cshtml"
                                                                                                                                                                           Write(i.tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"flex-basis: 100%; flex-grow: 2; display: block; padding: 1rem; text-align: center; color: white; vertical-align: middle; height: auto; \"><img");
            BeginWriteAttribute("src", " src=\"", 2957, "\"", 3039, 1);
#nullable restore
#line 36 "/Users/ahmetburakozturk/Projects/deneme/deneme/Views/Personel/List_Personel.cshtml"
WriteAttributeValue("", 2963, String.Format("data:image/png;base64,{0}",Convert.ToBase64String(a.qrByte)), 2963, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 40px; height: 40px;"" /></td>
                            <td style=""flex-basis:100% ; flex-grow: 2; display: block; padding: 1rem; text-align: center; color: white; vertical-align: middle; height: auto; ""><a class=""btn btn-danger"" style=""padding: 0.3rem 1rem; """);
            BeginWriteAttribute("href", " href=\"", 3316, "\"", 3354, 2);
            WriteAttributeValue("", 3323, "/Personel/Delete_Personal/", 3323, 26, true);
#nullable restore
#line 37 "/Users/ahmetburakozturk/Projects/deneme/deneme/Views/Personel/List_Personel.cshtml"
WriteAttributeValue("", 3349, i.id, 3349, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a></td>\n                        </tr>\n");
#nullable restore
#line 39 "/Users/ahmetburakozturk/Projects/deneme/deneme/Views/Personel/List_Personel.cshtml"
                    }
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>



<script>function search() {
        $(""tr"").each(function (index, value) {
            if (index > 0 && !$(this).find(""td"")[0].innerText.toUpperCase().includes($(""#search"").val().toUpperCase())) {
                $(this).attr(""hidden"", true);
            } else {
                $(this).removeAttr(""hidden"");
            }
        })
    }
    </script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<deneme.Models.PersonelModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
