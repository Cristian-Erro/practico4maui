namespace practico4maui.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        if (entusuario.Text == "alumno" && entcontrase�a.Text == "1234")
        {
            entcontrase�a.Text = string.Empty;
            entusuario.Text = string.Empty;
            Navigation.PushAsync(new Principal());
        }
        else
        {
            entcontrase�a.Text = string.Empty;
            entusuario.Text = string.Empty;
            DisplayAlert("Error", "Usuario y/o contrase�a incorrectos", "OK");
        }
    }
}