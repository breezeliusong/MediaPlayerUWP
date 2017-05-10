using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MediaPlayerUWP
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();
            mediaPlayerElement.SetMediaPlayer(mediaPlayer);
            Uri uri = new Uri("https://wo6q3w-dm2305.files.1drv.com/y4mj0NP1pL6AZQ_TVOw9itzm75T1qAHRET_rARz9qTqoNzZKP7Yjvy1WeO1_4HNc60kqCZzm2wOG5hgBtJk3U_xQuK_QtkPhOp01QnbtJif6KI3lr2QTI1mKzQ9DqgHpb_VteuxPldm4DOZdnC-kQJZJ1gPLuA74OuZgjgYXuhepAjTqPAlIFhaIZkD1WmpHbk1/test.mkv?download&psid=1");
            StorageFile file =await StorageFile.CreateStreamedFileFromUriAsync("test.mkv",
                uri,
                null);
            IRandomAccessStream stream =await file.OpenAsync( FileAccessMode.Read);
            mediaPlayer.Source= MediaSource.CreateFromStream(stream, "video/x-matroska");
            mediaPlayer.Play();

        }
    }
}
