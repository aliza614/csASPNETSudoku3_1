#pragma checksum "C:\Users\Owner\repos\csASPNETSudoku3_1\csASPNETSudoku3_1\Views\Sudoku\ViewSudoku.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb8f7ef3de6e73e0e631e275c1d259db4a8f3a80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sudoku_ViewSudoku), @"mvc.1.0.view", @"/Views/Sudoku/ViewSudoku.cshtml")]
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
#line 1 "C:\Users\Owner\repos\csASPNETSudoku3_1\csASPNETSudoku3_1\Views\_ViewImports.cshtml"
using csASPNETSudoku3_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\repos\csASPNETSudoku3_1\csASPNETSudoku3_1\Views\_ViewImports.cshtml"
using csASPNETSudoku3_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb8f7ef3de6e73e0e631e275c1d259db4a8f3a80", @"/Views/Sudoku/ViewSudoku.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b32ee9c1496b0e7fe572b32a656feaabaf4e1fa9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Sudoku_ViewSudoku : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sudoku>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to Sudoku</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    \r\n\r\n\r\n<div class=\"table\"> \r\n");
#nullable restore
#line 19 "C:\Users\Owner\repos\csASPNETSudoku3_1\csASPNETSudoku3_1\Views\Sudoku\ViewSudoku.cshtml"
     for(var i=0;i<Model.Sudoku_problem.Length;i++)
    {   
            String val = ""+Model.Sudoku_problem[i];
            //if (val == "0") val = new String(" ");
            String mainClass = "input-box ";
            String right_borderClass = "";
            if (i % 9 == 8 || i % 9 == 2 || i % 9 == 5) right_borderClass = "right-border ";
            String left_borderClass = "";
            if (i % 9 == 0 || i % 9 == 3 || i % 9 == 6) left_borderClass = "left-border ";
            String bottom_borderClass = "";
            if (i % 27>=18) bottom_borderClass = "bottom-border ";
            String top_borderClass = "";
            if (i % 27<=9) top_borderClass = "top-border ";
            string class_name = $"{mainClass}{right_borderClass}{left_borderClass}{bottom_borderClass}{top_borderClass}";
        Console.WriteLine(class_name);
        string inputid = "" + i;
            string inputname = "box" + i;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"number\"");
            BeginWriteAttribute("id", " id=", 1240, "", 1252, 1);
#nullable restore
#line 37 "C:\Users\Owner\repos\csASPNETSudoku3_1\csASPNETSudoku3_1\Views\Sudoku\ViewSudoku.cshtml"
WriteAttributeValue("", 1244, inputid, 1244, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onChange=\"Sudoku.CheckPossible()\"");
            BeginWriteAttribute("name", " name=", 1286, "", 1302, 1);
#nullable restore
#line 37 "C:\Users\Owner\repos\csASPNETSudoku3_1\csASPNETSudoku3_1\Views\Sudoku\ViewSudoku.cshtml"
WriteAttributeValue("", 1292, inputname, 1292, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=", 1302, "", 1331, 1);
#nullable restore
#line 37 "C:\Users\Owner\repos\csASPNETSudoku3_1\csASPNETSudoku3_1\Views\Sudoku\ViewSudoku.cshtml"
WriteAttributeValue("", 1309, class_name.ToString(), 1309, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 1331, "", 1342, 1);
#nullable restore
#line 37 "C:\Users\Owner\repos\csASPNETSudoku3_1\csASPNETSudoku3_1\Views\Sudoku\ViewSudoku.cshtml"
WriteAttributeValue("", 1338, val, 1338, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n");
#nullable restore
#line 38 "C:\Users\Owner\repos\csASPNETSudoku3_1\csASPNETSudoku3_1\Views\Sudoku\ViewSudoku.cshtml"
        if (i % 9 == 8)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n");
#nullable restore
#line 41 "C:\Users\Owner\repos\csASPNETSudoku3_1\csASPNETSudoku3_1\Views\Sudoku\ViewSudoku.cshtml"
            ;
        }

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</div>\r\n\r\n\r\n<br/>\r\n<br />\r\n<br />\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<div class=\"table\"> \r\n\r\n    \r\n <input type=\"number\" id=\"1\" onChange=\"Sudoku.CheckPossible()\" name=\"box00\"");
            BeginWriteAttribute("value", " value=\"", 1603, "\"", 1635, 1);
