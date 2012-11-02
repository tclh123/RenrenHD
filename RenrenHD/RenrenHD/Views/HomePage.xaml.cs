﻿using RenrenCore.RRServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace RenrenHD.Views
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();

        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        async protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            System.Collections.ObjectModel.ObservableCollection<object> ItemList = new System.Collections.ObjectModel.ObservableCollection<object>();
            foreach (View s in Constants.ViewList)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = s;
                item.Name = s.ClassType.FullName;
                ItemList.Add(item);
            }
            lstViews.ItemsSource = ItemList;

            //get my user info
            var info = await UserInfoService.Instance.RequestMyUserInfo();
            imgHead.Source = new BitmapImage(new Uri(info.Result.Head_url));
            txtName.Text = info.Result.User_name;
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (lstViews.SelectedItem != null)
            {
                ListBoxItem selectedListBoxItem = lstViews.SelectedItem as ListBoxItem;

                View to = selectedListBoxItem.Content as View;
                frmContent.Navigate(to.ClassType);
            }
        }
    }
}
