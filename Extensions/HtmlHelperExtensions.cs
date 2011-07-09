using System.Text;
using System.Web;
using System.Web.Mvc;
using NGM.GooglePlusone.Models;

namespace NGM.GooglePlusone.Extensions {
    public static class HtmlHelperExtensions {
        public static IHtmlString BuildPlusoneHtmlFor(this HtmlHelper htmlHelper, GooglePlusonePart part) {
            const string startTag = "<g:plusone";
            const string endTag = "></g:plusone>";

            var builder = new StringBuilder();
            builder.Append(startTag);
            
            if (!part.IncludeCount)
                builder.Append(" count=\"false\"");

            if (!string.IsNullOrEmpty(part.JsCallbackFunction))
                builder.AppendFormat(" callback=\"{0}\"", part.JsCallbackFunction);

            if (!string.IsNullOrEmpty(part.UrlToPlusone))
                builder.AppendFormat(" href=\"{0}\"", part.UrlToPlusone);

            if (part.Size != Size.Standard.ToString() && !string.IsNullOrEmpty(part.Size))
                builder.AppendFormat(" size=\"{0}\"", part.Size);

            builder.Append(endTag);

            return MvcHtmlString.Create(builder.ToString());
        }
    }
}