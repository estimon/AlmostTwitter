using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AlmostTwitter
{
    public class comments
    {
        public string ComName {get; set;}
        public string Comment { get; set; }
        public int Like { get; set; }
    }
}