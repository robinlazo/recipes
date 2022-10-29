using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebRecipe.Models;

public static class TagHelperExtensions {

    public static void AppendCssClass(this TagHelperAttributeList list, string newclass) {
        string oldclass = list["class"]?.Value?.ToString();
        string cssclass = (string.IsNullOrEmpty(oldclass)) ? newclass : $"{oldclass} {newclass}";
        list.SetAttribute("class", cssclass);
    }

    public static void BuildLink(this TagHelperOutput output, string url, string className) {
        output.BuildTag("a", className);
        output.Attributes.SetAttribute("href", url);
    }

    public static void BuildTag(this TagHelperOutput output, string tagName, string classNames) {
        output.TagName = tagName;
        output.TagMode = TagMode.StartTagAndEndTag;
        output.Attributes.AppendCssClass(classNames);
    }

}