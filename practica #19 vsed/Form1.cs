namespace practica__19_vsed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            // Intentar obtener las calificaciones de los TextBox
            try
            {
                double cal1 = Convert.ToDouble(calificaciones1.Text);
                double cal2 = Convert.ToDouble(calificaciones2.Text);
                double cal3 = Convert.ToDouble(calificaciones3.Text);
                double cal4 = Convert.ToDouble(calificaciones4.Text);

                // Arreglo de calificaciones
                double[] calificaciones = { cal1, cal2, cal3, cal4 };
                double suma = 0;
                bool aprobado = true;

                // Validar cada calificación
                foreach (double calificacion in calificaciones)
                {
                    if (calificacion < 6)
                    {
                        aprobado = false;
                    }
                    suma += calificacion;
                }
                // Calcular promedio
                double promedio = suma / 4;

                // Verificar si el promedio cumple con la condición
                if (promedio < 6)
                {
                    aprobado = false;
                }
                // Mostrar el resultado
                if (aprobado)
                {
                    label1.Text = "El alumno aprobó.";
                }
                else
                {
                    label1.Text = "El alumno reprobó.";
                }
            }
            catch (FormatException)
            {
                label1.Text = "Por favor, ingrese valores numéricos válidos en todas las calificaciones.";
            }
            
        }
    }
}
