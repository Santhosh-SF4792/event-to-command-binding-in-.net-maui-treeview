using Syncfusion.Maui.TreeView;
using Syncfusion.TreeView.Engine;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMaui
{
    public class FileManagerViewModel
    {
        #region Fields
        private Command<ItemSelectionChangedEventArgs> selectionChangedCommand;
        private ObservableCollection<FileManager> imageNodeInfo;
        #endregion

        #region Constructor

        public FileManagerViewModel()
        {
            SelectionChangedCommand = new Command<Syncfusion.Maui.TreeView.ItemSelectionChangedEventArgs>(OnSelectionChanged);
            GenerateSource();
        }

        private void OnSelectionChanged(ItemSelectionChangedEventArgs args)
        {
            App.Current.MainPage.DisplayAlert("Alert", (args.AddedItems[0] as FileManager).ItemName + " is selected", "OK");
        }
        #endregion

        #region Properties
        public Command<ItemSelectionChangedEventArgs> SelectionChangedCommand
        {
            get { return selectionChangedCommand; }
            set { selectionChangedCommand = value; }
        }

        public ObservableCollection<FileManager> ImageNodeInfo
        {
            get { return imageNodeInfo; }
            set { this.imageNodeInfo = value; }
        }
        #endregion

        #region Generate Source
        private void GenerateSource()
        {
            var nodeImageInfo = new ObservableCollection<FileManager>();

            var doc = new FileManager() { ItemName = "Documents" };
            var download = new FileManager() { ItemName = "Downloads" };
            var mp3 = new FileManager() { ItemName = "Music" };
            var pictures = new FileManager() { ItemName = "Pictures" };
            var video = new FileManager() { ItemName = "Videos" };

            var pollution = new FileManager() { ItemName = "Environmental Pollution.docx" };
            var globalWarming = new FileManager() { ItemName = "Global Warming.ppt" };
            var sanitation = new FileManager() { ItemName = "Sanitation.docx" };
            var socialNetwork = new FileManager() { ItemName = "Social Network.pdf" };
            var youthEmpower = new FileManager() { ItemName = "Youth Empowerment.pdf" };

            var tutorials = new FileManager() { ItemName = "Tutorials.zip" };
            var typeScript = new FileManager() { ItemName = "TypeScript.7z" };
            var uiGuide = new FileManager() { ItemName = "UI-Guide.pdf" };

            var song = new FileManager() { ItemName = "Gouttes" };

            var camera = new FileManager() { ItemName = "Camera Roll" };
            var stone = new FileManager() { ItemName = "Stone.jpg" };
            var wind = new FileManager() { ItemName = "Wind.jpg" };

            var img0 = new FileManager() { ItemName = "WIN_20160726_094117.JPG" };
            var img1 = new FileManager() { ItemName = "WIN_20160726_094118.JPG" };

            var video1 = new FileManager() { ItemName = "Naturals.mp4" };
            var video2 = new FileManager() { ItemName = "Wild.mpeg" };

            doc.SubFiles = new ObservableCollection<FileManager>
            {
                pollution,
                globalWarming,
                sanitation,
                socialNetwork,
                youthEmpower
            };

            download.SubFiles = new ObservableCollection<FileManager>
            {
                tutorials,
                typeScript,
                uiGuide
            };

            mp3.SubFiles = new ObservableCollection<FileManager>
            {
                song
            };

            pictures.SubFiles = new ObservableCollection<FileManager>
            {
                camera,
                stone,
                wind
            };
            camera.SubFiles = new ObservableCollection<FileManager>
            {
                img0,
                img1
            };

            video.SubFiles = new ObservableCollection<FileManager>
            {
                video1,
                video2
            };

            nodeImageInfo.Add(doc);
            nodeImageInfo.Add(download);
            nodeImageInfo.Add(mp3);
            nodeImageInfo.Add(pictures);
            nodeImageInfo.Add(video);
            imageNodeInfo = nodeImageInfo;
        }
        #endregion
    }
}
