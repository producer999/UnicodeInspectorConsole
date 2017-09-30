using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using sourcEleven.UWP.HindiSuggestBoxPCL;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UnicodeInspectorUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //private double[] _fontSizes = {14, 24, 104, 164, 240};
        //public List<double> FontSizes;

        public MainPage()
        {
            this.InitializeComponent();

            //FontSizes = _fontSizes.ToList();
            //double d = FontSizes[4];

            DataContext = this;

            TextInput.EnableHindiIME();
        }

        private void CopyText_Button(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                DataPackage package = new DataPackage();
                package.RequestedOperation = DataPackageOperation.Copy;

                if (button.Name == "CopyHexButton")
                {
                    package.SetText(HexText.Text);
                }
                else if(button.Name == "CopyIntButton")
                {
                    package.SetText(IntText.Text);
                }
                else if(button.Name == "CopyOutputButton")
                {
                    package.SetText(OutputText.Text);
                }

                Clipboard.SetContent(package);
            }
        }
    }
}
