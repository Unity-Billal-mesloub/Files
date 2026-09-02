
using OpenQA.Selenium.Interactions;

namespace Files.InteractionTests.Tests
{
	[TestClass]
	public sealed class SettingsTests
	{

		[TestCleanup]
		public void Cleanup()
		{
			var action = new Actions(SessionManager.Session);
			action.SendKeys(OpenQA.Selenium.Keys.Escape).Build().Perform();
		
	}
}
