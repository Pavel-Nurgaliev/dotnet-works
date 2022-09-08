using Microsoft.Extensions.Configuration;

namespace ShopUniversalApp.Services
{
    public class InitFooterInfo : IFooterInfo
    {
        private IConfiguration _configuration;

        public InitFooterInfo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string CompanyName => _configuration["CompanyInfo:Name"];

        public string DeveloperName => _configuration["CompanyInfo:Developer"];
    }
}
