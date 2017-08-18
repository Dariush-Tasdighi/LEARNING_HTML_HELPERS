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
			//	string.Format("<div class='caption'><label for='{0}'>{1}</label></div>",
			//	expression, labelText);

			//return (strResult);
			// /Solution (2)












			// Solution (3)
			//System.Web.Mvc.TagBuilder oLabel =
			//	new System.Web.Mvc.TagBuilder("label");

			//oLabel.SetInnerText(labelText);
			//oLabel.Attributes.Add("for", expression);

			//return (oLabel.ToString());
			// /Solution (3)

			// Solution (4)
			//System.Web.Mvc.TagBuilder oLabel =
			//	new System.Web.Mvc.TagBuilder("label");

			//oLabel.SetInnerText(labelText);
			//oLabel.Attributes.Add("for", expression);

			//System.Web.Mvc.TagBuilder oDiv =
			//	new System.Web.Mvc.TagBuilder("div");

			//oDiv.AddCssClass("caption");
			//oDiv.InnerHtml = oLabel.ToString();

			//return (oDiv.ToString());
			// /Solution (4)
		}
	}
}
