using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; // for HtmlHelper class

namespace BundleAndBootstrapMVC5
{
    public static class CustomTextBox
    {
        public static HtmlString TextBox(string name, string value)
        {
            return new HtmlString(String.Format("<input id='{0}' name='{0}' value='{1}' type='text' />", name, value));
        }


        public static IHtmlString LabelWithMark(string content)
        {
            string htmlString = String.Format("<label><mark>{0}</mark></label>", content);
            return new HtmlString(htmlString);
        }
    }

    public static class MyExtensionMethods
    {
        public static IHtmlString LabelWithMark(this HtmlHelper helper, string content)
        {
            string htmlString = String.Format("<label><mark>{0}</mark></label>", content);
            return new HtmlString(htmlString);
        }
    }

}