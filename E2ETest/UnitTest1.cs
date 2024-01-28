namespace E2ETest;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    /// <summary>
    /// 初期表示時の表示を確認する
    /// </summary>
    /// <returns></returns>
    [Test]
    public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
    {
        await Page.GotoAsync("https://localhost:7283/");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("Index"));

        await Page.GetByTestId("pagetitle").IsVisibleAsync();

        await Page.GetByTestId("gridtitleheader").IsVisibleAsync();

        await Page.GetByTestId("gridcontentheader").IsVisibleAsync();

        await Page.GetByTestId("gridauthorheader").IsVisibleAsync();

        await Page.GetByTestId("gridcreatedheader").IsVisibleAsync();

        await Page.GetByTestId("gridupdatedheader").IsVisibleAsync();


    }
}
