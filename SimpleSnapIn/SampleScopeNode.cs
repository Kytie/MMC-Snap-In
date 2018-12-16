using Microsoft.ManagementConsole;

namespace SimpleSnapIn
{
    public class SampleScopeNode : ScopeNode
    {
        public SampleScopeNode(){}

        protected override void OnAddPropertyPages(PropertyPageCollection propertyPageCollection)
        {
            propertyPageCollection.Add(new ScopePropertyPage(this));
        }
    }
}
