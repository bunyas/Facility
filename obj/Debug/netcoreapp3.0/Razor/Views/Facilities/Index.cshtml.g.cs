#pragma checksum "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c1c4ae8b30f548f6601a6f9f3e59310b5e29e4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facilities_Index), @"mvc.1.0.view", @"/Views/Facilities/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Facilities/Index.cshtml", typeof(AspNetCore.Views_Facilities_Index))]
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
#line 1 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\_ViewImports.cshtml"
using SyncfusionASPNETCoreApplication2;

#line default
#line hidden
#line 2 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\_ViewImports.cshtml"
using SyncfusionASPNETCoreApplication2.Models;

#line default
#line hidden
#line 3 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c1c4ae8b30f548f6601a6f9f3e59310b5e29e4d", @"/Views/Facilities/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95337b7b2b846277d61c710cfc09f3091dfb882e", @"/Views/_ViewImports.cshtml")]
    public class Views_Facilities_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SyncfusionASPNETCoreApplication2.Models.AFacilities>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(116, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(145, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e787618c5c914cd1b7f2be44993ce44d", async() => {
                BeginContext(168, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(182, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(275, 59, false);
#line 16 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImplimentingPartnerCode));

#line default
#line hidden
            EndContext();
            BeginContext(334, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(390, 44, false);
#line 19 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Facility));

#line default
#line hidden
            EndContext();
            BeginContext(434, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(490, 43, false);
#line 22 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SapCode));

#line default
#line hidden
            EndContext();
            BeginContext(533, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(589, 51, false);
#line 25 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SupportedByMaul));

#line default
#line hidden
            EndContext();
            BeginContext(640, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(696, 48, false);
#line 28 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsAccredited));

#line default
#line hidden
            EndContext();
            BeginContext(744, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(800, 46, false);
#line 31 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RegionCode));

#line default
#line hidden
            EndContext();
            BeginContext(846, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(902, 48, false);
#line 34 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RfsoUserName));

#line default
#line hidden
            EndContext();
            BeginContext(950, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1006, 46, false);
#line 37 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Longtitude));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1108, 46, false);
#line 40 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Latititude));

#line default
#line hidden
            EndContext();
            BeginContext(1154, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1210, 44, false);
#line 43 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1310, 59, false);
#line 46 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NearestPublicHfDistance));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1425, 40, false);
#line 49 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dsdm));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1521, 45, false);
#line 52 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ActiveArt));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1622, 45, false);
#line 55 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cdcregion));

#line default
#line hidden
            EndContext();
            BeginContext(1667, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1723, 60, false);
#line 58 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientTypeCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1783, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1839, 82, false);
#line 61 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ComprehensiveImplimentingPartnerCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1921, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1977, 62, false);
#line 64 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryZoneCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2039, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2095, 59, false);
#line 67 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DistrrictCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2154, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2210, 48, false);
#line 70 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FacilityType));

#line default
#line hidden
            EndContext();
            BeginContext(2258, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2314, 57, false);
#line 73 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LevelOfCareNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2371, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2427, 45, false);
#line 76 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ownership));

#line default
#line hidden
            EndContext();
            BeginContext(2472, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2528, 61, false);
#line 79 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PatientLoadCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2589, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2645, 43, false);
#line 82 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Village));

#line default
#line hidden
            EndContext();
            BeginContext(2688, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 88 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2806, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2855, 58, false);
#line 91 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImplimentingPartnerCode));

#line default
#line hidden
            EndContext();
            BeginContext(2913, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2969, 43, false);
#line 94 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Facility));

#line default
#line hidden
            EndContext();
            BeginContext(3012, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3068, 42, false);
#line 97 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SapCode));

#line default
#line hidden
            EndContext();
            BeginContext(3110, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3166, 50, false);
#line 100 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SupportedByMaul));

#line default
#line hidden
            EndContext();
            BeginContext(3216, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3272, 47, false);
#line 103 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsAccredited));

#line default
#line hidden
            EndContext();
            BeginContext(3319, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3375, 45, false);
#line 106 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RegionCode));

#line default
#line hidden
            EndContext();
            BeginContext(3420, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3476, 47, false);
#line 109 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RfsoUserName));

#line default
#line hidden
            EndContext();
            BeginContext(3523, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3579, 45, false);
#line 112 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Longtitude));

#line default
#line hidden
            EndContext();
            BeginContext(3624, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3680, 45, false);
#line 115 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Latititude));

#line default
#line hidden
            EndContext();
            BeginContext(3725, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3781, 43, false);
#line 118 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(3824, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3880, 58, false);
#line 121 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NearestPublicHfDistance));

#line default
#line hidden
            EndContext();
            BeginContext(3938, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3994, 39, false);
#line 124 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dsdm));

#line default
#line hidden
            EndContext();
            BeginContext(4033, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4089, 44, false);
#line 127 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ActiveArt));

#line default
#line hidden
            EndContext();
            BeginContext(4133, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4189, 56, false);
#line 130 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cdcregion.CdcregionId));

#line default
#line hidden
            EndContext();
            BeginContext(4245, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4301, 74, false);
#line 133 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ClientTypeCodeNavigation.ClientTypeCode));

#line default
#line hidden
            EndContext();
            BeginContext(4375, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4431, 105, false);
#line 136 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ComprehensiveImplimentingPartnerCodeNavigation.ImplimentingPartnerCode));

#line default
#line hidden
            EndContext();
            BeginContext(4536, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4592, 70, false);
#line 139 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeliveryZoneCodeNavigation.ZoneCode));

#line default
#line hidden
            EndContext();
            BeginContext(4662, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4718, 71, false);
#line 142 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DistrrictCodeNavigation.DistrictCode));

#line default
#line hidden
            EndContext();
            BeginContext(4789, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4845, 62, false);
#line 145 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FacilityType.FacilityTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(4907, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4963, 72, false);
#line 148 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LevelOfCareNavigation.LevelOfCareCode));

#line default
#line hidden
            EndContext();
            BeginContext(5035, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5091, 56, false);
#line 151 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ownership.OwnershipId));

#line default
#line hidden
            EndContext();
            BeginContext(5147, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5203, 76, false);
#line 154 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PatientLoadCodeNavigation.PatientLoadCode));

#line default
#line hidden
            EndContext();
            BeginContext(5279, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5335, 52, false);
#line 157 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Village.VillageId));

#line default
#line hidden
            EndContext();
            BeginContext(5387, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5442, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "667cc2ee50724190adc7a45d167b4c3e", async() => {
                BeginContext(5497, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 160 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
                                       WriteLiteral(item.FacilityCode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5505, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(5525, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce1a135b4a964b8f8a9058a27645f044", async() => {
                BeginContext(5583, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 161 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
                                          WriteLiteral(item.FacilityCode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5594, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(5614, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d69ffbca10c44a9081005273e27f5da0", async() => {
                BeginContext(5671, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 162 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
                                         WriteLiteral(item.FacilityCode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5681, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 165 "C:\IBS Projects 2020\SyncfusionASPNETCoreApplication2\Views\Facilities\Index.cshtml"
}

#line default
#line hidden
            BeginContext(5720, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SyncfusionASPNETCoreApplication2.Models.AFacilities>> Html { get; private set; }
    }
}
#pragma warning restore 1591
