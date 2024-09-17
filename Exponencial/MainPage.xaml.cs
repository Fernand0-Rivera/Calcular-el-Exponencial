namespace Exponencial{
    public partial class MainPage : ContentPage{
        public MainPage() => InitializeComponent();
        private void BtnCal(object sender, EventArgs e) =>Navigation.PushAsync(new Page1());
    }
}