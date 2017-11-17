namespace Infrastructure
{
	public static class HtmlHelper1
	{
		/// <summary>
		/// Static Constructor
		/// </summary>
		static HtmlHelper1()
		{
		}

		public static string Label(string expression, string labelText)
		{
			// Solution (1)
			string strResult =
				string.Format("<label for='{0}'>{1}</label>",
				expression, labelText);

			return (strResult);
			// /Solution (1)

			// Solution (2)
			//string strResult =
			//	$"<label for='{ expression }'>{ labelText }</label>";

			//return (strResult);
			// /Solution (2)

			// Solution (3)
			//string strResult =
			//	string.Format("<div class='caption'><label for='{0}'>{1}</label></div>",
			//	expression, labelText);

			//return (strResult);
			// /Solution (3)

			// Solution (4)
			//string strResult =
			//	$"<div class='caption'><label for='{ expression }'>{ labelText }</label></div>";

			//return (strResult);
			// /Solution (4)

			// Solution (5)
			//System.Web.Mvc.TagBuilder label =
			//	new System.Web.Mvc.TagBuilder("label");

			//label.SetInnerText(labelText);
			//label.Attributes.Add("for", expression);

			//return (label.ToString());
			// /Solution (5)

			// Solution (6)
			//System.Web.Mvc.TagBuilder label =
			//	new System.Web.Mvc.TagBuilder("label");

			//label.SetInnerText(labelText);
			//label.Attributes.Add("for", expression);

			//System.Web.Mvc.TagBuilder div =
			//	new System.Web.Mvc.TagBuilder("div");

			//div.AddCssClass("caption");
			//div.InnerHtml = label.ToString();

			//return (div.ToString());
			// /Solution (6)
		}
	}
}
