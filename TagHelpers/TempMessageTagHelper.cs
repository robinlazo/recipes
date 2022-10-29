using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using WebRecipe.Models;

namespace WebRecipe.TagHelpers;

[HtmlTargetElement("my-temp-message")]
public class TempMessageTagHelper : TagHelper
{
    [ViewContext]
    [HtmlAttributeNotBound]
    public ViewContext Context {get;set;}

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        var td = Context.TempData;

        if(td.ContainsKey("message")) {
            output.BuildTag("p", "bg-info text-center text-white mb-0");
            output.Content.SetContent(td["message"].ToString());
        } else {
            output.SuppressOutput();
        }
    }
}