﻿

#pragma checksum "C:\Users\aravinth\documents\visual studio 2013\Projects\PassPhrase\PassPhrase\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FA65ABDA5089155395D3208BD7A3C57E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PassPhrase
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 12 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBlock)(target)).SelectionChanged += this.TextBlock_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 20 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.TextBox_TextChanged;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 21 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.RangeBase)(target)).ValueChanged += this.slider_ValueChanged;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 22 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.RadioButton_Checked;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 26 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.copy_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 27 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.create_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


