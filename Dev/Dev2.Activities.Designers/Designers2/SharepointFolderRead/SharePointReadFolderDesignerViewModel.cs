#pragma warning disable
using System;
using System.Activities.Presentation.Model;
using System.Collections.Generic;
using Dev2.Activities.Designers2.SharepointListRead;
using Dev2.Common.Interfaces.Infrastructure.Providers.Errors;
using Dev2.Common.Interfaces.Threading;
using Dev2.Providers.Errors;
using Dev2.Services.Events;
using Dev2.Studio.Core;
using Dev2.Studio.Interfaces;
using Dev2.Threading;
using Warewolf.Resource.Errors;






namespace Dev2.Activities.Designers2.SharepointFolderRead
{
    public class SharePointReadFolderDesignerViewModel : SharepointListDesignerViewModelBase
    {
        public SharePointReadFolderDesignerViewModel(ModelItem modelItem)
            : this(modelItem, new AsyncWorker(), ServerRepository.Instance.ActiveServer)
        {
            if (!IsFilesAndFoldersSelected && !IsFoldersSelected && !IsFilesSelected)
            {
                IsFilesSelected = true;
            }
            HelpText = Warewolf.Studio.Resources.Languages.HelpText.Tool_SharePoint_Read_Folder;
        }

        public SharePointReadFolderDesignerViewModel(ModelItem modelItem, IAsyncWorker asyncWorker, IServer envModel)
            : base(modelItem, asyncWorker, envModel, EventPublishers.Aggregator)
        {
            
        }


        #region Overrides of ActivityCollectionDesignerViewModel<SharepointSearchTo>

        public override void UpdateHelpDescriptor(string helpText)
        {
            var mainViewModel = CustomContainer.Get<IShellViewModel>();
            mainViewModel?.HelpViewModel?.UpdateHelpText(helpText);
        }
        
        public bool IsFilesAndFoldersSelected { set => SetProperty(value); get => GetProperty<bool>(); }
        public bool IsFoldersSelected { set => SetProperty(value); get => GetProperty<bool>(); }
        public bool IsFilesSelected { set => SetProperty(value); get => GetProperty<bool>(); }
        public string ServerInputPath => GetProperty<string>();

        protected override IEnumerable<IActionableErrorInfo> ValidateThis()
        {
            if (Errors != null && Errors.Count > 0)
            {
                Errors.Clear();
            }
           
            if (SharepointServerResourceId == Guid.Empty)
            {
                Errors = new List<IActionableErrorInfo> { new ActionableErrorInfo() { Message = ErrorResource.SharepointServerRequired } };

                return Errors;
            }

            return new List<IActionableErrorInfo>();
        }

        #endregion

        public override string CollectionName => "FilterCriteria";
    }
}
