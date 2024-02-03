using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2ETest;

[Ignore("This test is not ready yet")]
[Parallelizable(ParallelScope.Self)]
public class CountTest : PageTest
{
    [Test]
    public async Task Test1Async()
    {
        await Page.GotoAsync("https://localhost:7283/count");

        await Page.GetByTestId("counter").IsVisibleAsync();

    }

    [Test]
    public async Task Test2Async()
    {
        await Page.GotoAsync("https://localhost:7283/count");

        await Page.GetByTestId("counter").IsVisibleAsync();

    }

    [Test]
    public async Task Test3Async()
    {
        await Page.GotoAsync("https://localhost:7283/count");

        await Page.GetByTestId("counter").IsVisibleAsync();

    }


}
