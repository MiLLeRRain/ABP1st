using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ABP1st.Pages;

public class Index_Tests : ABP1stWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
