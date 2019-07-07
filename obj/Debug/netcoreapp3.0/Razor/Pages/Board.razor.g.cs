#pragma checksum "D:\.NET Projects\.NET Core Projects\BlazorApplications\FirstApp\WebApplicationClient\Pages\Board.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7d8fc1ec611adbdd5e679c4edbcf1f71ba42d77"
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
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/board")]
    public class Board : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddMarkupContent(1, "\r\n    ");
            builder.OpenElement(2, "div");
            builder.AddAttribute(3, "class", "status");
            builder.AddContent(4, "Next Player : ");
            builder.AddContent(5, nextPlayer);
            builder.CloseElement();
            builder.AddMarkupContent(6, "\r\n    ");
            builder.OpenElement(7, "div");
            builder.AddAttribute(8, "class", "status");
            builder.AddContent(9, status);
            builder.CloseElement();
            builder.AddMarkupContent(10, "\r\n\r\n    ");
            builder.OpenElement(11, "div");
            builder.AddAttribute(12, "class", "board-row");
            builder.AddMarkupContent(13, "\r\n        ");
            builder.OpenComponent<WebApplicationClient.Pages.Square>(14);
            builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(squares[0]));
            builder.AddAttribute(16, "index", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(0));
            builder.AddAttribute(17, "HandleClick", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, HandleClick)));
            builder.CloseComponent();
            builder.AddMarkupContent(18, "\r\n        ");
            builder.OpenComponent<WebApplicationClient.Pages.Square>(19);
            builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(squares[1]));
            builder.AddAttribute(21, "index", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(1));
            builder.AddAttribute(22, "HandleClick", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, HandleClick)));
            builder.CloseComponent();
            builder.AddMarkupContent(23, "\r\n        ");
            builder.OpenComponent<WebApplicationClient.Pages.Square>(24);
            builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(squares[2]));
            builder.AddAttribute(26, "index", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(2));
            builder.AddAttribute(27, "HandleClick", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, HandleClick)));
            builder.CloseComponent();
            builder.AddMarkupContent(28, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(29, "\r\n\r\n    ");
            builder.OpenElement(30, "div");
            builder.AddAttribute(31, "class", "board-row");
            builder.AddMarkupContent(32, "\r\n        ");
            builder.OpenComponent<WebApplicationClient.Pages.Square>(33);
            builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(squares[3]));
            builder.AddAttribute(35, "index", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(3));
            builder.AddAttribute(36, "HandleClick", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, HandleClick)));
            builder.CloseComponent();
            builder.AddMarkupContent(37, "\r\n        ");
            builder.OpenComponent<WebApplicationClient.Pages.Square>(38);
            builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(squares[4]));
            builder.AddAttribute(40, "index", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(4));
            builder.AddAttribute(41, "HandleClick", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, HandleClick)));
            builder.CloseComponent();
            builder.AddMarkupContent(42, "\r\n        ");
            builder.OpenComponent<WebApplicationClient.Pages.Square>(43);
            builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(squares[5]));
            builder.AddAttribute(45, "index", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(5));
            builder.AddAttribute(46, "HandleClick", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, HandleClick)));
            builder.CloseComponent();
            builder.AddMarkupContent(47, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(48, "\r\n\r\n    ");
            builder.OpenElement(49, "div");
            builder.AddAttribute(50, "class", "board-row");
            builder.AddMarkupContent(51, "\r\n        ");
            builder.OpenComponent<WebApplicationClient.Pages.Square>(52);
            builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(squares[6]));
            builder.AddAttribute(54, "index", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(6));
            builder.AddAttribute(55, "HandleClick", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, HandleClick)));
            builder.CloseComponent();
            builder.AddMarkupContent(56, "\r\n        ");
            builder.OpenComponent<WebApplicationClient.Pages.Square>(57);
            builder.AddAttribute(58, "value", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(squares[7]));
            builder.AddAttribute(59, "index", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(7));
            builder.AddAttribute(60, "HandleClick", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, HandleClick)));
            builder.CloseComponent();
            builder.AddMarkupContent(61, "\r\n        ");
            builder.OpenComponent<WebApplicationClient.Pages.Square>(62);
            builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(squares[8]));
            builder.AddAttribute(64, "index", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(8));
            builder.AddAttribute(65, "HandleClick", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, HandleClick)));
            builder.CloseComponent();
            builder.AddMarkupContent(66, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(67, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 26 "D:\.NET Projects\.NET Core Projects\BlazorApplications\FirstApp\WebApplicationClient\Pages\Board.razor"
            
    string status = "";
    string nextPlayer = "X";
    string winner = "";
    bool continueGame = true;
    string[] squares = new string[9]{null, null, null, null, null , null, null, null, null};

    private void HandleClick(int index)
    {
        
        if(squares[index] == null && continueGame){
            squares[index] = nextPlayer;
            if(nextPlayer == "X"){
                nextPlayer = "0";
            }
            else{
                nextPlayer = "X";
            }
        }

        CalculateWinner();
        if(!continueGame){
            status = "winner is "+ winner;
        }
        else if(!(Array.IndexOf(squares,null) >= 0) && continueGame){
            continueGame = false;
            status = "Game Tied";
        }
        
    }

    private void CalculateWinner()
    {
        var lines = new int[8,3]{
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
            };
        
        for(int i = 0; i<8; i++){
            if(squares[lines[i,0]]!=null
             && squares[lines[i,0]] == squares[lines[i,1]]
             && squares[lines[i,0]] == squares[lines[i,2]]){
                continueGame = false;
                winner = squares[lines[i,0]];
                return;
            }
        }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591