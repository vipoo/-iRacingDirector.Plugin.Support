﻿using System;
using System.Drawing;

namespace iRacingDirector.Plugin.Tester
{
    public class RemoteImageViewer : MarshalByRefObject
    {
        private ImageViewer frm;

        public RemoteImageViewer()
        {
            frm = new ImageViewer();
        }

        public Size ClientSize
        {
            get
            {
                return frm.ClientSize;
            }
            set
            {
                frm.ClientSize = value;
            }
        }

        public void SetBackgroundImage(string imagePath)
        {
            frm.BackgroundImage = Image.FromFile(imagePath);
        }

        public void Show()
        {
            frm.Show();
        }

        internal void Activate()
        {
            frm.Activate();
        }

        internal void Refresh()
        {
            frm.Refresh();
        }

        public void SetPluginFileName(string fileName)
        {
            frm.SetPluginFileName(fileName);
        }

        internal void SetPosition(int left, int top)
        {
            frm.Left = left;
            frm.Top = top;
        }
    }
}
