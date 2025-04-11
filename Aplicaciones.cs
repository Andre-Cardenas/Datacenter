using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Aplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static private string cadena = "server=dataepis.uandina.pe,49157;Database=BDAcademicoCárdenas;Uid=cardenasc;pwd=Elmoroky5";
        static private SqlConnection conexion= new SqlConnection(cadena);

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_TAlumno_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("spListarAlumnos", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvDatos.DataSource = tabla;
        }

        private void btn_TDocente_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("spListarDocentes", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvDatos.DataSource = tabla;
        }

        private void btn_TAsignatura_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("spListarAsignaturas", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvDatos.DataSource = tabla;
        }

        private void btn_TCarrera_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("spListarCarreras", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvDatos.DataSource = tabla;
        }
    }
    }

