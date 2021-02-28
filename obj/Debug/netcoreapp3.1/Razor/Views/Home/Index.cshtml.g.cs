#pragma checksum "F:\Projects\Task\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40e1966320e1a1b86e699615fd80a536562bafb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "F:\Projects\Task\Views\_ViewImports.cshtml"
using poc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Task\Views\_ViewImports.cshtml"
using poc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e1966320e1a1b86e699615fd80a536562bafb2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"245fa154e55ab95c6cf3d3b3a6ab1bd2f0e80c39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Projects\Task\Views\Home\Index.cshtml"
  

    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .line {
        fill: none;
        stroke: steelblue;
        stroke-width: 2px;
    }

    .area {
        fill: lightsteelblue;
    }

    .bar {
        fill: steelblue;
    }

    polyline {
        opacity: .3;
        stroke: black;
        stroke-width: 2px;
        fill: none;
    }

    /* Make the percentage on the text labels bold*/
    .labelName tspan {
        font-style: normal;
        font-weight: 700;
    }

    /* In biology we generally italicise species names. */
    .labelName {
        font-size: 0.9em;
        font-style: italic;
    }

    .graphHeight {
        height: 35opx;
    }

    #areaChart,
    #companyChart,
    #bankChart {
        height: 400px;
    }

    .card-header {
        text-transform: uppercase;
        font-weight: bold;
        line-height: 1.2em;
        word-spacing: normal;
        background-color: lightyellow;
        border: none;
    }

    select {
        width: 100%;
       
    }
</style>

