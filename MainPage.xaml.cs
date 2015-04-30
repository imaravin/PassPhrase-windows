using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
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
using Windows.UI.Popups;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PassPhrase
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    
    public sealed partial class MainPage : Page
    {
    
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
        public string CreatePassword(int length )
        {
            string valid ="";
            const string alphanumchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            const string alphachar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numchar="1234567890";
            const string splchar="abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^*()<,>.?/";
            if ((Boolean)alpha.IsChecked)
                valid = alphachar;
            else if ((Boolean)alphanum.IsChecked)
                valid = alphanumchar;
            else if ((Boolean)numeral.IsChecked)
                valid = numchar;
            else if ((Boolean)spl.IsChecked)
                valid = splchar;
            System.Text.StringBuilder res = new System.Text.StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        private void create_Click(object sender, RoutedEventArgs e)
        {
            if (slider.Value != 0)
                text.Text = CreatePassword((Int32)slider.Value);
            else
            {
                
            }
        }

       
        private void copy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = new Windows.ApplicationModel.DataTransfer.DataPackage();
                data.SetText(text.Text);
                Windows.ApplicationModel.DataTransfer.Clipboard.SetContent(data);
            }
            catch
            {
                text.Text = "Cant copy zero length PassPhrase";
            }
        }

        private void slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

       
       
       
    }
}
