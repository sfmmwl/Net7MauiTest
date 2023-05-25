namespace Net7MauiTest;

public partial class MainPage : ContentPage
{
	int count = 0;
	private void Log(object obj)
	{
		System.Diagnostics.Debug.Print($"{obj}");
	}
	public MainPage()
	{
		InitializeComponent();

		//BindingContext = new MainViewModel();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

		Microsoft.Maui.Font DefaultFont = Microsoft.Maui.Font.Default;

		Log($"default font:{DefaultFont.Family}");

		var name=System.Globalization.CultureInfo.CurrentCulture.Name;
		Log($"name:{name}");

		var displayName=System.Globalization.CultureInfo.CurrentCulture.DisplayName;
		Log($"display name:{displayName}");

		var uiName = System.Globalization.CultureInfo.CurrentUICulture.Name;
		Log($"ui name:{uiName}");

		var uiDisplayName = System.Globalization.CultureInfo.CurrentUICulture.DisplayName;
		Log($"ui display name:{uiDisplayName}");
	}

}

