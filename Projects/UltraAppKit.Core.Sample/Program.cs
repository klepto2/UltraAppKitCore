﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace UltraAppKitCore.Sample
{
    public class TestWidget : Widget
    {
        //Custom members
        private bool hover;
        public TestWidget(string text, int x, int y, int width, int height, Widget parent, int style) : base()
        {
            Initialize(new WString(text), x, y, width, height, parent, style);
        }

        public override void MouseEnter(int x, int y)
        {
            hover = true;
            Redraw();
        }

        public override void MouseLeave(int x, int y)
        {
            hover = false;
            Redraw();
        }

        public override void Draw(int x, int y, int width, int height)
        {
            blocks.Clear();
            Vec4 color = new Vec4(1, 0, 0, 1);
            if (hover) color = new Vec4(0, 1, 0, 1);

            //Background rectangle
            AddBlock(new iVec2(0), this.size, color);

            //Foreground text
            AddBlock(text, new iVec2(0), this.size, new Vec4(1), (int)(TextAlignment.TEXT_CENTER | TextAlignment.TEXT_MIDDLE));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Get displays
            var displays = UltraAppKit.GetDisplays();
            if (displays.Count == 0) return;
            float dpiscale = displays[0].scale;

            //Create window
            var mainwindow = UltraAppKit.CreateWindow(new WString("Ultra App Kit - .Net Core"), 0, 0,
                (int) (1000 * dpiscale), (int) (800 * dpiscale), displays[0],
                WindowStyles.WINDOW_HIDDEN | WindowStyles.WINDOW_CENTER | WindowStyles.WINDOW_TITLEBAR |
                WindowStyles.WINDOW_RESIZABLE);

            //Create user interface
            var ui = UltraAppKit.CreateInterface(mainwindow);
            ui.LoadColorScheme(new WString("Themes\\light.json"));
            iVec2 sz = ui.root.ClientSize();
            var label = UltraAppKit.CreateLabel(new WString("Application Interface"), 0, 0, sz.x, sz.y, ui.root,
                LabelStyle.LABEL_CENTER | LabelStyle.LABEL_MIDDLE);
            label.SetLayout(1, 1, 1, 1);

            var button = UltraAppKit.CreateButton(new WString("Button"), 0, 0, 100, 20, ui.root,
                ButtonStyle.BUTTON_DEFAULT);
            button.SetLayout(1, 0, 1, 0);

            label.color[(int)WidgetColor.WIDGETCOLOR_FOREGROUND] = new Vec4(1.0f, 0.0f, 0.0f,1.0f);

            var testWidget = new TestWidget("testWidget", 40, 120, 200, 40, ui.root, 0);
            testWidget.SetLayout(1, 0, 1, 0);

            //Enable DPI scaling changes
            ui.SetScale(dpiscale);

            //Show the window
            mainwindow.Show();
            mainwindow.Activate();
            bool open = true;

            while (open)
            {
                var ev = UltraAppKit.WaitEvent();
                switch (ev.id)
                {
                    case EventID.EVENT_WIDGETSELECT:
                        break;
                    case EventID.EVENT_WIDGETACTION:
                        break;
                    case EventID.EVENT_WINDOWCLOSE:
                        bool eq = ev.source == mainwindow;
                        if (eq)
                            open = false;
                        break;
                }
            }
        }
    }
}
