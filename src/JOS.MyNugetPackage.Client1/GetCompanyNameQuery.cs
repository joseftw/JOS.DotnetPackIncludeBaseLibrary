using JOS.MyNugetPackage.Core;

namespace JOS.MyNugetPackage.Client1
{
    public class GetCompanyNameQuery : IGetCompanyNameQuery
    {
        public string Execute()
        {
            return $"This is Client 1, brought to you by {SuperImportantConstants.CompanyName}";
        }
    }
}
