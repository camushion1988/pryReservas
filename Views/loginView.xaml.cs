namespace pryReservas.Views;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}

    private async void CreateAccount_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Registro());
    }
}