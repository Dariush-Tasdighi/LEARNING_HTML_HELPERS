namespace Infrastructure
{
	public static class HtmlHelper1
	{
		static HtmlHelper1()
		{
		}

		public static string Label(string expression, string labelText)
		{
			// Solution (1)
			string result =
				$"<label for='{ expression }'>{ labelText }</label>";

			return result;
			// /Solution (1)

			// Solution (2)
			//string result =
			//	$"<div class='caption'><label for='{ expression }'>{ labelText }</label></div>";

			//return result;
			// /Solution (2)

			// Solution (3)
			//System.Web.Mvc.TagBuilder label =
			//	new System.Web.Mvc.TagBuilder("label");

			//label.SetInnerText(labelText);
			//label.Attributes.Add("for", expression);

			//return label.ToString();
			// /Solution (3)

			// Solution (4)
			//System.Web.Mvc.TagBuilder label =
			//	new System.Web.Mvc.TagBuilder("label");

			//label.SetInnerText(labelText);
			//label.Attributes.Add("for", expression);

			//System.Web.Mvc.TagBuilder div =
			//	new System.Web.Mvc.TagBuilder("div");

			//div.AddCssClass("caption");
			//div.InnerHtml = label.ToString();

			//return div.ToString();
			// /Solution (4)
		}
	}
}
