﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Windows;
using System.Windows.Controls;
using BotManagerVSIX.Models;

namespace BotManagerVSIX
{
    /// <summary>
    /// Interaction logic for AzureSubscriptionView.xaml
    /// </summary>
    public partial class AzureSubscriptionView : UserControl
    {
        public AzureSubscriptionView()
        {
            InitializeComponent();

            var integration = new Integration();

            var result = integration.GetAzureSubscriptions();

            foreach (var subscription in result)
            {
                subscriptionsCombo.Items.Add(subscription.Name);
            }
        }

        private void QnACheckBox_Changed (object sender, RoutedEventArgs e)
        {

            Window parentWindow = Window.GetWindow(this);
            object menuitem1 = parentWindow.FindName("MenuQnAService");
            object menuitem2 = parentWindow.FindName("MenuQnAKB");

            MenuItem menuQnAService = (MenuItem)menuitem1;
            MenuItem menuQnAKB = (MenuItem)menuitem2;

            if (QnACheck.IsChecked == true)
            {
                menuQnAService.Visibility = Visibility.Visible;
                menuQnAKB.Visibility = Visibility.Visible;
            }
            else
            {
                menuQnAService.Visibility = Visibility.Collapsed;
                menuQnAKB.Visibility = Visibility.Collapsed;
            }
        }
    }
}
