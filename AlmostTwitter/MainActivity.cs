﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AlmostTwitter
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.list);

            var list1 = FindViewById<ListView>(Resource.Id.listView1);

            var listholder = new List<Holder>();
            Holder Elon = new Holder
            {
                Name = "Elon Musk",
                Date = DateTime.Today.ToString(),
                Message = "Libtard destoryed with facts and knowledge",
                itbe = "Elon_Musk_2015"


            };
            listholder.Add(Elon);


             
            Holder Trupm = new Holder
            {
                Name = "Trump",
                Date = DateTime.Today.ToString(),
                Message = "Thank you Kanye very cool",
                itbe = "kUuht00m_400x400"
            };
            listholder.Add(Trupm);

            Holder deepnigga= new Holder
            {
                Name = "Wise Nigga",
                Date = DateTime.Today.ToString(),
                Message = "It be like that sometimes",
                itbe = "Capture"
            };
            listholder.Add(deepnigga);





            list1.Adapter = new Adapterlist(this, listholder);
        
        }
    }
}