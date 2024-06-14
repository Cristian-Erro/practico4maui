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
        if (entusuario.Text == "alumno" && entcontraseña.Text == "1234")
        {
            entcontraseña.Text = string.Empty;
            entusuario.Text = string.Empty;
            Navigation.PushAsync(new Principal());
        }
        else
        {
            entcontraseña.Text = string.Empty;
            entusuario.Text = string.Empty;
            DisplayAlert("Error", "Usuario y/o contraseña incorrectos", "OK");
        }
    }
}