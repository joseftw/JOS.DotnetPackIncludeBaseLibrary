using JOS.MyNugetPackage.Core;

namespace JOS.MyNugetPackage.Client2
{
    public class GetCompanyNameQuery : IGetCompanyNameQuery
    {
        public string Execute()
        {
            return $"This is Client 2, brought to you by {SuperImportantConstants.CompanyName}";
        }
    }
}
