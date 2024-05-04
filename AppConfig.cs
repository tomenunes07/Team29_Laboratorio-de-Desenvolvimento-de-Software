using System;
namespace LabDev.Models
{
    public class AppConfig
    {
        public string ServiceUrl = "https://personal-udj5dgyf.outsystemscloud.com/LabDev/rest/FB_DummyService/Get_Posts?AppId={0}";
        private int AppId = 1;

        public string GetServiceUrlWithId()
        {
            return string.Format(ServiceUrl, AppId);
        }
    }
}
