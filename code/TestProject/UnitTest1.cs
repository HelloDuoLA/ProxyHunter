using Xunit;
using ProxyHunter;
using ClassLibrary;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestPorxyVerify1()
        {
            string IP = "127.0.0.1";
            int port = 8088;
            string url = "www.baidu.com";

            string rs = Class1.PorxyVerify(IP, port, url);

            Assert.NotEqual<string>("Error",rs);
        }

    }
}