#pragma checksum "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01a2a33b873fdf0a636fb2c9b6bd950d2deb44bf"
// <auto-generated/>
#pragma warning disable 1591
namespace TestServelessWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using TestServelessWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\_Imports.razor"
using TestServelessWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
using TestServelessWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
using System.Net.Mime;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fooditemlist")]
    public partial class FoodItemList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<label>Your Name?</label>\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
              FoodItemName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FoodItemName = __value, FoodItemName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<br>\r\n");
            __builder.AddMarkupContent(5, "<label>What are you Bringing?</label>\r\n");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
              FoodItemPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FoodItemPerson = __value, FoodItemPerson));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n");
            __builder.AddMarkupContent(10, "<label>Vegetarian?</label>\r\n");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "checkbox");
            __builder.AddAttribute(13, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
                              FoodItemVegetarian

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FoodItemVegetarian = __value, FoodItemVegetarian));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n<br>\r\n");
            __builder.AddMarkupContent(16, "<label>Gluten Free?</label>\r\n");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "checkbox");
            __builder.AddAttribute(19, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
                              FoodItemGlutenFree

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FoodItemGlutenFree = __value, FoodItemGlutenFree));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n<br>\r\n");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "type", "submit");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
                                 AddFoodItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Add Food Item");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n");
            __builder.OpenElement(27, "p");
#nullable restore
#line 23 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
__builder.AddContent(28, DisplayMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
 if (_foodItems != null)
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "table");
            __builder.AddAttribute(30, "class", "table");
            __builder.AddMarkupContent(31, "<thead><tr><th scope=\"col\">Name</th>\r\n            <th scope=\"col\">Person</th>\r\n            <th scope=\"col\">Gluten Free?</th>\r\n            <th scope=\"col\">Vegetarian?</th></tr></thead>\r\n        ");
            __builder.OpenElement(32, "tbody");
#nullable restore
#line 37 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
         foreach (var fooditem in _foodItems)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "tr");
            __builder.OpenElement(34, "td");
#nullable restore
#line 40 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
__builder.AddContent(35, fooditem.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
#nullable restore
#line 41 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
__builder.AddContent(38, fooditem.Person);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
#nullable restore
#line 42 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
__builder.AddContent(41, fooditem.Glutenfree);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
#nullable restore
#line 43 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
__builder.AddContent(44, fooditem.Vegetarian);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
                                        () => DeleteFoodItem(@fooditem.ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "DELETE");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
}
else
{
    DisplayMessage = "Hello!";
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\popad\UNI\SIXTH_SEMESTER\SEP6\TestCode\ServelessWebApp\TestServelessWebApp\TestServelessWebApp\Pages\FoodItemList.razor"
 
    public string DisplayMessage { get; set; }
    public FoodItem[] _foodItems { get; set; }
    
    public string FoodItemName { get; set; }
    public string FoodItemPerson { get; set; }
    public bool FoodItemVegetarian { get; set; }
    public bool FoodItemGlutenFree { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        DisplayMessage = "hello!";
        await PopulateTable();
    }
    
    private async Task PopulateTable()
    {

        HttpClient client = new HttpClient { BaseAddress = new Uri("https://foodtestserveless.azurewebsites.net/api/fooditem?") };

        HttpResponseMessage response = null;

        response = await client.GetAsync(client.BaseAddress);

        if (response.Content is object && response.Content.Headers.ContentType.MediaType == "application/json")
        {
            var content = await response.Content.ReadAsStringAsync();
            _foodItems = JsonSerializer.Deserialize<FoodItem[]>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
    
    private async Task AddFoodItem()
    {

        HttpClient client = new HttpClient { BaseAddress = new Uri("https://foodtestserveless.azurewebsites.net/api/fooditem?") };

        HttpResponseMessage response = null;

        var payload = new FoodItem()
        {
            Name = FoodItemName,
            Person = FoodItemPerson,
            Vegetarian = FoodItemVegetarian,
            Glutenfree = FoodItemGlutenFree
        };

        var payloadString = new StringContent(System.Text.Json.JsonSerializer.Serialize(payload), Encoding.UTF8, MediaTypeNames.Application.Json);

        response = await client.PostAsync(client.BaseAddress, payloadString);

        if (response.IsSuccessStatusCode)
        {
            await PopulateTable();
            DisplayMessage = "added!";
        }
        else
        {
            DisplayMessage = response.StatusCode.ToString() + "\n" + client.BaseAddress.ToString();
        }
    }
    
    private async Task DeleteFoodItem(string id)
    {
        HttpClient client = new HttpClient { BaseAddress = new Uri("https://foodtestserveless.azurewebsites.net/api/fooditem/" + id) };

        HttpResponseMessage response = null;

        response = await client.DeleteAsync(client.BaseAddress);

        if (response.IsSuccessStatusCode)
        {
            DisplayMessage = "We deleted: " + id;
        }

        await PopulateTable();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591