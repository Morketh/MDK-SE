﻿using Microsoft.VisualStudio.PlatformUI;

namespace Malware.MDKUI.Options
{
    /// <summary>
    /// Interaction logic for RequestUpgradeDialog.xaml
    /// </summary>
    public partial class AddPluginLocationDialog : DialogWindow
    {
        /// <summary>
        /// Shows this dialog with the provided view model.
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public static bool? ShowDialog(AddPluginLocationDialogModel viewModel)
        {
            var dialog = new AddPluginLocationDialog();
            dialog.SetModel(viewModel);
            return dialog.ShowModal();
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ProjectIntegrity.RequestUpgradeDialog"/>
        /// </summary>
        public AddPluginLocationDialog()
        {
            InitializeComponent();
        }

        void SetModel(AddPluginLocationDialogModel viewModel)
        {
            Host.DataContext = viewModel;
            viewModel.Closing += OnModelClosing;
        }

        void OnModelClosing(object sender, DialogClosingEventArgs e)
        {
            ((AddPluginLocationDialogModel)Host.DataContext).Closing += OnModelClosing;
            DialogResult = e.State;
            Close();
        }
    }
}
