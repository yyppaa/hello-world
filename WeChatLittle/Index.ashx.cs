using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeChatLittle
{
    /// <summary>
    /// Index 的摘要说明
    /// </summary>
    public class Index : IHttpHandler
    {
        const string _token = "zzxx";//"zzxx";
        private const string _myOpenid = "wx49a72bae38002746";//"wx3ecea12264b85e1d";//"你自己微信公众测试号的appID";
        string postStr = "";

        public void ProcessRequest(HttpContext context)
        {
           // context.Response.ContentType = "text/plain";
          //  context.Response.Write("Hello World");

            if (HttpContext.Current.Request.HttpMethod.ToUpper() == "GET")
            {
                //成为开发者之前消息认证处理
                Auth(); 
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}