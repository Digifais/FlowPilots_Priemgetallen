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
using Java.Lang;

namespace AppPriemgetallen
{
    [Activity(Label = "Priemgetallen")]
    public class PrimeNumbersActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            var primeNumbers = Intent.Extras.GetIntegerArrayList("prime_numbers");

            this.ListAdapter = new ArrayAdapter<Integer>(this, Android.Resource.Layout.SimpleListItem1, primeNumbers);
        }
    }
}