using System.Drawing;
using CustomKeyboard;
using CustomKeyboard.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryWithCustomKeyboard), typeof(EntryWithCustomKeyboardRenderer))]

namespace CustomKeyboard.iOS.Renderers
{
    class EntryWithCustomKeyboardRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> args)
        {
            base.OnElementChanged(args);
            this.Control.KeyboardType = UIKeyboardType.NumberPad;



            UIToolbar toolBar = new UIToolbar(new RectangleF(0.0f, 0.0f, (float)this.Frame.Size.Width, 44.0f));
            toolBar.Translucent = true;
            toolBar.Items = new UIBarButtonItem[] {              


                
                new UIBarButtonItem("ABC", UIBarButtonItemStyle.Bordered, delegate {
                    this.Control.KeyboardType = UIKeyboardType.Default;
                    this.OnElementChanged(args);
                }),
                new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
                new UIBarButtonItem (UIBarButtonSystemItem.Done, delegate {
                    this.Control.ResignFirstResponder();
                })
            };

            this.Control.InputAccessoryView = toolBar;

        }
    }
}