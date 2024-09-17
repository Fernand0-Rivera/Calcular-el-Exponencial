namespace Exponencial;
public partial class Page1 : ContentPage{
    double x, r;
    Calculadora cal1;
    public Page1() {
		InitializeComponent();
		cal1 = new Calculadora();
	}
    private void BtnExp(object sender, EventArgs e){
		Entrada();
		r = cal1.CalExp(x);
		Salida();
    }
	public void Entrada() => x = double.Parse(dato1.Text);
	public void Salida() =>	result.Text = r.ToString();    
}