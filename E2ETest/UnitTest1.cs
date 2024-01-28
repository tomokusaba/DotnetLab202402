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

    [Test]
    public async Task AddDialog()
    {
        await Page.GotoAsync("https://localhost:7283/");

        await Expect(Page).ToHaveTitleAsync(new Regex("Index"));

        await Page.GetByTestId("pagetitle").IsVisibleAsync();

        await Page.GetByTestId("addbutton").IsVisibleAsync();

        await Page.GetByTestId("addbutton").ClickAsync();

        await Page.GetByTestId("adddialogpanetitle").IsVisibleAsync();
        await Page.GetByTestId("adddialogtitlelabel").IsVisibleAsync();
        await Page.GetByTestId("adddialogtitletextfield").IsVisibleAsync();
        await Page.GetByTestId("adddialogcontentlabel").IsVisibleAsync();
        await Page.GetByTestId("adddialogcontenttextfield").IsVisibleAsync();
        await Page.GetByTestId("adddialogauthorlabel").IsVisibleAsync();
        await Page.GetByTestId("adddialogauthortextfield").IsVisibleAsync();
        await Page.GetByTestId("adddialogcreatedlabel").IsVisibleAsync();
        await Page.GetByTestId("adddialogcreatedtextfield").IsVisibleAsync();
        await Page.GetByTestId("adddialogupdatedlabel").IsVisibleAsync();
        await Page.GetByTestId("adddialogupdatedtextfield").IsVisibleAsync();
        await Page.GetByTestId("adddialogsubmit").IsVisibleAsync();
        await Page.GetByTestId("adddialogclose").IsVisibleAsync();
    }
}
