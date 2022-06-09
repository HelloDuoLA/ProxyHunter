using System.Net;

namespace ClassLibrary
{
    public class ClassProxy
    {
        public static string? proxyIP;
        public static string? proxyPort;
        public static string? proxyStatus;
        public static string? proxyCT;
        public static string? proxyVT;
        public static string? proxyComments;

        public static string PorxyVerify(string IP, int port, string url)
        {
            bool isok = true;
            string? rs = null;
            while (isok)
            {
                try
                {
                    //设置代理IP
                    WebProxy proxyObject = new WebProxy(IP, port);
                    //向指定地址发送请求
                    HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(url);
                    HttpWReq.Proxy = proxyObject;
                    HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
                    HttpWReq.Timeout = 1000;
                    StreamReader sr = new StreamReader(HttpWResp.GetResponseStream(), System.Text.Encoding.GetEncoding("UTF-8"));
                    string xmlContent = sr.ReadToEnd().Trim();
                    sr.Close();
                    HttpWResp.Close();
                    HttpWReq.Abort();
                    rs = xmlContent;
                    isok = false;
                }
                catch (Exception)
                {
                    isok = false;
                    rs = "Error";
                }
            }
            return rs;
        }
    }
}