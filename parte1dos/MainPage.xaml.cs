namespace parte1dos;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        valor1.Focus();
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            float a = float.Parse(valor1.Text);
            float b = float.Parse(valor2.Text);
            if (R1.IsChecked)
            {
                float c = a + b;
                resultado.Text = a + "+" + b + "=" + c;
            }
            if (R2.IsChecked)
            {
                float c = a - b;
                resultado.Text = a + "-" + b + "=" + c;
            }
        }
        catch
        {
            resultado.Text = "Error al capturar los datos!!";
        }
    }
}