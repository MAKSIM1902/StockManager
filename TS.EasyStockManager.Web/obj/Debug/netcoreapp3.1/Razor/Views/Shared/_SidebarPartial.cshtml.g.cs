#pragma checksum "C:\Users\512Dell\OneDrive\Рабочий стол\TSEasyStockManager-master\TS.EasyStockManager.Web\Views\Shared\_SidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e24c347c9c01c9511e949352d60bb1c287836e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SidebarPartial), @"mvc.1.0.view", @"/Views/Shared/_SidebarPartial.cshtml")]
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
#line 1 "C:\Users\512Dell\OneDrive\Рабочий стол\TSEasyStockManager-master\TS.EasyStockManager.Web\Views\_ViewImports.cshtml"
using TS.EasyStockManager.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\512Dell\OneDrive\Рабочий стол\TSEasyStockManager-master\TS.EasyStockManager.Web\Views\_ViewImports.cshtml"
using TS.EasyStockManager.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e24c347c9c01c9511e949352d60bb1c287836e", @"/Views/Shared/_SidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0c103975936d0c3d5e68c7f4cc24b25708f6c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""mt-2"">
    <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">

        <li class=""nav-header"">Склад</li>
        <li class=""nav-item"">
            <a href=""/Transaction"" class=""nav-link"">
                <i class=""nav-icon fas fa-truck""></i>
                <p>Транзакции</p>
            </a>
        </li>
        <li class=""nav-header"">Отчеты</li>
        <li class=""nav-item"">
            <a href=""/Report/StoreStockReport"" class=""nav-link"">
                <i class=""nav-icon fas fa-building""></i>
                <p>Складские запасы</p>
            </a>
        </li>
        <li class=""nav-item"">
            <a href=""/Report/TransactionDetailReport"" class=""nav-link"">
                <i class=""nav-icon fas fa-list-alt""></i>
                <p>Сведения о складе</p>
            </a>
        </li>

        <li class=""nav-header"">Описание</li>
        <li class=""nav-item"">
            <a href=""/Category"" class=""nav-link"">
                <i class");
            WriteLiteral(@"=""nav-icon fas fa-folder""></i>
                <p>
                    Категории
                </p>
            </a>
        </li>
        <li class=""nav-item"">
            <a href=""/UnitOfMeasure"" class=""nav-link"">
                <i class=""nav-icon fas fa-box-open""></i>
                <p>
                    Единицы
                </p>
            </a>
        </li>
        <li class=""nav-item"">
            <a href=""/Product"" class=""nav-link"">
                <i class=""nav-icon fas fa-barcode""></i>
                <p>
                    Товар
                </p>
            </a>
        </li>
        <li class=""nav-item"">
            <a href=""/Store"" class=""nav-link"">
                <i class=""nav-icon fas fa-building""></i>
                <p>
                    Склады
                </p>
            </a>
        </li>
        <li class=""nav-item"">
            <a href=""/User"" class=""nav-link"">
                <i class=""nav-icon fas fa-user""></i>
                <p>
                    Пользователь
 ");
            WriteLiteral(@"               </p>
            </a>
        </li>
        <li class=""nav-header""></li>
        <li class=""nav-item"">
            <a href=""/Auth/Logout"" class=""nav-link"">
                <i class=""nav-icon fas fa-sign-out-alt""></i>
                <p>
                    Выйти
                </p>
            </a>
        </li>

    </ul>
</nav>");
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
