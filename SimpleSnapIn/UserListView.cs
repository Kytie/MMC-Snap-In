using Microsoft.ManagementConsole;
using System;
using Action = Microsoft.ManagementConsole.Action;

namespace SimpleSnapIn
{
    public class UserListView : MmcListView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public UserListView()
        {
        }

        protected override void OnInitialize(AsyncStatus status)
        {
            // Call the parent class method.
            base.OnInitialize(status);
            // Use the default column that already exists.
            this.Columns[0].Title = "User";
            this.Columns[0].SetWidth(300);
            // Create subsequent columns.
            this.Columns.Add(new MmcListViewColumn("Birthday", 200));
            // Populate the list.
            Refresh();
            //Create a Refresh action that resets the list view.
            this.ActionsPaneItems.Add(new Action("Refresh", "refresh", -1, "Refresh"));

            // This provides similar functionality to the line
            // this.SelectionData.ActionsPaneItems.Add(new Action("Properties", "Properties", -1, "Properties"));
            // Code:
                //this.SelectionData.EnabledStandardVerbs = StandardVerbs.Properties;
        }

        protected override void OnAction(Action action, AsyncStatus status)
        {
            switch ((string)action.Tag)
            {
                case "Refresh":
                    {
                        Refresh();
                        break;
                    }
            }
        }

        protected void Refresh()
        {
            // Get some fictitious data to populate the lists with
            string[][] users = { new string[] {"Karen", "February 14th"},
                                new string[] {"Sue", "May 5th"},
                                new string[] {"Tina", "April 15th"},
                                new string[] {"Lisa", "March 27th"},
                                new string[] {"Tom", "December 25th"},
                                new string[] {"John", "January 1st"},
                                new string[] {"Harry", "October 31st"},
                                new string[] {"Bob", "July 4th"}
                            };

            // Remove any existing data.
            this.ResultNodes.Clear();

            // Re-populate the list.
            foreach (string[] user in users)
            {
                ResultNode userNode = new ResultNode();
                userNode.DisplayName = user[0];
                userNode.SubItemDisplayNames.Add(user[1]);
                this.ResultNodes.Add(userNode);
            }
        }

        protected override void OnSelectionChanged(SyncStatus status)
        {
            int count = SelectedNodes.Count;

            // Update selection context.
            if (count == 0)
            {
                this.SelectionData.Clear();
                this.SelectionData.ActionsPaneItems.Clear();
            }
            else
            {
                // Update the console with the selection information. 
                this.SelectionData.Update((ResultNode)this.SelectedNodes[0], count > 1, null, null);
                this.SelectionData.ActionsPaneItems.Clear();
                this.SelectionData.ActionsPaneItems.Add(new Action("Properties", "Properties", -1, "Properties"));
            }
        }

        protected override void OnSelectionAction(Action action, AsyncStatus status)
        {
            switch ((string)action.Tag)
            {
                case "Properties":
                    {
                        this.SelectionData.ShowPropertySheet("User Properties");   // triggers OnAddPropertyPages
                        break;
                    }
            }
        }

        protected override void OnAddPropertyPages(PropertyPageCollection propertyPageCollection)
        {
            if (this.SelectedNodes.Count == 0)
            {
                throw new Exception("there should be at least one selection");
            }
            else
            {
                // add at least one property page relevant to the selection
                propertyPageCollection.Add(new UserPropertyPage());
            }
        }
    }
}