#nullable restore
#line 65 "C:\Users\Owner\repos\csASPNETSudoku3_1\csASPNETSudoku3_1\Views\Sudoku\ViewSudoku.cshtml"
WriteAttributeValue("", 1611, Model.Sudoku_problem[0], 1611, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border top-border\"/>\r\n    \r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box01\"");
            BeginWriteAttribute("value", " value=\"", 1744, "\"", 1752, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box02\"");
            BeginWriteAttribute("value", " value=\"", 1843, "\"", 1851, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box03\"");
            BeginWriteAttribute("value", " value=\"", 1955, "\"", 1963, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box04\"");
            BeginWriteAttribute("value", " value=\"", 2066, "\"", 2074, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box05\"");
            BeginWriteAttribute("value", " value=\"", 2165, "\"", 2173, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box06\"");
            BeginWriteAttribute("value", " value=\"", 2277, "\"", 2285, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box07\"");
            BeginWriteAttribute("value", " value=\"", 2388, "\"", 2396, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box08\"");
            BeginWriteAttribute("value", " value=\"", 2487, "\"", 2495, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border top-border\"/><br>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box09\"");
            BeginWriteAttribute("value", " value=\"", 2603, "\"", 2611, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box10\"");
            BeginWriteAttribute("value", " value=\"", 2704, "\"", 2712, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box11\"");
            BeginWriteAttribute("value", " value=\"", 2793, "\"", 2801, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box12\"");
            BeginWriteAttribute("value", " value=\"", 2895, "\"", 2903, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box13\"");
            BeginWriteAttribute("value", " value=\"", 2996, "\"", 3004, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box14\"");
            BeginWriteAttribute("value", " value=\"", 3085, "\"", 3093, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box15\"");
            BeginWriteAttribute("value", " value=\"", 3187, "\"", 3195, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box16\"");
            BeginWriteAttribute("value", " value=\"", 3288, "\"", 3296, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box17\"");
            BeginWriteAttribute("value", " value=\"", 3377, "\"", 3385, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border \"/><br>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box18\"");
            BeginWriteAttribute("value", " value=\"", 3483, "\"", 3491, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box19\"");
            BeginWriteAttribute("value", " value=\"", 3598, "\"", 3606, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box20\"");
            BeginWriteAttribute("value", " value=\"", 3701, "\"", 3709, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box21\"");
            BeginWriteAttribute("value", " value=\"", 3817, "\"", 3825, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box22\"");
            BeginWriteAttribute("value", " value=\"", 3932, "\"", 3940, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box23\"");
            BeginWriteAttribute("value", " value=\"", 4035, "\"", 4043, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box24\"");
            BeginWriteAttribute("value", " value=\"", 4151, "\"", 4159, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box25\"");
            BeginWriteAttribute("value", " value=\"", 4266, "\"", 4274, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box26\"");
            BeginWriteAttribute("value", " value=\"", 4369, "\"", 4377, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border bottom-border \"/><br>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box27\"");
            BeginWriteAttribute("value", " value=\"", 4489, "\"", 4497, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box28\"");
            BeginWriteAttribute("value", " value=\"", 4600, "\"", 4608, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box29\"");
            BeginWriteAttribute("value", " value=\"", 4699, "\"", 4707, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box30\"");
            BeginWriteAttribute("value", " value=\"", 4811, "\"", 4819, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box31\"");
            BeginWriteAttribute("value", " value=\"", 4922, "\"", 4930, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box32\"");
            BeginWriteAttribute("value", " value=\"", 5021, "\"", 5029, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box33\"");
            BeginWriteAttribute("value", " value=\"", 5133, "\"", 5141, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box34\"");
            BeginWriteAttribute("value", " value=\"", 5244, "\"", 5252, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box35\"");
            BeginWriteAttribute("value", " value=\"", 5343, "\"", 5351, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border top-border\"/><br>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box36\"");
            BeginWriteAttribute("value", " value=\"", 5459, "\"", 5467, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box37\"");
            BeginWriteAttribute("value", " value=\"", 5560, "\"", 5568, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box38\"");
            BeginWriteAttribute("value", " value=\"", 5649, "\"", 5657, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box39\"");
            BeginWriteAttribute("value", " value=\"", 5751, "\"", 5759, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box40\"");
            BeginWriteAttribute("value", " value=\"", 5852, "\"", 5860, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box41\"");
            BeginWriteAttribute("value", " value=\"", 5941, "\"", 5949, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box42\"");
            BeginWriteAttribute("value", " value=\"", 6043, "\"", 6051, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box43\"");
            BeginWriteAttribute("value", " value=\"", 6144, "\"", 6152, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box44\"");
            BeginWriteAttribute("value", " value=\"", 6233, "\"", 6241, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border \"/><br>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box45\"");
            BeginWriteAttribute("value", " value=\"", 6339, "\"", 6347, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box46\"");
            BeginWriteAttribute("value", " value=\"", 6454, "\"", 6462, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box47\"");
            BeginWriteAttribute("value", " value=\"", 6557, "\"", 6565, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box48\"");
            BeginWriteAttribute("value", " value=\"", 6673, "\"", 6681, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box49\"");
            BeginWriteAttribute("value", " value=\"", 6788, "\"", 6796, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box50\"");
            BeginWriteAttribute("value", " value=\"", 6891, "\"", 6899, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box51\"");
            BeginWriteAttribute("value", " value=\"", 7007, "\"", 7015, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box52\"");
            BeginWriteAttribute("value", " value=\"", 7122, "\"", 7130, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box53\"");
            BeginWriteAttribute("value", " value=\"", 7225, "\"", 7233, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border bottom-border \"/><br>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box54\"");
            BeginWriteAttribute("value", " value=\"", 7345, "\"", 7353, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box55\"");
            BeginWriteAttribute("value", " value=\"", 7456, "\"", 7464, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box56\"");
            BeginWriteAttribute("value", " value=\"", 7555, "\"", 7563, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box57\"");
            BeginWriteAttribute("value", " value=\"", 7667, "\"", 7675, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box58\"");
            BeginWriteAttribute("value", " value=\"", 7778, "\"", 7786, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box59\"");
            BeginWriteAttribute("value", " value=\"", 7877, "\"", 7885, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box60\"");
            BeginWriteAttribute("value", " value=\"", 7989, "\"", 7997, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box61\"");
            BeginWriteAttribute("value", " value=\"", 8100, "\"", 8108, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box top-border\"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box62\"");
            BeginWriteAttribute("value", " value=\"", 8199, "\"", 8207, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border top-border\"/><br>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box63\"");
            BeginWriteAttribute("value", " value=\"", 8315, "\"", 8323, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box64\"");
            BeginWriteAttribute("value", " value=\"", 8416, "\"", 8424, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box65\"");
            BeginWriteAttribute("value", " value=\"", 8505, "\"", 8513, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box66\"");
            BeginWriteAttribute("value", " value=\"", 8607, "\"", 8615, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box67\"");
            BeginWriteAttribute("value", " value=\"", 8708, "\"", 8716, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box68\"");
            BeginWriteAttribute("value", " value=\"", 8797, "\"", 8805, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box69\"");
            BeginWriteAttribute("value", " value=\"", 8899, "\"", 8907, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box70\"");
            BeginWriteAttribute("value", " value=\"", 9000, "\"", 9008, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box71\"");
            BeginWriteAttribute("value", " value=\"", 9089, "\"", 9097, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border \"/><br>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box72\"");
            BeginWriteAttribute("value", " value=\"", 9195, "\"", 9203, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box73\"");
            BeginWriteAttribute("value", " value=\"", 9310, "\"", 9318, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box74\"");
            BeginWriteAttribute("value", " value=\"", 9413, "\"", 9421, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box75\"");
            BeginWriteAttribute("value", " value=\"", 9529, "\"", 9537, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box76\"");
            BeginWriteAttribute("value", " value=\"", 9644, "\"", 9652, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box77\"");
            BeginWriteAttribute("value", " value=\"", 9747, "\"", 9755, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box78\"");
            BeginWriteAttribute("value", " value=\"", 9863, "\"", 9871, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border left-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box79\"");
            BeginWriteAttribute("value", " value=\"", 9978, "\"", 9986, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box bottom-border \"/>\r\n<input type=\"number\" oninput=\"CheckPossible\" name=\"box80\"");
            BeginWriteAttribute("value", " value=\"", 10081, "\"", 10089, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"input-box right-border bottom-border \"/><br>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sudoku> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591