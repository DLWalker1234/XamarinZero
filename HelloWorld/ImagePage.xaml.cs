using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            // var imageSource = (UriImageSource) ImageSource.FromUri(new Uri());
            // var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            //imageSource.CachingEnabled = false;

            // For caching images when closing and reopening apps
            // imageSource.CacheValidity = TimeSpan.FromHours(1)
            // image.Source = imageSource;
            //image.Aspect = Aspect;

            //image.Source = ImageSource.FromResource("HelloWorld.Images.face.jpg");

            btn.Image = (FileImageSource) ImageSource.FromFile(Device.OnPlatform(
                iOS: "clock.png",
                Android: "clock.png",
                WinPhone: "Images/clock.png"
            ));
        }

    }
}
