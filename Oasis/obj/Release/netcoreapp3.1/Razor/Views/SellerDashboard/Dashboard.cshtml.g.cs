#pragma checksum "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "478f85ad21b21dead73a3ff4601655f9bca006e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SellerDashboard_Dashboard), @"mvc.1.0.view", @"/Views/SellerDashboard/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"478f85ad21b21dead73a3ff4601655f9bca006e8", @"/Views/SellerDashboard/Dashboard.cshtml")]
    public class Views_SellerDashboard_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Oasis.Models.Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/nav.css?v2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/grid.css?v2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css?v8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/graph.css?v6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/graphs.js?v4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/modifyui.js?v7"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/validation.js?v2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "478f85ad21b21dead73a3ff4601655f9bca006e86197", async() => {
                WriteLiteral("\r\n\t\t<meta charset=\"UTF-8\">\r\n\t\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "478f85ad21b21dead73a3ff4601655f9bca006e86573", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "478f85ad21b21dead73a3ff4601655f9bca006e87752", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "478f85ad21b21dead73a3ff4601655f9bca006e88931", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "478f85ad21b21dead73a3ff4601655f9bca006e810110", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "478f85ad21b21dead73a3ff4601655f9bca006e811290", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t<title>Dashboard</title>\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "478f85ad21b21dead73a3ff4601655f9bca006e813130", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
           await Html.RenderPartialAsync("_NavigationMenu"); 

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t<h1>Your Dashboard</h1>\r\n\t\t<div id=\"wizard\" class=\"popup-window\">\r\n\t\t\t<form id=\"itemwizard\" class=\"popup-form\" action=\"AddItems\" onsubmit=\"return ValidateItemsWizard()\" method=\"post\">\r\n\t\t\t\t<h3>Add Inventory</h3>\r\n\t\t\t\t");
#nullable restore
#line 26 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t");
#nullable restore
#line 27 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
           Write(Html.LabelFor(m => m.Name, "Enter Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t<input asp-for=\"Name\" type=\"text\" name=\"Name\" required>\r\n\t\t\t\t<br>\r\n\t\t\t\t");
#nullable restore
#line 30 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
           Write(Html.LabelFor(m => m.Category, "Enter Category"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t<input asp-for=\"Category\" type=\"text\" name=\"Category\" required>\r\n\t\t\t\t<br>\r\n\t\t\t\t");
#nullable restore
#line 33 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
           Write(Html.LabelFor(m => m.Price, "Enter Price"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t<input asp-for=\"Price\" type=\"text\" name=\"Price\" required>\r\n\t\t\t\t<br>\r\n\t\t\t\t");
#nullable restore
#line 36 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
           Write(Html.LabelFor(m => m.Quantity, "Enter the number of these items you want to sell"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
				<input asp-for=""Quantity"" type=""text"" name=""Quantity"" required>
				<br>
				<input type=""submit"" value=""Send Items"" />
			</form>
		</div>
		<div id=""graphwizard"" class=""popup-window"">
			<form id=""graphsetup"" name=""graphsetup"" class=""popup-form"" action=""CreateGraph"" method=""post"">
				");
#nullable restore
#line 44 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
				<h3>Graph Setup</h3>
				<label for=""graphTitle"">Graph Title</label>
				<input type=""text"" id=""graphTitle"" name=""graphTitle"" required/>
				<br />
				<label for=""itemOptions"">Select Parameters</label>
				<select id=""itemOptions"" name=""itemOptions"" required>
					<option id=""filler"" selected>Select Item</option>
");
#nullable restore
#line 52 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
                     foreach(var itemname in ViewBag.ItemNames)
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<option onclick=\"SelectItem(this)\"");
                BeginWriteAttribute("name", " name=\"", 2124, "\"", 2140, 1);
#nullable restore
#line 54 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
WriteAttributeValue("", 2131, itemname, 2131, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2141, "\"", 2158, 1);
#nullable restore
#line 54 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
WriteAttributeValue("", 2149, itemname, 2149, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 54 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
                                                                                         Write(itemname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 55 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
					}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"				</select>
				<div id=""selectedItems"" name=""selectedItems""></div>
				<input id=""items"" name=""items"" type=""hidden"" />
				<fieldset>
					<legend>Select a Parameter</legend>
					<input id=""option1"" name=""parameter"" type=""radio"" value=""Total Revenue"" required/>
					<label for=""option1"">Total Revenue</label>

					<input id=""option2"" name=""parameter"" type=""radio"" value=""Selling Frequency"" />
					<label for=""option2"">Selling Frequency</label>

					<input id=""option3"" name=""parameter"" type=""radio"" value=""Rating"" />
					<label for=""option3"">Rating</label>

					<input id=""option4"" name=""parameter"" type=""radio"" value=""Inventory"" />
					<label for=""option4"">Inventory</label>

					<input id=""option5"" name=""parameter"" type=""radio"" value=""Average Revenue"" />
					<label for=""option5"">Average Revenue</label>

					<input id=""option6"" name=""parameter"" type=""radio"" value=""Average Rating"" />
					<label for=""option6"">Average Rating</label>

					<input id=""option7"" name=""parameter"" type=""r");
                WriteLiteral(@"adio"" value=""Selling Frequency"" />
					<label for=""option7"">Selling Frequency</label>

					<input id=""option8"" name=""parameter"" type=""radio"" value=""Total Views"" />
					<label for=""option8"">Total Views</label>
					<br />
					<input id=""option9"" name=""parameter"" type=""radio"" value=""Average Views"" />
					<label for=""option9"">Average Views</label>
					<br />
				</fieldset>
				<fieldset>
					<legend>Would you like to select a date range</legend>
					<input id=""yes"" type=""radio"" name=""decision"" value=""yes"" onclick=""DisplayGraphOptions(this)"" required/>
					<label for=""yes"">Yes</label>
					<input id=""no"" type=""radio"" name=""decision"" value=""no"" onclick=""DisplayGraphOptions(this)"" />
					<label for=""no"">No</label>
				</fieldset>
				<div id=""dates"">
					<label id=""daterange"" for=""range"">Enter Range</label>
					<p><input type=""date"" id=""range"" name=""start""> to <input type=""date"" id=""range2"" name=""end""></p>
				</div>
				<div id=""graphType"">
					<label for=""graphSelector"">What ki");
                WriteLiteral(@"nd of graph would you like to use?</label>
					<select id=""graphType"" name=""graphType"" required>
						<option name=""bar"" value=""bar"">Bar</option>
						<option name=""line"" value=""line"">Line</option>
						<option name=""pie"" value=""pie"">Pie</option>
					</select>
				</div>
				<input type=""submit"" class=""float-right"" value=""Create Graph"" />
			</form>
		</div>
		<div class=""grid-setup"">
			<div class=""grid-left-content"">
				<h4>Trends</h4>
			</div>
			<div class=""grid-center-content border"">
				<h4>Data</h4>
");
#nullable restore
#line 117 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
                 if(ViewBag.Items != null)
				{
					int c = 0;
					foreach(var item in ViewBag.Items)
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<form action=\"RemoveGraph\" method=\"post\">\r\n\t\t\t\t\t\t\t<div class=\"graph-container\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 124 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<canvas");
                BeginWriteAttribute("id", " id=\"", 5013, "\"", 5028, 2);
                WriteAttributeValue("", 5018, "myChart-", 5018, 8, true);
#nullable restore
#line 125 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
WriteAttributeValue("", 5026, c, 5026, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></canvas>\r\n\t\t\t\t\t\t\t\t<button type=\"submit\" class=\"hidegraphbutton\">Remove Graph</button>\r\n\t\t\t\t\t\t\t\t<input id=\"graphName\" name=\"graphName\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5178, "\"", 5201, 1);
#nullable restore
#line 127 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
WriteAttributeValue("", 5186, item.GraphName, 5186, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "478f85ad21b21dead73a3ff4601655f9bca006e823190", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<script>DisplayGraphs(");
#nullable restore
#line 129 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
                                                 Write(Oasis.Services.JavaScriptConvertService.SerializeObject(item));

#line default
#line hidden
#nullable disable
                WriteLiteral(", \"myChart-");
#nullable restore
#line 129 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
                                                                                                                          Write(c);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");</script>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</form>\r\n");
#nullable restore
#line 132 "C:\Users\Anirudh\Documents\Software Engineering\Visual Studio 2019\Oasis\Oasis\Views\SellerDashboard\Dashboard.cshtml"
						c++;
					}
				}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"			</div>
			<div class=""grid-right-content"">
				<h4>Your Messages</h4>
			</div>
		</div>
		<nav id=""bottomnav"">
			<button id=""additems"" class=""float-right bottom-nav-buttons"" onclick=""PopupToggle('wizard');HideForm('optionswizard', 'optionssetup');HideForm('graphwizard', 'graphsetup')"">Add Items to Sell</button>
			<button id=""options"" class=""float-left bottom-nav-buttons"" onclick=""PopupToggle('optionswizard');HideForm('wizard', 'itemwizard');HideForm('graphwizard', 'graphsetup')"">Options</button>
			<button id=""addgraph"" class=""float-left bottom-nav-buttons"" onclick=""PopupToggle('graphwizard');HideForm('optionswizard', 'optionssetup');HideForm('wizard', 'itemwizard')"">Add Graph</button>
		</nav>
		");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "478f85ad21b21dead73a3ff4601655f9bca006e826130", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "478f85ad21b21dead73a3ff4601655f9bca006e827230", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Oasis.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
