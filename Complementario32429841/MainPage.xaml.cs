using Complementario32429841.Resources;

namespace Complementario32429841
{
    public partial class MainPage : ContentPage
    {
        private NotasAlum notasAlum;

        public MainPage()
        {
            InitializeComponent();
            notasAlum = new NotasAlum();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            notasAlum.Calificaciones.Add(Convert.ToDouble(CalificacionEntry1.Text));
            notasAlum.Calificaciones.Add(Convert.ToDouble(CalificacionEntry2.Text));
            notasAlum.Calificaciones.Add(Convert.ToDouble(CalificacionEntry3.Text));
            notasAlum.Calificaciones.Add(Convert.ToDouble(CalificacionEntry4.Text));
            notasAlum.Calificaciones.Add(Convert.ToDouble(CalificacionEntry5.Text));

            double promedio = notasAlum.CalcularPromedio();
            promedioL.Text = $"Promedio: {promedio.ToString("F2")}";
        }
    }

}
