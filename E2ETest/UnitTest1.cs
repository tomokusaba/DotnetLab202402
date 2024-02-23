using Microsoft.Extensions.Hosting;
using Microsoft.Playwright;

namespace E2ETest;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{


    public override BrowserNewContextOptions ContextOptions()
    {
        return new BrowserNewContextOptions()
        {
            RecordVideoDir = "videos",
            RecordVideoSize = new RecordVideoSize() { Width = 1920, Height = 1080 },
            ViewportSize = new ViewportSize { Width = 1920, Height = 1080 },
             Locale = "ja-JP",
             BaseURL = "https://localhost:7283"
        };
    }

    [SetUp]
    public async Task SetUp()
    {
        await Page.GotoAsync("/");
    }

    /// <summary>
    /// �����\�����̕\�����m�F����
    /// </summary>
    /// <returns></returns>
    [Test]
    public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
    {
        //await Page.GotoAsync("/");

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
        //await Page.GotoAsync("/");

        //await Expect(Page).ToHaveTitleAsync(new Regex("Index"));

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

    /// <summary>
    /// �ꌏ�ȏ�f�[�^�����邱�Ƃ��O��
    /// </summary>
    /// <returns></returns>
    [Test]
    public async Task UpdateDialog()
    {
        //await Page.GotoAsync("/");

        await Expect(Page).ToHaveTitleAsync(new Regex("Index"));

        await Page.GetByTestId("pagetitle").IsVisibleAsync();

        Playwright.Selectors.SetTestIdAttribute("data-selector");

        await Page.GetByTestId("updatebutton").First.ClickAsync();

        await Page.GetByTestId("updatedialogpanetitle").IsVisibleAsync();
        await Page.GetByTestId("updatedialogtitlelabel").IsVisibleAsync();
        await Page.GetByTestId("updatedialogtitletextfield").IsVisibleAsync();
        await Page.GetByTestId("updatedialogcontentlabel").IsVisibleAsync();
        await Page.GetByTestId("updatedialogcontenttextfield").IsVisibleAsync();
        await Page.GetByTestId("updatedialogauthorlabel").IsVisibleAsync();
        await Page.GetByTestId("updatedialogauthortextfield").IsVisibleAsync();
        await Page.GetByTestId("updatedialogcreatedlabel").IsVisibleAsync();
        await Page.GetByTestId("updatedialogcreatedtextfield").IsVisibleAsync();
        await Page.GetByTestId("updatedialogupdatedlabel").IsVisibleAsync();
        await Page.GetByTestId("updatedialogupdatedtextfield").IsVisibleAsync();
        await Page.GetByTestId("updatedialogsubmit").IsVisibleAsync();
        await Page.GetByTestId("updatedialogclose").IsVisibleAsync();
    }

    [Test]
    public async Task DeleteDialog()
    {
        //await Page.GotoAsync("/");

        await Expect(Page).ToHaveTitleAsync(new Regex("Index"));

        await Page.GetByTestId("pagetitle").IsVisibleAsync();

        Playwright.Selectors.SetTestIdAttribute("data-selector");

        await Page.GetByTestId("deletebutton").First.ClickAsync();

        await Page.GetByTestId("deletedialogpanetitle").IsVisibleAsync();
        await Page.GetByTestId("deletedialogsubmit").IsVisibleAsync();
        await Page.GetByTestId("deletedialogclose").IsVisibleAsync();
    }
}
