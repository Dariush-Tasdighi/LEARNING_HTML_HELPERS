using System.Web.Mvc.Html;

namespace Infrastructure
{
	public static class HtmlHelper3
	{
		static HtmlHelper3()
		{
		}

		public static System.Web.IHtmlString DtxLabel
			(this System.Web.Mvc.HtmlHelper htmlHelper, string expression, string labelText)
		{
			// Solution (1)
			string result =
				$"<label for='{ expression }'>{ labelText }</label>";

			return htmlHelper.Raw(result);
			// /Solution (1)

			// Solution (2)
			//System.Web.Mvc.TagBuilder label =
			//	new System.Web.Mvc.TagBuilder("label");

			//label.SetInnerText(labelText);
			//label.Attributes.Add("for", expression);

			//return htmlHelper.Raw(label.ToString());
			// /Solution (2)

			// Solution (3)
			//System.Web.Mvc.TagBuilder label =
			//	new System.Web.Mvc.TagBuilder("label");

			//label.SetInnerText(labelText);
			//label.Attributes.Add("for", expression);

			//System.Web.Mvc.TagBuilder div =
			//	new System.Web.Mvc.TagBuilder("div");

			//div.AddCssClass("caption");
			//div.InnerHtml = label.ToString();

			//return htmlHelper.Raw(div.ToString());
			// /Solution (3)

			// Solution (4)
			//string label =
			//	htmlHelper.Label(expression: expression, labelText: labelText)
			//	.ToHtmlString();

			//System.Web.Mvc.TagBuilder div =
			//	new System.Web.Mvc.TagBuilder("div");

			//div.InnerHtml = label;
			//div.AddCssClass("caption");

			//return htmlHelper.Raw(div.ToString());
			// /Solution (4)
		}

		public static System.Web.IHtmlString DtxTextBox
			(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value = null)
		{
			System.Web.Mvc.TagBuilder input =
				new System.Web.Mvc.TagBuilder("input");

			input.Attributes.Add("id", name);
			input.Attributes.Add("name", name);
			input.Attributes.Add("type", "text");

			if (value != null)
			{
				input.Attributes.Add("value", value.ToString());
			}

			return htmlHelper.Raw(input.ToString());
		}

		public static System.Web.IHtmlString DtxSubmit
			(this System.Web.Mvc.HtmlHelper htmlHelper, string caption, string id = null)
		{
			System.Web.Mvc.TagBuilder button =
				new System.Web.Mvc.TagBuilder("button");

			button.SetInnerText(caption);

			button.AddCssClass("btn");
			button.AddCssClass("btn-primary");

			button.Attributes.Add("type", "submit");

			if (id != null)
			{
				button.Attributes.Add("id", id);
			}

			return htmlHelper.Raw(button.ToString());
		}

		public static System.Web.IHtmlString DtxReset
			(this System.Web.Mvc.HtmlHelper htmlHelper, string caption)
		{
			System.Web.Mvc.TagBuilder button =
				new System.Web.Mvc.TagBuilder("button");

			button.SetInnerText(caption);

			button.AddCssClass("btn");
			button.AddCssClass("btn-default");

			button.Attributes.Add("type", "reset");

			return htmlHelper.Raw(button.ToString());
		}
	}
}
