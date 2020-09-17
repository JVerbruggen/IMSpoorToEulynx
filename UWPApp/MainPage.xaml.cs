using Models.File;
using Models.Service;
using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor;
using Models.Translation;
using Services.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
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
        private ITranslationService<IMSpoor, Eulynx> imspoorToEulynxTranslationService = new IMSpoorToEulynxTranslationService();
        private IReadFileService<IMSpoor> imSpoorFileReadService = new ReadIMSpoorFileService();
        private IXDocSerializer<Eulynx> eulynxSerializer = new XDocSerializeService();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void saveXDocument(XDocument xDocument )
        {
            var savePicker = new Windows.Storage.Pickers.FileSavePicker();
            savePicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            savePicker.FileTypeChoices.Add("XML File", new List<string>() { ".xml" });
            savePicker.SuggestedFileName = "EULYNX-from-IMSpoor.xml";

            Windows.Storage.StorageFile file = await savePicker.PickSaveFileAsync();
            if (file != null)
            {
                Windows.Storage.CachedFileManager.DeferUpdates(file);

                xDocument.Save(file.Path);

                Windows.Storage.Provider.FileUpdateStatus status = await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(file);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    Console.Out.WriteLine("File saved");

                }
                else
                {
                    Console.Out.WriteLine("File couldn't be saved");
                }
            }
            else
            {
                Console.Out.WriteLine("Open save file cancelled");
            }
        }

        private void Button_XMLConvert_Click(object sender, RoutedEventArgs e)
        {
            String filePath = TextBox_PathXML.Text;

            IMSpoor imSpoor = imSpoorFileReadService.Read(filePath);
            Eulynx eulynx = imspoorToEulynxTranslationService.Translate(imSpoor);

            XDocument eulynxDoc = eulynxSerializer.Serialize(eulynx);

            saveXDocument(eulynxDoc);
        }
    }
}
