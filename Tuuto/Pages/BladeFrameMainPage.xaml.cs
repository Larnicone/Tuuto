﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Mastodon.Api;
using Tuuto.Common;
using Tuuto.ViewModel;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace Tuuto.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class BladeFrameMainPage : Page
    {
        public BladeFrameMainPage()
        {
            this.InitializeComponent();
        }

        void GoTimelineLocal()
        {
            Frame.Navigate(typeof(StatusListPage), new StatusListViewModel((max_id) => Timelines.Public(Settings.CurrentAccount.Domain, max_id: max_id, local: true)));
        }

        void GoTimelineFederated()
        {
            Frame.Navigate(typeof(StatusListPage), new StatusListViewModel((max_id) => Timelines.Public(Settings.CurrentAccount.Domain, max_id: max_id)));
        }
    }
}
