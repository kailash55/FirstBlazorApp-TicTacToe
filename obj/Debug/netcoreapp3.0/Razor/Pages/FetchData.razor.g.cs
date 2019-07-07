#pragma checksum "D:\.NET Projects\.NET Core Projects\BlazorApplications\FirstApp\WebApplicationClient\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76736e01ba9c5b7c83579dacb0ea911e210c02ed"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplicationClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using WebApplicationClient.Shared;
    using WebApplicationClient.Data;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#line 9 "D:\.NET Projects\.NET Core Projects\BlazorApplications\FirstApp\WebApplicationClient\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
            builder.AddContent(2, "    ");
            builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#line 12 "D:\.NET Projects\.NET Core Projects\BlazorApplications\FirstApp\WebApplicationClient\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
            builder.AddContent(4, "    ");
            builder.OpenElement(5, "table");
            builder.AddAttribute(6, "class", "table");
            builder.AddMarkupContent(7, "\r\n        ");
            builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            builder.OpenElement(9, "tbody");
            builder.AddMarkupContent(10, "\r\n");
#line 25 "D:\.NET Projects\.NET Core Projects\BlazorApplications\FirstApp\WebApplicationClient\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
            builder.AddContent(11, "                ");
            builder.OpenElement(12, "tr");
            builder.AddMarkupContent(13, "\r\n                    ");
            builder.OpenElement(14, "td");
            builder.AddContent(15, forecast.Date.ToShortDateString());
            builder.CloseElement();
            builder.AddMarkupContent(16, "\r\n                    ");
            builder.OpenElement(17, "td");
            builder.AddContent(18, forecast.TemperatureC);
            builder.CloseElement();
            builder.AddMarkupContent(19, "\r\n                    ");
            builder.OpenElement(20, "td");
            builder.AddContent(21, forecast.TemperatureF);
            builder.CloseElement();
            builder.AddMarkupContent(22, "\r\n                    ");
            builder.OpenElement(23, "td");
            builder.AddContent(24, forecast.Summary);
            builder.CloseElement();
            builder.AddMarkupContent(25, "\r\n                ");
            builder.CloseElement();
            builder.AddMarkupContent(26, "\r\n");
#line 33 "D:\.NET Projects\.NET Core Projects\BlazorApplications\FirstApp\WebApplicationClient\Pages\FetchData.razor"
            }

#line default
#line hidden
            builder.AddContent(27, "        ");
            builder.CloseElement();
            builder.AddMarkupContent(28, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(29, "\r\n");
#line 36 "D:\.NET Projects\.NET Core Projects\BlazorApplications\FirstApp\WebApplicationClient\Pages\FetchData.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 38 "D:\.NET Projects\.NET Core Projects\BlazorApplications\FirstApp\WebApplicationClient\Pages\FetchData.razor"
            
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
