// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace Warewolf.UITests.ServerSource.ServerSourceUIMapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class ServerSourceUIMap
    {
        
        #region Properties
        public MainStudioWindow MainStudioWindow
        {
            get
            {
                if ((this.mMainStudioWindow == null))
                {
                    this.mMainStudioWindow = new MainStudioWindow();
                }
                return this.mMainStudioWindow;
            }
        }
        #endregion
        
        #region Fields
        private MainStudioWindow mMainStudioWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class MainStudioWindow : WpfWindow
    {
        
        public MainStudioWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.Name, "Warewolf", PropertyExpressionOperator.Contains));
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public DockManager DockManager
        {
            get
            {
                if ((this.mDockManager == null))
                {
                    this.mDockManager = new DockManager(this);
                }
                return this.mDockManager;
            }
        }
        #endregion
        
        #region Fields
        private DockManager mDockManager;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class DockManager : WpfCustom
    {
        
        public DockManager(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.XamDockManager";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "DockManager";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public SplitPaneMiddle SplitPaneMiddle
        {
            get
            {
                if ((this.mSplitPaneMiddle == null))
                {
                    this.mSplitPaneMiddle = new SplitPaneMiddle(this);
                }
                return this.mSplitPaneMiddle;
            }
        }
        #endregion
        
        #region Fields
        private SplitPaneMiddle mSplitPaneMiddle;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class SplitPaneMiddle : WpfCustom
    {
        
        public SplitPaneMiddle(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.SplitPane";
            this.SearchProperties[WpfControl.PropertyNames.Instance] = "2";
            this.SearchConfigurations.Add(SearchConfiguration.NextSibling);
            this.SearchConfigurations.Add(SearchConfiguration.DisambiguateChild);
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public TabManSplitPane TabManSplitPane
        {
            get
            {
                if ((this.mTabManSplitPane == null))
                {
                    this.mTabManSplitPane = new TabManSplitPane(this);
                }
                return this.mTabManSplitPane;
            }
        }
        #endregion
        
        #region Fields
        private TabManSplitPane mTabManSplitPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TabManSplitPane : WpfCustom
    {
        
        public TabManSplitPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.SplitPane";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UI_SplitPane_AutoID";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public TabMan TabMan
        {
            get
            {
                if ((this.mTabMan == null))
                {
                    this.mTabMan = new TabMan(this);
                }
                return this.mTabMan;
            }
        }
        #endregion
        
        #region Fields
        private TabMan mTabMan;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TabMan : WpfTabList
    {
        
        public TabMan(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabList.PropertyNames.AutomationId] = "UI_TabManager_AutoID";
            this.WindowTitles.Add("Warewolf");
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public ServerSourceTab ServerSourceTab
        {
            get
            {
                if ((this.mServerSourceTab == null))
                {
                    this.mServerSourceTab = new ServerSourceTab(this);
                }
                return this.mServerSourceTab;
            }
        }
        #endregion
        
        #region Fields
        private ServerSourceTab mServerSourceTab;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class ServerSourceTab : WpfTabPage
    {
        
        public ServerSourceTab(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabPage.PropertyNames.Name] = "Dev2.ViewModels.SourceViewModel`1[Dev2.Common.Interfaces.IServerSource]";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public WorkSurfaceContext WorkSurfaceContext
        {
            get
            {
                if ((this.mWorkSurfaceContext == null))
                {
                    this.mWorkSurfaceContext = new WorkSurfaceContext(this);
                }
                return this.mWorkSurfaceContext;
            }
        }
        
        public WpfButton CloseButton
        {
            get
            {
                if ((this.mCloseButton == null))
                {
                    this.mCloseButton = new WpfButton(this);
                    #region Search Criteria
                    this.mCloseButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "closeBtn";
                    this.mCloseButton.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mCloseButton;
            }
        }
        
        public WpfImage NoAuthMessageText
        {
            get
            {
                if ((this.mNoAuthMessageText == null))
                {
                    this.mNoAuthMessageText = new WpfImage(this);
                    #region Search Criteria
                    this.mNoAuthMessageText.SearchProperties[WpfImage.PropertyNames.HelpText] = "You are not authorized to edit this resource";
                    this.mNoAuthMessageText.SearchProperties[WpfImage.PropertyNames.Instance] = "2";
                    this.mNoAuthMessageText.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mNoAuthMessageText;
            }
        }
        
        public WpfText NewServerTitleText
        {
            get
            {
                if ((this.mNewServerTitleText == null))
                {
                    this.mNewServerTitleText = new WpfText(this);
                    #region Search Criteria
                    this.mNewServerTitleText.SearchProperties[WpfText.PropertyNames.Name] = "New Server Source";
                    this.mNewServerTitleText.SearchProperties[WpfText.PropertyNames.Instance] = "2";
                    this.mNewServerTitleText.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mNewServerTitleText;
            }
        }
        
        public WpfImage NewServerBackground
        {
            get
            {
                if ((this.mNewServerBackground == null))
                {
                    this.mNewServerBackground = new WpfImage(this);
                    #region Search Criteria
                    this.mNewServerBackground.SearchProperties[WpfImage.PropertyNames.AutomationId] = "New Server Source";
                    this.mNewServerBackground.SearchProperties[WpfImage.PropertyNames.Instance] = "2";
                    this.mNewServerBackground.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mNewServerBackground;
            }
        }
        
        public WpfImage NoAuthImage
        {
            get
            {
                if ((this.mNoAuthImage == null))
                {
                    this.mNoAuthImage = new WpfImage(this);
                    #region Search Criteria
                    this.mNoAuthImage.SearchProperties[WpfImage.PropertyNames.HelpText] = "You are not authorized to edit this resource";
                    this.mNoAuthImage.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mNoAuthImage;
            }
        }
        
        public WpfText AddressText
        {
            get
            {
                if ((this.mAddressText == null))
                {
                    this.mAddressText = new WpfText(this);
                    #region Search Criteria
                    this.mAddressText.SearchProperties[WpfText.PropertyNames.Name] = "New Server Source";
                    this.mAddressText.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mAddressText;
            }
        }
        
        public WpfText TabDescription
        {
            get
            {
                if ((this.mTabDescription == null))
                {
                    this.mTabDescription = new WpfText(this);
                    #region Search Criteria
                    this.mTabDescription.SearchProperties.Add(new PropertyExpression(WpfText.PropertyNames.Name, "Remote Connection Integration", PropertyExpressionOperator.Contains));
                    this.mTabDescription.WindowTitles.Add("Warewolf (DEV2\\SANELE.MTHEMBU)");
                    #endregion
                }
                return this.mTabDescription;
            }
        }
        #endregion
        
        #region Fields
        private WorkSurfaceContext mWorkSurfaceContext;
        
        private WpfButton mCloseButton;
        
        private WpfImage mNoAuthMessageText;
        
        private WpfText mNewServerTitleText;
        
        private WpfImage mNewServerBackground;
        
        private WpfImage mNoAuthImage;
        
        private WpfText mAddressText;
        
        private WpfText mTabDescription;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class WorkSurfaceContext : WpfCustom
    {
        
        public WorkSurfaceContext(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.ContentPane";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "Dev2.Studio.ViewModels.WorkSurface.WorkSurfaceContextViewModel";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public NewServerSource NewServerSource
        {
            get
            {
                if ((this.mNewServerSource == null))
                {
                    this.mNewServerSource = new NewServerSource(this);
                }
                return this.mNewServerSource;
            }
        }
        
        public ErrorText ErrorText
        {
            get
            {
                if ((this.mErrorText == null))
                {
                    this.mErrorText = new ErrorText(this);
                }
                return this.mErrorText;
            }
        }
        
        public WpfRadioButton PublicRadioButton
        {
            get
            {
                if ((this.mPublicRadioButton == null))
                {
                    this.mPublicRadioButton = new WpfRadioButton(this);
                    #region Search Criteria
                    this.mPublicRadioButton.SearchProperties[WpfRadioButton.PropertyNames.AutomationId] = "PublicRadioButton";
                    this.mPublicRadioButton.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mPublicRadioButton;
            }
        }
        
        public WpfImage NewServerTabIcon
        {
            get
            {
                if ((this.mNewServerTabIcon == null))
                {
                    this.mNewServerTabIcon = new WpfImage(this);
                    #region Search Criteria
                    this.mNewServerTabIcon.SearchProperties[WpfImage.PropertyNames.AutomationId] = "New Server Source";
                    this.mNewServerTabIcon.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mNewServerTabIcon;
            }
        }
        
        public WpfRadioButton UserRadioButton
        {
            get
            {
                if ((this.mUserRadioButton == null))
                {
                    this.mUserRadioButton = new WpfRadioButton(this);
                    #region Search Criteria
                    this.mUserRadioButton.SearchProperties[WpfRadioButton.PropertyNames.AutomationId] = "UserRadioButton";
                    this.mUserRadioButton.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mUserRadioButton;
            }
        }
        
        public WpfRadioButton WindowsRadioButton
        {
            get
            {
                if ((this.mWindowsRadioButton == null))
                {
                    this.mWindowsRadioButton = new WpfRadioButton(this);
                    #region Search Criteria
                    this.mWindowsRadioButton.SearchProperties[WpfRadioButton.PropertyNames.AutomationId] = "WindowsRadioButton";
                    this.mWindowsRadioButton.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mWindowsRadioButton;
            }
        }
        
        public WpfEdit PasswordTextBox
        {
            get
            {
                if ((this.mPasswordTextBox == null))
                {
                    this.mPasswordTextBox = new WpfEdit(this);
                    #region Search Criteria
                    this.mPasswordTextBox.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "PasswordTextBox";
                    this.mPasswordTextBox.WindowTitles.Add("Warewolf (DEV2\\DYLAN.DELPORT)");
                    #endregion
                }
                return this.mPasswordTextBox;
            }
        }
        
        public WpfEdit UsernameTextBox
        {
            get
            {
                if ((this.mUsernameTextBox == null))
                {
                    this.mUsernameTextBox = new WpfEdit(this);
                    #region Search Criteria
                    this.mUsernameTextBox.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "UsernameTextBox";
                    this.mUsernameTextBox.WindowTitles.Add("Warewolf (DEV2\\DYLAN.DELPORT)");
                    #endregion
                }
                return this.mUsernameTextBox;
            }
        }
        #endregion
        
        #region Fields
        private NewServerSource mNewServerSource;
        
        private ErrorText mErrorText;
        
        private WpfRadioButton mPublicRadioButton;
        
        private WpfImage mNewServerTabIcon;
        
        private WpfRadioButton mUserRadioButton;
        
        private WpfRadioButton mWindowsRadioButton;
        
        private WpfEdit mPasswordTextBox;
        
        private WpfEdit mUsernameTextBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class NewServerSource : WpfCustom
    {
        
        public NewServerSource(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.ManageServerControl";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public AuthTypeOptions AuthTypeOptions
        {
            get
            {
                if ((this.mAuthTypeOptions == null))
                {
                    this.mAuthTypeOptions = new AuthTypeOptions(this);
                }
                return this.mAuthTypeOptions;
            }
        }
        
        public ProtocolCombobox ProtocolCombobox
        {
            get
            {
                if ((this.mProtocolCombobox == null))
                {
                    this.mProtocolCombobox = new ProtocolCombobox(this);
                }
                return this.mProtocolCombobox;
            }
        }
        
        public AddressComboBox AddressComboBox
        {
            get
            {
                if ((this.mAddressComboBox == null))
                {
                    this.mAddressComboBox = new AddressComboBox(this);
                }
                return this.mAddressComboBox;
            }
        }
        
        public WpfButton TestConnectionButton
        {
            get
            {
                if ((this.mTestConnectionButton == null))
                {
                    this.mTestConnectionButton = new WpfButton(this);
                    #region Search Criteria
                    this.mTestConnectionButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "TestConnectionButton";
                    this.mTestConnectionButton.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mTestConnectionButton;
            }
        }
        
        public WpfCustom Spinner
        {
            get
            {
                if ((this.mSpinner == null))
                {
                    this.mSpinner = new WpfCustom(this);
                    #region Search Criteria
                    this.mSpinner.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.CircularProgressBar";
                    this.mSpinner.SearchConfigurations.Add(SearchConfiguration.NextSibling);
                    this.mSpinner.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mSpinner;
            }
        }
        
        public WpfText ErrorText
        {
            get
            {
                if ((this.mErrorText == null))
                {
                    this.mErrorText = new WpfText(this);
                    #region Search Criteria
                    this.mErrorText.SearchProperties[WpfText.PropertyNames.AutomationId] = "ErrorTextBlock";
                    this.mErrorText.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mErrorText;
            }
        }
        #endregion
        
        #region Fields
        private AuthTypeOptions mAuthTypeOptions;
        
        private ProtocolCombobox mProtocolCombobox;
        
        private AddressComboBox mAddressComboBox;
        
        private WpfButton mTestConnectionButton;
        
        private WpfCustom mSpinner;
        
        private WpfText mErrorText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class AuthTypeOptions : WpfCustom
    {
        
        public AuthTypeOptions(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.XamComboEditor";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "ProtocolItems";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public WpfButton WindowsAuth
        {
            get
            {
                if ((this.mWindowsAuth == null))
                {
                    this.mWindowsAuth = new WpfButton(this);
                    #region Search Criteria
                    this.mWindowsAuth.SearchProperties[WpfButton.PropertyNames.AutomationId] = "ToggleButton";
                    this.mWindowsAuth.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mWindowsAuth;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mWindowsAuth;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class ProtocolCombobox : WpfCustom
    {
        
        public ProtocolCombobox(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.XamComboEditor";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "ProtocolItems";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public WpfButton ToggleDropdown
        {
            get
            {
                if ((this.mToggleDropdown == null))
                {
                    this.mToggleDropdown = new WpfButton(this);
                    #region Search Criteria
                    this.mToggleDropdown.SearchProperties[WpfButton.PropertyNames.AutomationId] = "ToggleButton";
                    this.mToggleDropdown.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mToggleDropdown;
            }
        }
        
        public WpfText HttpSelectedItemText
        {
            get
            {
                if ((this.mHttpSelectedItemText == null))
                {
                    this.mHttpSelectedItemText = new WpfText(this);
                    #region Search Criteria
                    this.mHttpSelectedItemText.SearchProperties[WpfText.PropertyNames.Name] = "http";
                    this.mHttpSelectedItemText.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mHttpSelectedItemText;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mToggleDropdown;
        
        private WpfText mHttpSelectedItemText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class AddressComboBox : WpfComboBox
    {
        
        public AddressComboBox(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfComboBox.PropertyNames.AutomationId] = "AddressTextBox";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public WpfEdit AddressEditBox
        {
            get
            {
                if ((this.mAddressEditBox == null))
                {
                    this.mAddressEditBox = new WpfEdit(this);
                    #region Search Criteria
                    this.mAddressEditBox.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "Text";
                    this.mAddressEditBox.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mAddressEditBox;
            }
        }
        
        public WpfListItem TSTCIREMOTE
        {
            get
            {
                if ((this.mTSTCIREMOTE == null))
                {
                    this.mTSTCIREMOTE = new WpfListItem(this);
                    #region Search Criteria
                    this.mTSTCIREMOTE.SearchProperties[WpfListItem.PropertyNames.Name] = "TST-CI-REMOTE";
                    this.mTSTCIREMOTE.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mTSTCIREMOTE;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mAddressEditBox;
        
        private WpfListItem mTSTCIREMOTE;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class ErrorText : WpfText
    {
        
        public ErrorText(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfText.PropertyNames.AutomationId] = "ErrorTextBlock";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public WpfCustom Spinner
        {
            get
            {
                if ((this.mSpinner == null))
                {
                    this.mSpinner = new WpfCustom(this);
                    #region Search Criteria
                    this.mSpinner.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.CircularProgressBar";
                    this.mSpinner.SearchConfigurations.Add(SearchConfiguration.NextSibling);
                    this.mSpinner.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mSpinner;
            }
        }
        #endregion
        
        #region Fields
        private WpfCustom mSpinner;
        #endregion
    }
}
