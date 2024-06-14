namespace practico4maui.Views;

public partial class Principal : ContentPage
{
	public Principal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Acercade());
    }
}