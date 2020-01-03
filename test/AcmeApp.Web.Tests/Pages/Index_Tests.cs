using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AcmeApp.Pages
{
    public class Index_Tests : AcmeAppWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
