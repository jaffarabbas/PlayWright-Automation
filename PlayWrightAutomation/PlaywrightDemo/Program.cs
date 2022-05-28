using Microsoft.Playwright;

using var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Chromium.LaunchAsync();
var page = await browser.NewPageAsync();
await page.GotoAsync("playwright.dev/dotnet/docs/intro");
// await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });