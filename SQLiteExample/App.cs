using System;
using Xamarin.Forms;

namespace SQLiteExample
{
	public class App
	{
		public static Page GetMainPage ()
		{	
            var db = DependencyService.Get<ISQLiteFactory> ().GetConnection ("test.db");

            db.DropTable<ContactModel> ();
            db.CreateTable<ContactModel> ();

            db.Insert (new ContactModel () { Name = "Hello SQL" });

			return new ContentPage { 
				Content = new Label {
                    Text = db.Table<ContactModel>().First().Name,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}
	}
}

