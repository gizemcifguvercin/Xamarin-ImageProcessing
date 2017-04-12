using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Android.Views;
using System;
using Android.Content;
using Android.Provider;
using Android.Database;
using Android.Graphics.Drawables;

namespace XamarinImageEditor
{
	[Activity(Label = "XamarinImageEditor", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity, Android.Views.View.IOnClickListener
	{
		Button pickImageBtn;
		ImageView pickedImage;
		Bitmap bitImage;
		Bitmap bitImg;
		Bitmap operations;
 
        protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			initialize();
 
		}
        public void initialize()
        {
            pickedImage = (ImageView)FindViewById(Resource.Id.image);
            pickImageBtn = (Button)FindViewById(Resource.Id.pickImage);
            pickImageBtn.SetOnClickListener(this);
            Button btnNegative = FindViewById<Button>(Resource.Id.btnNegative);
            Button btnColoredNegative = FindViewById<Button>(Resource.Id.btnColoredNegative);
            Button olcum= FindViewById<Button>(Resource.Id.olcum);
            Button btn3 = FindViewById<Button>(Resource.Id.btn3);
            Button btn4 = FindViewById<Button>(Resource.Id.btn4);
            Button btn5 = FindViewById<Button>(Resource.Id.btn5);
            Button btn6 = FindViewById<Button>(Resource.Id.btn6);

            Button btn7 = FindViewById<Button>(Resource.Id.btn7);
            Button btn8 = FindViewById<Button>(Resource.Id.btn8);
            Button btn9 = FindViewById<Button>(Resource.Id.btn9);
            Button btn10 = FindViewById<Button>(Resource.Id.btn10);

    

            btnNegative.Click += delegate
            {
                BitmapDrawable bD = (BitmapDrawable)pickedImage.Drawable;
                bitImg = bD.Bitmap;
                operations = Bitmap.CreateBitmap(bitImg.Width, bitImg.Height, bitImg.GetConfig());

                for (int i = 0; i < bitImg.Width; i++)
                {
                    for (int j = 0; j < bitImg.Height; j++)
                    {
                        int p = bitImg.GetPixel(i, j);
                        var col = new Color(p);
                        int r = col.R;
                        int g = col.G;
                        int b = col.B;

                        r = r - 70;
                        g = g - 70;
                        b = b - 70;

                        operations.SetPixel(i, j, Color.Argb(40, r, g, b));  //applying image effects
                    }
                }
                pickedImage.SetImageBitmap(operations);
            };

            btnColoredNegative.Click += delegate
            {

                BitmapDrawable bd = (BitmapDrawable)pickedImage.Drawable;    // get the image for customization
                bitImg = bd.Bitmap;    // rendering bitmap
                                       // create new bitmap
                operations = Bitmap.CreateBitmap(bitImg.Width, bitImg.Height, bitImg.GetConfig());
                // loops to get individual pixel and change it's color
                for (int i = 0; i < bitImg.Width; i++)
                {
                    for (int j = 0; j < bitImg.Height; j++)
                    {
                        int p = bitImg.GetPixel(i, j);
                        var col = new Color(p);
                        int r = col.R;
                        int g = col.G;
                        int b = col.B;

                        //subtracting value from pixel to change color
                        r = r -70;
                        g = g - 60;
                        b = b - 50;

                        // now setting pixel into a bitmap
                        operations.SetPixel(i, j, Color.Argb(40, r, g, b));  //applying image effects
                                                                             //btnNegative.SetOnClickListener(new NegativeClickListener(pickedImage, bitImg, operations));
                                                                             //btnColoredNegative.SetOnClickListener(new ColoredNegativeClickListener(pickedImage, bitImg, operations));
                    }
                }
                pickedImage.SetImageBitmap(operations); // setting bitmap Image


            };
            btn3.Click += delegate
            {
                BitmapDrawable bD = (BitmapDrawable)pickedImage.Drawable;
                bitImg = bD.Bitmap;
                operations = Bitmap.CreateBitmap(bitImg.Width, bitImg.Height, bitImg.GetConfig());

                for (int i = 0; i < bitImg.Width; i++)
                {
                    for (int j = 0; j < bitImg.Height; j++)
                    {
                        int p = bitImg.GetPixel(i, j);
                        var col = new Color(p);
                        int r = col.R;
                        int g = col.G;
                        int b = col.B;

                        r = r - 0;
                        g = g - 0;
                        b = b - 0;

                        operations.SetPixel(i, j, Color.Argb(40, r, g, b));  //applying image effects
                    }
                }
                pickedImage.SetImageBitmap(operations);
            };

            btn4.Click += delegate
            {
                BitmapDrawable bD = (BitmapDrawable)pickedImage.Drawable;
                bitImg = bD.Bitmap;
                operations = Bitmap.CreateBitmap(bitImg.Width, bitImg.Height, bitImg.GetConfig());

                for (int i = 0; i < bitImg.Width; i++)
                {
                    for (int j = 0; j < bitImg.Height; j++)
                    {
                        int p = bitImg.GetPixel(i, j);
                        var col = new Color(p);
                        int r = col.R;
                        int g = col.G;
                        int b = col.B;

                        r = r - 100;
                        g = g - 200;
                        b = b - 70;

                        operations.SetPixel(i, j, Color.Argb(40, r, g, b));  //applying image effects
                    }
                }
                pickedImage.SetImageBitmap(operations);
            };

            btn5.Click += delegate
            {
                BitmapDrawable bD = (BitmapDrawable)pickedImage.Drawable;
                bitImg = bD.Bitmap;
                operations = Bitmap.CreateBitmap(bitImg.Width, bitImg.Height, bitImg.GetConfig());

                for (int i = 0; i < bitImg.Width; i++)
                {
                    for (int j = 0; j < bitImg.Height; j++)
                    {
                        int p = bitImg.GetPixel(i, j);
                        var col = new Color(p);
                        int r = col.R;
                        int g = col.G;
                        int b = col.B;

                        r = r - 60;
                        g = g - 30;
                        b = b - 200;

                        operations.SetPixel(i, j, Color.Argb(40, r, g, b));  //applying image effects
                    }
                }
                pickedImage.SetImageBitmap(operations);
            };
            btn6.Click += delegate
            {
                BitmapDrawable bD = (BitmapDrawable)pickedImage.Drawable;
                bitImg = bD.Bitmap;
                operations = Bitmap.CreateBitmap(bitImg.Width, bitImg.Height, bitImg.GetConfig());

                for (int i = 0; i < bitImg.Width; i++)
                {
                    for (int j = 0; j < bitImg.Height; j++)
                    {
                        int p = bitImg.GetPixel(i, j);
                        var col = new Color(p);
                        int r = col.R;
                        int g = col.G;
                        int b = col.B;

                        r = r - 30;
                        g = g - 70;
                        b = b - 300;

                        operations.SetPixel(i, j, Color.Argb(40, r, g, b));  //applying image effects
                    }
                }
                pickedImage.SetImageBitmap(operations);
            };
            btn7.Click += delegate
            {
                BitmapDrawable bD = (BitmapDrawable)pickedImage.Drawable;
                bitImg = bD.Bitmap;
                operations = Bitmap.CreateBitmap(bitImg.Width, bitImg.Height, bitImg.GetConfig());

                for (int i = 0; i < bitImg.Width; i++)
                {
                    for (int j = 0; j < bitImg.Height; j++)
                    {
                        int p = bitImg.GetPixel(i, j);
                        var col = new Color(p);
                        int r = col.R;
                        int g = col.G;
                        int b = col.B;

                        r = r - 130;
                        g = g - 70;
                        b = b - 3;

                        operations.SetPixel(i, j, Color.Argb(40, r, g, b));  //applying image effects
                    }
                }
                pickedImage.SetImageBitmap(operations);
            };

            btn8.Click += delegate
            {
                BitmapDrawable bD = (BitmapDrawable)pickedImage.Drawable;
                bitImg = bD.Bitmap;
                operations = Bitmap.CreateBitmap(bitImg.Width, bitImg.Height, bitImg.GetConfig());

                for (int i = 0; i < bitImg.Width; i++)
                {
                    for (int j = 0; j < bitImg.Height; j++)
                    {
                        int p = bitImg.GetPixel(i, j);
                        var col = new Color(p);
                        int r = col.R;
                        int g = col.G;
                        int b = col.B;

                        r = r - 120;
                        g = g - 10;
                        b = b - 150;

                        operations.SetPixel(i, j, Color.Argb(40, r, g, b));  //applying image effects
                    }
                }
                pickedImage.SetImageBitmap(operations);
            };
            btn9.Click += delegate
            {
                BitmapDrawable bD = (BitmapDrawable)pickedImage.Drawable;
                bitImg = bD.Bitmap;
                operations = Bitmap.CreateBitmap(bitImg.Width, bitImg.Height, bitImg.GetConfig());

                for (int i = 0; i < bitImg.Width; i++)
                {
                    for (int j = 0; j < bitImg.Height; j++)
                    {
                        int p = bitImg.GetPixel(i, j);
                        var col = new Color(p);
                        int r = col.R;
                        int g = col.G;
                        int b = col.B;

                        r = r - 0;
                        g = g - 300;
                        b = b - 20;

                        operations.SetPixel(i, j, Color.Argb(40, r, g, b));  //applying image effects
                    }
                }
                pickedImage.SetImageBitmap(operations);
            };
            btn10.Click += delegate
            {
                BitmapDrawable bD = (BitmapDrawable)pickedImage.Drawable;
                bitImg = bD.Bitmap;
                operations = Bitmap.CreateBitmap(bitImg.Width, bitImg.Height, bitImg.GetConfig());

                for (int i = 0; i < bitImg.Width; i++)
                {
                    for (int j = 0; j < bitImg.Height; j++)
                    {
                        int p = bitImg.GetPixel(i, j);
                        var col = new Color(p);
                        int r = col.R;
                        int g = col.G;
                        int b = col.B;

                        r = r - 300;
                        g = g - 1500;
                        b = b - 10;

                        operations.SetPixel(i, j, Color.Argb(40, r, g, b));  //applying image effects
                    }
                }
                pickedImage.SetImageBitmap(operations);
            };
            olcum.Click += delegate
            {
                 var activity = new Intent(this, typeof(OranActivity));
                   
                 StartActivity(activity);
                 this.Finish();
            };
        }

        public void OnClick(View v)
		{
			switch (v.Id)
			{
				case Resource.Id.pickImage:
					Intent p = new Intent(Intent.ActionPick, Android.Provider.MediaStore.Images.Media.ExternalContentUri);
					StartActivityForResult(p, 1);
					break;
			}
		}

		protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
		{
			// TODO Auto-generated method stub

			if (requestCode == 1 && resultCode == Result.Ok && data != null) {
				Android.Net.Uri selectedImage = data.Data;
				String[] filePathColumn = { MediaStore.Images.Media.InterfaceConsts.Data };

				ICursor cursor = ContentResolver.Query(selectedImage,
						filePathColumn, null, null, null);
				cursor.MoveToFirst();

				int columnIndex = cursor.GetColumnIndex(filePathColumn[0]);
				String picturePath = cursor.GetString(columnIndex);
				cursor.Close();
				pickedImage.SetImageBitmap(BitmapFactory.DecodeFile(picturePath));

			}

		}
	
	}
}


