namespace practico4maui.Views;

public partial class Acercade : ContentPage
{
	public Acercade()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Principal());
    }
}