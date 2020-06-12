﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Windows;
using System.Windows.Controls;

namespace BotManagerVSIX
{
    /// <summary>
    /// Interaction logic for AppServiceView.xaml
    /// </summary>
    public partial class AppServiceView : UserControl
    {
        public AppServiceView()
        {
            InitializeComponent();
        }

        private void ResourceGroupButton_Click(object sender, RoutedEventArgs e)
        {
            ResourceGroupView.OpenAndSyncResourceGroupView(ResourceGroupCombo);
        }
    }
}
