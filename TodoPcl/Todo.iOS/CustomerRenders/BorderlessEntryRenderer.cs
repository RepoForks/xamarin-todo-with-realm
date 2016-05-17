
using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using Todo.iOS;

[assembly:ExportRenderer(typeof(Entry), typeof(BorderlessEntryRenderer))]
namespace Todo.iOS
{
	public class BorderlessEntryRenderer : EntryRenderer
	{
		public BorderlessEntryRenderer ()
		{
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);

			if (this.Control == null) return;
			//this.Control.BorderStyle = UITextBorderStyle.None;
			Control.BackgroundColor = UIColor.LightTextColor;
		}
	}
}

