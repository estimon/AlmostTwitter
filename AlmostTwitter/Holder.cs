using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AlmostTwitter
{
    public class Holder
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Message { get; set; }
        public string itbe { get; set; }
        public int Like { get; set; }
        public List<comments> PostComment { get; set; }
    }
}