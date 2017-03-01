using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Collections.Generic;
using Java.Lang;

namespace AppPriemgetallen
{
    [Activity(Label = "Priemgetallen", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        static readonly List<Integer> primeNumbers = new List<Integer>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            EditText etNumber = FindViewById<EditText>(Resource.Id.editTextNumber);
            Button btnConfirm = FindViewById<Button>(Resource.Id.btnConfirm);

            btnConfirm.Click += (sender, e) =>
            {
                foreach(int i in PrimeNumberGenerator.GeneratePrimeNumbers(int.Parse(etNumber.Text)))
                {
                    primeNumbers.Add((Integer)i);
                }

                var intent = new Intent(this, typeof(PrimeNumbersActivity));

                intent.PutIntegerArrayListExtra("prime_numbers", primeNumbers);
                StartActivity(intent);

                primeNumbers.Clear();
            };
        }
    }
}