<section>

    <div class=""card mb-1"">
        ");
            WriteLiteral(@"<div class=""card-body"">
            <div class=""row col-md-12"">
                <div class=""col-md-6"">
                    <h5>Bank Position Summary</h5>
                </div>
                <div class=""col-md-6"">
                    <div class=""row"">
                        <div class=""col-md-4 text-center"" style=""color:green; font-weght:bolder"">
                            <h4 class=""m-0"">406.9M</h4>
                            <div style=""font-weght:bolder"">Surplus</div>
                        </div>
                        <div class=""col-md-4 text-center"" style=""color:red;font-weght:bolder"">
                            <h4 class=""m-0"">107.9M</h4>
                            <div style=""font-weght:bolder"">Overdraft</div>
                        </div>
                        <div class=""col-md-4 text-center"" style=""font-weght:bolder"">
                            <h4 class=""m-0"">299.0M</h4>
                            <div style=""font-weght:bolder"">Net Balance</div>
                        </div>
      ");
            WriteLiteral(@"              </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""card mb-1"">
        <div class=""card-body"">
            <div class=""row col-md-12"">
                <div class=""col-md-2"">
                    <div class=""control-label"">Entity</div>
                    <div>");
#nullable restore
#line 98 "F:\Projects\Task\Views\Home\Index.cshtml"
                    Write(Html.DropDownList("parent", Enumerable.Empty<SelectListItem>(), "--Select Entity--", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                </div>\n                <div class=\"col-md-3\">\n                    <div class=\"control-label\">Bank Name</div>\n                    <div>");
#nullable restore
#line 102 "F:\Projects\Task\Views\Home\Index.cshtml"
                    Write(Html.DropDownList("parent", Enumerable.Empty<SelectListItem>(), "--Select Bank--", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                </div>\n                <div class=\"col-md-3\">\n                    <div class=\"control-label\">Currency</div>\n                    <div>");
#nullable restore
#line 106 "F:\Projects\Task\Views\Home\Index.cshtml"
                    Write(Html.DropDownList("parent", Enumerable.Empty<SelectListItem>(), "--Select Currency--", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
                <div class=""col-md-4"">
                    <div class=""control-label"">Date</div>
                    <div class=""row"">
                        <div class=""col-md-8"">
                        <input type=""date"" id=""datepicker"" class=""form-control""></div>
                        <div class=""col-md-4"">
                          <input type=""button"" value=""Search"" class=""btn btn-primary""></div>
                    </div>
                </div>
");
            WriteLiteral(@"            </div>
        </div>

    </div>

    <div class=""row col-md-12 mb-2"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    Daily Bank Balance Movement
                </div>
                <div class=""card-body"">
                    <div id=""areaChart"" class=""graphHeight"">

                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row col-md-12"">
        <div class=""col-md-6 pr-1"">
            <div class=""card"">
                <div class=""card-header"">
                    Company wise Bank Balance
                </div>
                <div class=""card-body"">
                    <div id=""companyChart"" class=""graphHeight"">

                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-6 pl-1"">
            <div class=""card"">
                <div class=""card-header"">
                    Bank wise Bank balance
                ");
            WriteLiteral(@"</div>
                <div class=""card-body"">
                    <div id=""bankChart"" class=""graphHeight"">

                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<script type=""text/javascript"">

    var chartData;
    var updatedData = [];
    var comapanyData = [];
    var bankData = [];
    var completeData;

    $(document).ready(function () {
        //alert('page loaded');
        $.getJSON(""json/data.json"", function (data) {
            completeData = data;
            chartData = data.Sheet1.filter(x => x.Division == ""Division 2"" && x.Currency == ""INR"");
            prepareData(chartData);
            areaChart(updatedData);

            prepareCompanyData(completeData.Sheet1);
            barChart(comapanyData);
            //console.log(comapanyData);
            prepareBankData(completeData.Sheet1);

            donutChart(bankData);


        })
    })


    function prepareData(data) {
        data.forEach((value, index) => {

            if (u");
            WriteLiteral(@"pdatedData && updatedData.filter(x => x.BankBalanceDate == value.BankBalanceDate).length <= 0) {
                updatedData.push(value);
            } else {
                let existingData = updatedData.filter(x => x.BankBalanceDate == value.BankBalanceDate)[0];
                existingData.BankBalanceAmount = +existingData.BankBalanceAmount + (+value.BankBalanceAmount)
            }
        })
    }

    function prepareCompanyData(data) {
        debugger;
        data.forEach((value, index) => {
            if (comapanyData && comapanyData.filter(x => x.EntityId == value.EntityId).length <= 0) {
                comapanyData.push(value)
            } else {
                let tempData = comapanyData.filter(x => x.EntityId == value.EntityId)[0];
                tempData.BankBalanceAmount += value.BankBalanceAmount;
            }
        })
    }

    function prepareBankData(data) {
        data.forEach((value, index) => {
            if (bankData && bankData.filter(x => x.BankName == value.BankName).len");
            WriteLiteral(@"gth <= 0) {
                bankData.push(value)
            } else {
                let tempData = bankData.filter(x => x.BankName == value.BankName)[0];
                tempData.BankBalanceAmount += value.BankBalanceAmount;
            }
        })
    }

    function areaChart(data) {

        let bindingElementWidth = $('#areaChart').width();
        let bindingElementHeight = $('#areaChart').height();
        var margin = { top: 20, right: 20, bottom: 30, left: 100 },
            width = bindingElementWidth - margin.left - margin.right,
            height = bindingElementHeight - margin.top - margin.bottom;



        var dateFormat = d3.timeFormat(""%d-%m-%y"")
        var parseTime = d3.timeParse(""%m/%d/%y"");


        var x = d3.scaleTime().range([0, width]);
        var y = d3.scaleLinear().range([height, 0]);


        var area = d3.area()
            .x(function (d) { return x(d.date); })
            .y0(height)
            .y1(function (d) { return y(+d.close); });


        var valueline = d3.line");
            WriteLiteral(@"()
            .x(function (d) { return x(d.date); })
            .y(function (d) { return y(+d.close); });


        var svg = d3.select(""#areaChart"").append(""svg"")
            .attr(""width"", width + margin.left + margin.right)
            .attr(""height"", height + margin.top + margin.bottom)
            .append(""g"")
            .attr(""transform"",
                ""translate("" + margin.left + "","" + margin.top + "")"");

        data.forEach(function (d) {

            d.date = parseTime((d.BankBalanceDate));
            d.close = +d.BankBalanceAmount;
        });


        data.sort((a, b) => b.date - a.date)
        console.log(data);
        // scale the range of the data
        x.domain(d3.extent(data, function (d) { return d.date; }));
        y.domain([0, d3.max(data, function (d) { return d.close; })]);

        // add the area
        svg.append(""path"")
            .data([data])
            .attr(""class"", ""area"")
            .attr(""d"", area);

        // add the valueline path.
        svg.append(""path"")");
            WriteLiteral(@"
            .data([data])
            .attr(""class"", ""line"")
            .attr(""d"", valueline);

        // add the X Axis
        svg.append(""g"")
            .attr(""transform"", ""translate(0,"" + height + "")"")
            .call(d3.axisBottom(x));

        // add the Y Axis
        svg.append(""g"")
            .call(d3.axisLeft(y));

    }

    function barChart(data) {
        let bindingElementWidth = $('#companyChart').width();
        let bindingElementHeight = $('#companyChart').height();
        var margin = { top: 20, right: 20, bottom: 30, left: 50 },
            width = bindingElementWidth - margin.left - margin.right,
            height = bindingElementHeight - margin.top - margin.bottom;

        // set the ranges
        var y = d3.scaleBand()
            .range([height, 0])
            .padding(0.1);

        var x = d3.scaleLinear()
            .range([0, width]);

        // append the svg object to the body of the page
        // append a 'group' element to 'svg'
        // moves the 'group' ele");
            WriteLiteral(@"ment to the top left margin
        var svg = d3.select(""#companyChart"").append(""svg"")
            .attr(""width"", width + margin.left + margin.right)
            .attr(""height"", height + margin.top + margin.bottom)
            .append(""g"")
            .attr(""transform"",
                ""translate("" + margin.left + "","" + margin.top + "")"");

        // format the data
        data.forEach(function (d) {
            d.BankBalanceAmount = +d.BankBalanceAmount;
        });

        // Scale the range of the data in the domains
        x.domain([0, d3.max(data, function (d) { return d.BankBalanceAmount; })])
        y.domain(data.map(function (d) { return d.EntityId; }));
        //y.domain([0, d3.max(data, function(d) { return d.sales; })]);

        // append the rectangles for the bar chart
        svg.selectAll("".bar"")
            .data(data)
            .enter().append(""rect"")
            .attr(""class"", ""bar"")
            .attr(""width"", function (d) { return x(d.BankBalanceAmount); })
            .attr(""y"", fu");
            WriteLiteral(@"nction (d) { return y(d.EntityId); })
            .attr(""height"", y.bandwidth());

        // add the x Axis
        svg.append(""g"")
            .attr(""transform"", ""translate(0,"" + height + "")"")
            .call(d3.axisBottom(x));

        // add the y Axis
        svg.append(""g"")
            .call(d3.axisLeft(y));
    }

    function donutChart(data) {
        let bindingElementWidth = $('#bankChart').width();
        let bindingElementHeight = $('#bankChart').height();
        var svg = d3.select(""#bankChart"").append(""svg"")
            .attr(""width"", bindingElementWidth)
            .attr(""height"", bindingElementHeight)
            .append(""g"");

        svg.append(""g"")
            .attr(""class"", ""slices"");
        svg.append(""g"")
            .attr(""class"", ""labels"");
        svg.append(""g"")
            .attr(""class"", ""lines"");
        var width = 500;
        var height = 400;
        var radius = Math.min(width, height) / 2;
        var color = d3.scaleOrdinal(d3.schemeCategory20);
        //var data = [");
            WriteLiteral(@"26, 25, 10, 30, 30, 50, 33, 56, 38];

        var tempData = [];
        data.forEach((value) => {
            tempData.push(value.BankBalanceAmount);
        });

        console.log(tempData)
        tempData = [26, 25, 10, 30, 30, 50, 33, 56, 38];

        var pie = d3.pie().sort(null).value(d => d);
        var arc = d3.arc().innerRadius(radius * 0.8).outerRadius(radius * 0.6);

        var outerArc = d3.arc()
            .outerRadius(radius * 0.9)
            .innerRadius(radius * 0.9);

        svg.attr(""transform"", ""translate("" + width / 2 + "","" + height / 2 + "")"");

        svg.selectAll('path')
            .data(pie(tempData))
            .enter()
            .append('path')
            .attr('d', arc)
            .attr('fill', (d, i) => color(i));
        svg.append('g').classed('labels', true);
        svg.append('g').classed('lines', true);


        var polyline = svg.select('.lines')
            .selectAll('polyline')
            .data(pie(tempData))
            .enter().append('polyline')
     ");
            WriteLiteral(@"       .attr('points', function (d) {

                // see label transform function for explanations of these three lines.
                var pos = outerArc.centroid(d);
                pos[0] = radius * 0.95 * (midAngle(d) < Math.PI ? 1 : -1);
                return [arc.centroid(d), outerArc.centroid(d), pos]
            });



        var label = svg.select('.labels').selectAll('text')
            .data(pie(tempData))
            .enter().append('text')
            .attr('dy', '.35em')
            .html(function (d) {
                return d.data;
            })
            .attr('transform', function (d) {
                var pos = outerArc.centroid(d);
                pos[0] = radius * 0.95 * (midAngle(d) < Math.PI ? 1 : -1);
                return 'translate(' + pos + ')';
            })
            .style('text-anchor', function (d) {
                return (midAngle(d)) < Math.PI ? 'start' : 'end';
            });

        svg.append('text')
            .attr('class', 'toolCircle')
            .a");
            WriteLiteral(@"ttr('dy', -15) // hard-coded. can adjust this to adjust text vertical alignment in tooltip
            .html() // add text to the circle.
            .style('font-size', '.9em')
            .style('text-anchor', 'middle');

        function midAngle(d) { return d.startAngle + (d.endAngle - d.startAngle) / 2; }
    }
</script>");
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
