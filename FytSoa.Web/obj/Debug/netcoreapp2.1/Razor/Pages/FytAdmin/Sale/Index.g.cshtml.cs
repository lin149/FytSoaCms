#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "369dc4fe65dcbdc8243d6bf85945ee7a9c50e009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_Index), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sale/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sale/Index.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_Index), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sale
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"369dc4fe65dcbdc8243d6bf85945ee7a9c50e009", @"/Pages/FytAdmin/Sale/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sale_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/modules/vue.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Index.cshtml"
  
    ViewData["Title"] = "销售明细";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(142, 1110, true);
            WriteLiteral(@"<div id=""container"">
    <style>
        .layui-col-220 {
            width: 388px;
            top: 80px;
            left: 12px;
        }

            .layui-col-220 .layui-nav-title {
                height: 42px;
                line-height: 42px;
            }

        .right-col-body {
            left: 400px;
            top: 60px;
        }

        .layui-card {
            background-color: #eaedf1;
            margin-top: 10px;
            box-shadow: 0 1px 2px 0 rgba(0,0,0,.3);
        }

        .layui-card-header {
            border-bottom: 1px solid #D9DEE4;
        }

        .fyt-table {
            width: 100%;
        }

            .fyt-table th {
                width: 15%
            }
    </style>
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
            </div>
            <div class=""l");
            WriteLiteral("ayui-inline\">\r\n                <select id=\"shops\" lay-search=\"\">\r\n                    ");
            EndContext();
            BeginContext(1252, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7d642c8b4db43a8b7dfabea176044fc", async() => {
                BeginContext(1269, 11, true);
                WriteLiteral("--可根据店铺搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1289, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Index.cshtml"
                      
                        foreach (var item in Model.shopList)
                        {

#line default
#line hidden
            BeginContext(1404, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1432, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67d971dc89dd47be91a4baf206b7cb87", async() => {
                BeginContext(1460, 13, false);
#line 54 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Index.cshtml"
                                                  Write(item.ShopName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 54 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Index.cshtml"
                               WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1482, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1534, 159, true);
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"layui-inline\">\r\n                <select id=\"branks\" lay-search=\"\">\r\n                    ");
            EndContext();
            BeginContext(1693, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83194dda920a4c17a6e8fecfe4763d75", async() => {
                BeginContext(1710, 11, true);
                WriteLiteral("--可根据品牌搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1730, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 62 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Index.cshtml"
                      
                        foreach (var item in Model.codeList)
                        {

#line default
#line hidden
            BeginContext(1845, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1873, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97001239ed9644a6bace0cb3df607c1a", async() => {
                BeginContext(1901, 9, false);
#line 65 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Index.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 65 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Index.cshtml"
                               WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1919, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 66 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1971, 645, true);
            WriteLiteral(@"                </select>
            </div>
            <div class=""layui-inline lay-time-icon"">
                <input class=""layui-input"" id=""times"" autocomplete=""off"" placeholder=""时间区间""><i class=""layui-icon layui-icon-date""></i>
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
    </div>
    <div class=""layui-col-220"" id=""app"">
        <div class=""layui-nav-title"">销售订单列表　　　</div>
        <ul class=""fyt-utree"">
            <li v-for=""it in list"" v-cloak :class=""{active: activeName == it.number}"" ");
            EndContext();
            BeginContext(2617, 75, true);
            WriteLiteral("@click=\"selected(it.number)\">\r\n                <a class=\"layui-elip title\" ");
            EndContext();
            BeginContext(2693, 1873, true);
            WriteLiteral(@"@click=""getList(it)"">
                    <span class=""layui-badge layui-bg-cyan"" v-if=""it.saleType==1"">正</span>
                    <span class=""layui-badge layui-bg-cyan"" v-if=""it.saleType==2"">残</span>
                    {{it.number}}——{{it.shopName}}
                </a>
                <a class=""layui-elip sums""><span class=""layui-badge layui-bg-blue"">{{it.counts}}</span></a>
            </li>
        </ul>
    </div>
    <div class=""right-col-body"" id=""orders"">
        <div class=""list-wall"">
            <div class=""layui-card"">
                <div class=""layui-card-header"">订单详情</div>
                <div class=""layui-card-body"">
                    <table class=""fyt-table"">
                        <tr>
                            <th>订单编号：</th>
                            <td>{{curModel.number}}</td>
                            <th>下单时间：</th>
                            <td>{{curModel.addDate}}</td>
                            <th>数量：</th>
                            <td>{{curMode");
            WriteLiteral(@"l.counts}}</td>
                        </tr>
                        <tr>
                            <th>参加活动：</th>
                            <td>{{curModel.activityName}}</td>
                            <th>应收金额：</th>
                            <td><span class=""layui-badge layui-bg-cyan"">{{curModel.money}}</span></td>
                            <th>实收金额：</th>
                            <td><span class=""layui-badge layui-bg-blue"">{{curModel.realMoney}}</span></td>
                        </tr>
                    </table>
                </div>
            </div>
            <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
        </div>
    </div>
    <script type=""text/html"" id=""toolbar"">
        <div class=""layui-btn-container"">
            <h4>订单商品详情</h4>
        </div>
    </script>
    ");
            EndContext();
            BeginContext(4566, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad14e435a1794005bda24efc21aaf2e6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4639, 4308, true);
            WriteLiteral(@"
    <script>
        var funTool, vm = new Vue({
            el: ""#app"",
            data: {
                list: [],
                activeName: '',
                parm: {
                    guid: ''
                }
            },
            methods: {
                selected: function (m) {
                    this.activeName = m;
                },
                getList: function (m) {
                    vues.curModel = m;
                    funTool.getGoodsSku(m);
                }
            }
        });
        var vues = new Vue({
            el: ""#orders"",
            data: {
                curModel: {
                    money: 0,
                    realMoney: 0
                },
            }
        });
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'form', 'common', 'laydate'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
  ");
            WriteLiteral(@"                  $ = layui.jquery,
                    os = layui.common,
                    laydate = layui.laydate,
                    form = layui.form;
                form.render('select');
                $(""ul.fyt-utree"").css({ 'height': $(window).height() - 182 });
                laydate.render({
                    elem: '#times'
                    , theme: '#393D49'
                    , range: true
                });
                table.render({
                    toolbar: '#toolbar',
                    elem: '#tablist',
                    url: '/api/sale/goods',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'code', width: 200, title: '条形码', fixed: 'left' },
                            { field: 'brandName', title: '品牌' },
                            { field: 'styleName', title: '款式' },
                            { field: 'seasonName', width: 150, title: '季节'");
            WriteLiteral(@" },
                            { field: 'counts', title: '销售数' }
                        ]
                    ],
                    page: { limits: [10, 20, 50, 100, 500, 1000, 5000, 10000], groups: 8 },
                    limit: 10,
                    id: 'tables'
                });


                var orderguid = '', shopGuid = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    guid: orderguid,
                                    key: $('#key').val(),
                                    brank: $('#branks').val(),
                                    shopGuid: $(""#shops"").val()
                                }
                            });
                    },
                    toolSearch: functi");
            WriteLiteral(@"on () {
                        vm.parm.guid = $(""#shops"").val();
                        active.reload();
                        if (vm.parm.guid != '') {
                            funTool.orderPage();
                        }
                    }
                };

                funTool = {
                    getGoodsSku: function (obj) {
                        orderguid = obj.number;
                        active.reload();
                    },
                    orderPage: function () {
                        os.ajax('api/sale/order', vm.parm, function (res) {
                            if (res.statusCode === 200) {
                                vm.list = res.data.items;
                            } else {
                                os.error(res.message);
                            }
                        });
                    }
                }
                //初始化入库单管理
                funTool.orderPage();
                $('.list-search .layui-btn'");
            WriteLiteral(").on(\'click\', function () {\r\n                    var type = $(this).data(\'type\');\r\n                    active[type] ? active[type].call(this) : \'\';\r\n                });\r\n            });\r\n    </script>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sale.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.IndexModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sale.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
