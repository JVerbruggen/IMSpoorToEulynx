using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_XMLConvert_Click(object sender, RoutedEventArgs e)
        {
            String filePath = TextBox_PathXML.Text;

            IMSpoor imSpoor = imSpoorFileReadService.Read(filePath);
            Eulynx eulynx = imspoorToEulynxTranslationService.Translate(imSpoor);

            XDocument eulynxDoc = eulynxSerializer.Serialize(eulynx);

            saveFileDialog_EulynxXMLOutput.InitialDirectory = @"C:\Users\jurje\OneDrive\Documenten\Eulynxgens\EULYNX-from-IMSpoor.xml";
            if (saveFileDialog_EulynxXMLOutput.ShowDialog() == DialogResult.OK)
            {
                eulynxDoc.Save(saveFileDialog_EulynxXMLOutput.FileName);
            }
        }
    }
}
