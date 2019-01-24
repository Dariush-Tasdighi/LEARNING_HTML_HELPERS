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
			string result =
				$"<label for='{ expression }'>{ labelText }</label>";

			return result;
		}
	}
}
