#pragma checksum "C:\Users\Кирилл\Desktop\Сайт\kyr\Views\Second\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b375eba26547d70383e78a0ef4d5c301eb5920d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Second_Contact), @"mvc.1.0.view", @"/Views/Second/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Second/Contact.cshtml", typeof(AspNetCore.Views_Second_Contact))]
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
#line 1 "C:\Users\Кирилл\Desktop\Сайт\kyr\Views\_ViewImports.cshtml"
using kyr.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b375eba26547d70383e78a0ef4d5c301eb5920d8", @"/Views/Second/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de3ae7898ed62959ad570ef33eb0015e06253df6", @"/Views/_ViewImports.cshtml")]
    public class Views_Second_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 342, true);
            WriteLiteral(@"<br>
<h2>Курсовой проект по ООП</h2>
<br>
<div class=""form-group"">
    <label for=""exampleFormControlTextarea1"">Текст отзыва:</label>
    <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""3""></textarea>
</div>
<a href=""/"" class=""btn btn-primary btn-lg active"" role=""button"" aria-pressed=""true"">
    Отправить
</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591