namespace MauiAppHostel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        try
        {
            PropriedadesApp = (App)Application.Current;
            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

            dtpck_checkin.Date = DateTime.Now;
            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

            DateTime dataCheckin = dtpck_checkin.Date ?? DateTime.Now;
            dtpck_checkout.Date = dataCheckin.AddDays(1);
            dtpck_checkout.MinimumDate = dataCheckin.AddDays(1);
            dtpck_checkout.MaximumDate = dataCheckin.AddMonths(6);
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro ao carregar", ex.Message, "OK");
        }
    }



    public void Button_Clicked(object sender, EventArgs e)
	{

		try
		{

			Navigation.PushAsync(new HospedagemContratada());

		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}

	}

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {

        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date.Value;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);


    }
}