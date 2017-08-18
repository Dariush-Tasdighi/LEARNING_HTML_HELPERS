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
			string strResult =
				string.Format("<label for='{0}'>{1}</label>",
				expression, labelText);

			return (htmlHelper.Raw(strResult));
			// /Solution (1)

			// Solution (2)
			//System.Web.Mvc.TagBuilder oLabel =
			//	new System.Web.Mvc.TagBuilder("label");

			//oLabel.SetInnerText(labelText);
			//oLabel.Attributes.Add("for", expression);

			//return (htmlHelper.Raw(oLabel.ToString()));
			// /Solution (2)

			// Solution (3)
			//System.Web.Mvc.TagBuilder oLabel =
			//	new System.Web.Mvc.TagBuilder("label");

			//oLabel.SetInnerText(labelText);
			//oLabel.Attributes.Add("for", expression);

			//System.Web.Mvc.TagBuilder oDiv =
			//	new System.Web.Mvc.TagBuilder("div");

			//oDiv.AddCssClass("caption");
			//oDiv.InnerHtml = oLabel.ToString();

			//return (htmlHelper.Raw(oDiv.ToString()));
			// /Solution (3)

			// Solution (4)
			//string strLabel =
			//	htmlHelper.Label(expression: expression, labelText: labelText)
			//	.ToHtmlString();

			//System.Web.Mvc.TagBuilder oDiv =
			//	new System.Web.Mvc.TagBuilder("div");

			//oDiv.InnerHtml = strLabel;
			//oDiv.AddCssClass("caption");

			//return (htmlHelper.Raw(oDiv.ToString()));
			// /Solution (4)
		}

		public static System.Web.IHtmlString DtxTextBox
			(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value = null)
		{
			System.Web.Mvc.TagBuilder oInput =
				new System.Web.Mvc.TagBuilder("input");

			oInput.Attributes.Add("id", name);
			oInput.Attributes.Add("name", name);
			oInput.Attributes.Add("type", "text");

			if (value != null)
			{
				oInput.Attributes.Add("value", value.ToString());
			}

			return (htmlHelper.Raw(oInput.ToString()));
		}

		public static System.Web.IHtmlString DtxSubmit
			(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string caption)
		{
			System.Web.Mvc.TagBuilder oButton =
				new System.Web.Mvc.TagBuilder("button");

			oButton.SetInnerText(caption);

			oButton.AddCssClass("btn");
			oButton.AddCssClass("btn-default");

			oButton.Attributes.Add("id", name);
			oButton.Attributes.Add("name", name);
			oButton.Attributes.Add("type", "submit");

			return (htmlHelper.Raw(oButton.ToString()));
		}

		public static System.Web.IHtmlString DtxReset
			(this System.Web.Mvc.HtmlHelper htmlHelper, string caption)
		{
			System.Web.Mvc.TagBuilder oButton =
				new System.Web.Mvc.TagBuilder("button");

			oButton.SetInnerText(caption);

			oButton.AddCssClass("btn");
			oButton.AddCssClass("btn-default");

			oButton.Attributes.Add("type", "reset");

			return (htmlHelper.Raw(oButton.ToString()));
		}
	}
}
