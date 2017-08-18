using System.Web.Mvc.Html;

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
			string strResult =
				string.Format("<label for='{0}'>{1}</label>",
				expression, labelText);

			return (strResult);
		}

		public static string DTTextBox
			(this System.Web.Mvc.HtmlHelper helper, string name)
		{
			string strResult =
				string.Format("<input id=\"{0}\" name=\"{0}\" type=\"text\" value=\"\" />", name);

			return (strResult);
		}

		public static string DTButton
			(this System.Web.Mvc.HtmlHelper helper, string name, string caption)
		{
			string strResult =
				string.Format("<input id=\"{0}\" name=\"{0}\" type=\"submit\" value=\"{1}\" class=\"button\" />", name, caption);

			return (strResult);
		}

		public static string DTReset
			(this System.Web.Mvc.HtmlHelper helper)
		{
			string strResult =
				string.Format("<input type=\"reset\" value=\"Reset\" class=\"button\" />");

			return (strResult);
		}
	}
}
