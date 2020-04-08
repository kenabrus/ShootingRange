#pragma checksum "C:\Users\kenabrus\Desktop\Blazor\ShootingRange\ShootingRange.Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3555341764aebf1f588414787d740d2ffe0aac3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ShootingRange.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kenabrus\Desktop\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kenabrus\Desktop\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kenabrus\Desktop\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kenabrus\Desktop\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kenabrus\Desktop\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kenabrus\Desktop\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using ShootingRange.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kenabrus\Desktop\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using ShootingRange.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kenabrus\Desktop\Blazor\ShootingRange\ShootingRange.Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kenabrus\Desktop\Blazor\ShootingRange\ShootingRange.Client\Pages\FetchData.razor"
using ShootingRange.Shared.Dto;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\kenabrus\Desktop\Blazor\ShootingRange\ShootingRange.Client\Pages\FetchData.razor"
       
    bool createUserDialogOpen = false;
    private const string URL = "http://localhost:5005";

    //private WeatherForecast[] forecasts;
    private List<WeatherForecast> forecasts;
    private ApiResponseDto apiResponseDto;

    [Parameter]
    public string Info {get; set;} = "Info";

    protected override async Task OnInitializedAsync()
    {
        // forecasts = await Http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        // forecasts = await Http.GetJsonAsync<WeatherForecast[]>("${URL}+WeatherForecast");
        await  WeatherForecastAsync();
    }

    public async Task WeatherForecastAsync()
    {
        // apiResponseDto = await Http.GetJsonAsync<ApiResponseDto>($"api/Admin/Users?pageSize={pageSize}&pageNumber={currentPage}");
        apiResponseDto = await Http.GetJsonAsync<ApiResponseDto>($"{URL}/api/WeatherForecast");

        if (apiResponseDto.StatusCode == 200)
        {
            Info = "ApiResponseDto == 200";
            forecasts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WeatherForecast>>(apiResponseDto.Result.ToString());
        }
        else
        {
            Info = "ApiResponseDto != 200";
        }
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster matToaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
