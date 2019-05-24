//namespace Googooli
//namespace System.Web.Mvc
namespace Infrastructure
{
	//public static class Magooli
	public static class HtmlHelper2
	{
		static HtmlHelper2()
		{
		}

		public static string DTLabel
			(this System.Web.Mvc.HtmlHelper baghali, string expression, string labelText)
		{
			// Solution (1)
			string result =
				$"<label for='{ expression }'>{ labelText }</label>";

			return result;
			// /Solution (1)

			// Solution (2)
			//System.Web.Mvc.TagBuilder label =
			//	new System.Web.Mvc.TagBuilder("label");

			//label.SetInnerText(labelText);
			//label.Attributes.Add("for", expression);

			//return label.ToString();
			// /Solution (2)
		}
	}
}
