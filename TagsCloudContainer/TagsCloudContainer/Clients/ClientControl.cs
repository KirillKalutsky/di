﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsCloudContainer
{
    public class ClientControl
    {
        private IClient client;
        private WordCloudSaver saver;
        public ClientControl(IClient client, WordCloudSaver saver)
        {
            this.client = client;
            this.saver = saver;
        }

        public void Start()
        {
            var path = saver.SaveCloud(GetNameForImage(), GetImageSettings());
            client.ShowPathToNewFile(path);
        }

        public ImageSettings GetImageSettings() => new ImageSettings
            (
                client.GetImageSize(),
                client.GetFontFamily(),
                client.GetTextColor(),
                client.GetBackgoundColor()
            );

        public string GetNameForImage() => client.GetNameForImage();

        public void ShowPathToImage(string path) => client.ShowPathToNewFile(path);

    }
}