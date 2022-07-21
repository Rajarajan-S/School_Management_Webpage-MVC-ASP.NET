using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Template_HTML
{
    public static class CustomHelperClass
    {
        //Label using custom helper class
        public static MvcHtmlString MyCustomLabel(string text)
        {
            var tagBuilder = new TagBuilder("label");
            tagBuilder.AddCssClass("myLabel");
            tagBuilder.InnerHtml = text;
            return new MvcHtmlString(tagBuilder.ToString());
        }
        //Label using extension method
        public static MvcHtmlString MyCustomLabel(this HtmlHelper helper, string text)
        {
            var tagBuilder = new TagBuilder("label");
            tagBuilder.AddCssClass("myLabel1");
            tagBuilder.InnerHtml = text;
            return new MvcHtmlString(tagBuilder.ToString());
        }
        //File using custom helper class
        public static IHtmlString File(string id)
        {
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "file");
            tb.Attributes.Add("id", id);
            return new MvcHtmlString(tb.ToString());
        }
        //File using extension method
        public static IHtmlString File(this HtmlHelper helper, string id)
        {
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "file");
            tb.Attributes.Add("id", id);
            return new MvcHtmlString(tb.ToString());
        }
        //Textbox using custom helper class
        public static MvcHtmlString MyCustomTextbox()
        {
            TagBuilder t = new TagBuilder("input");
            t.Attributes.Add("type", "text");
            t.AddCssClass("myLabel2");
            return new MvcHtmlString(t.ToString());
        }
        //Button using custom helper class
        public static MvcHtmlString MyCustomButton(string id)
        {
            var tagBuilder = new TagBuilder("Button");
            tagBuilder.InnerHtml = "Done";
            tagBuilder.Attributes.Add("type", "submit");
            tagBuilder.Attributes.Add("id", id);
            tagBuilder.Attributes.Add("value", "Button");
            return new MvcHtmlString(tagBuilder.ToString());
        }
        //Image using custom helper class
        public static MvcHtmlString MyCustomImage(string id, string src, string alt, string height, string width)
        {
            var tagBuilder = new TagBuilder("img");
            tagBuilder.Attributes.Add("id", id);
            tagBuilder.Attributes.Add("src", src);
            tagBuilder.Attributes.Add("alt", alt);
            tagBuilder.Attributes.Add("height", height);
            tagBuilder.Attributes.Add("width", width);
            return new MvcHtmlString(tagBuilder.ToString());
        }
    }
}