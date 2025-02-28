using System.Diagnostics.Eventing.Reader;
using System.Security.Authentication;

namespace WinFormsApp1
{
    //Inicializar Variables Globales

    public partial class Form1 : Form
    {
        string alumno;
        int nota1, nota2, nota3, promedioAlula = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ntnNuevo_Click(object sender, EventArgs e)
        {
            txtAlumno.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtPromedioAula.Clear();
            lstAlumno.Items.Clear();
            lstNota1.Items.Clear();
            lstNota2.Items.Clear();
            lstNota3.Items.Clear();
            txtPromedioAula.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Asignar campos a las variables
            nota1 = Convert.ToInt32(txtNota1.Text);
            nota2 = Convert.ToInt32(txtNota2.Text);
            nota3 = Convert.ToInt32(txtNota3.Text);
            alumno = txtAlumno.Text;
            promedioAlula = (nota1 + nota2 + nota3) / 3;

            //Agregar a las listas
            lstNota1.Items.Add(nota1);
            lstNota2.Items.Add(nota2);
            lstNota3.Items.Add(nota3);
            lstPromedio.Items.Add(txtPromedioAula);
            lstAlumno.Items.Add(alumno);


        }
        private void marcar(ListBox Lista)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int indice;
            indice = lstAlumno.SelectedIndex;

            //eliminar elementos de la lista
            lstAlumno.Items.RemoveAt(indice);
            lstNota1.Items.RemoveAt(indice);
            lstNota2.Items.RemoveAt(indice);
            lstNota3.Items.RemoveAt(indice);
            lstPromedio.Items.RemoveAt(indice);

            int total = 0;
            for (int i = 0; i < lstPromedio.Items.Count; i++)
            {
                total += Convert.ToInt32(lstPromedio.Items[i]);
            }
            txtPromedioAula.Text = total.ToString();
        }

        private void lstAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstAlumno);
        }

        private void lstNota1_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstNota1);
        }

        private void lstNota2_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstNota2);
        }

        private void lstNota3_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstNota3);
        }

        private void lstPromedio_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstPromedio);
        }
    }
}
