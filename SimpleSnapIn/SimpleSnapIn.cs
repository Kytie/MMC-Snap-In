using Microsoft.ManagementConsole;
using System.ComponentModel;

namespace SimpleSnapIn
{
    /// <summary>
    /// The RunInstaller attribute allows the .Net framework to install the assembly.
    /// </summary>
    [RunInstaller(true)]
    public class InstallUtilSupport : SnapInInstaller
    {
    }

    /// <summary>
    /// The main entry point for the creation of the snap-in.
    /// </summary>
    [SnapInSettings("{CFAA3895-4B02-4431-A168-A6416013C3DD}",
         DisplayName = "Simple SnapIn Sample",
         Description = "Simple Hello World SnapIn")]
    public class SimpleSnapIn : SnapIn
    {
        /// <summary>
        /// The constructor.
        /// </summary>
        public SimpleSnapIn()
        {
            // Update tree pane with a node in the tree
            ScopeNode scopeNode = new SampleScopeNode();
            scopeNode.DisplayName = "Hello World";
            this.RootNode = scopeNode;
            this.RootNode.EnabledStandardVerbs = StandardVerbs.Properties;

            // Create result list view for the snap-in.
            MmcListViewDescription mmcListViewDescription = new MmcListViewDescription();
            mmcListViewDescription.DisplayName = "User List with Properties";
            mmcListViewDescription.ViewType = typeof(UserListView);
            mmcListViewDescription.Options = MmcListViewOptions.SingleSelect;
            scopeNode.ViewDescriptions.Add(mmcListViewDescription);
            scopeNode.ViewDescriptions.DefaultIndex = 0;
            this.RootNode.Children.Add(new SampleScopeNode() { DisplayName = "Node1", EnabledStandardVerbs = StandardVerbs.Properties });
            this.RootNode.Children.Add(new SampleScopeNode() { DisplayName = "Node2", EnabledStandardVerbs = StandardVerbs.Properties });
            this.RootNode.Children.Add(new SampleScopeNode() { DisplayName = "Node3", EnabledStandardVerbs = StandardVerbs.Properties });
            this.RootNode.Children.Add(new SampleScopeNode() { DisplayName = "Node4", EnabledStandardVerbs = StandardVerbs.Properties });
        }
    } // class
}
