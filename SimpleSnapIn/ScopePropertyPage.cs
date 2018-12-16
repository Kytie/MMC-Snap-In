using Microsoft.ManagementConsole;

namespace SimpleSnapIn
{
    public class ScopePropertyPage : PropertyPage
    {
        private ScopePropertiesControl scopePropertiesControl = null;
        private SampleScopeNode scopeNode = null;

        public ScopePropertyPage(SampleScopeNode parentScopeNode)
        {

            scopeNode = parentScopeNode;

            // Assign a title.
            this.Title = "Scope Node Property Page";

            // Set up the contained control and assign it a reference to its parent.
            scopePropertiesControl = new ScopePropertiesControl(this);
            this.Control = scopePropertiesControl;
        }

        /// <summary>
        /// Initialize notification for the page. The default implementation is empty.
        /// </summary>
        protected override void OnInitialize()
        {
            base.OnInitialize();

            // Populate the contained control. 
            scopePropertiesControl.RefreshData(scopeNode);
        }

        /// <summary>
        /// Sent to every page in the property sheet to indicate that the user has clicked 
        /// the Apply button and wants all changes to take effect.
        /// </summary>
        protected override bool OnApply()
        {

            if (this.Dirty)
            {
                if (scopePropertiesControl.CanApplyChanges())
                {
                    // Save the changes.
                    scopePropertiesControl.UpdateData(scopeNode);
                }
                else
                {
                    // Indicates that something invalid was entered.
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Sent to every page in the property sheet to indicate that the user has clicked the OK 
        /// or Close button and wants all changes to take effect.
        /// </summary>
        protected override bool OnOK()
        {
            return this.OnApply();
        }

        /// <summary>
        /// Indicates that the user wants to cancel the property sheet.
        /// The default implementation allows a cancel operation.
        /// </summary>
        protected override bool QueryCancel()
        {
            return true;
        }

        /// <summary>
        /// Indicates that the user has canceled and the property sheet is about to be destroyed.
        /// All changes made since the last PSN_APPLY notification are canceled.
        /// </summary>
        protected override void OnCancel()
        {
            scopePropertiesControl.RefreshData(scopeNode);
        }

        /// <summary>
        /// Notifies a page that the property sheet is getting destoyed. 
        /// Uses this notification message as an opportunity to perform cleanup operations.
        /// </summary>
        protected override void OnDestroy()
        {
        }
    }
}