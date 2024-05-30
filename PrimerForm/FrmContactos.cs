using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PrimerForm
{
    public partial class FrmContactos : Form
    {
        private List<Contacto> contactos;
        public FrmContactos()
        {
            InitializeComponent();
            contactos = new List<Contacto>();

            contactos.Add(new Contacto(1, "Orlando", "obetancourthunicah@gmail.com", "00000000"));
            contactos.Add(new Contacto(2, "Arnulfo", "arnulfo@gmail.com", "00000000"));
            contactos.Add(new Contacto(3, "Beatriz", "beatriz@gmail.com", "00000000"));

            this.bindingSource1.DataSource = contactos;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmContacto frmContacto = new FrmContacto();
            //frmContacto.Show(); // Abre el formulario como un panel
            frmContacto.ShowDialog(); // Bloquea lo demas y solo permite trabajar en el formulario abierto
            //MessageBox.Show("Se Muestra");
            if (frmContacto.IsConfirmed == true)
            {
                Contacto nuevo = new Contacto(
                        this.contactos.Count + 1,
                        frmContacto.ContactName,
                        frmContacto.ContactEmail,
                        frmContacto.ContactPhone
                    );
                this.bindingSource1.Add(nuevo);
            }
            frmContacto = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializador = new XmlSerializer(
                    typeof(List<Contacto>)
                );
                string archivoAGuardar = saveDialog.FileName;
                StreamWriter generadorDelArchivo = new StreamWriter(archivoAGuardar);
                serializador.Serialize(generadorDelArchivo, contactos);
                MessageBox.Show("Archivo Guardado Exitosamente!!!");
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string archivoALeer = openDialog.FileName;
                XmlSerializer serializador = new XmlSerializer(
                   typeof(List<Contacto>)
                );
                StreamReader lectoraDeArchivo = new StreamReader(archivoALeer);
                List<Contacto> tmpContactos = (List<Contacto>)serializador.Deserialize(lectoraDeArchivo) ?? new List<Contacto>();
                contactos = tmpContactos;
                bindingSource1.DataSource = contactos;
                MessageBox.Show("Archivo Cargado Exitosamente");
            }
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Contacto selectedContact = (Contacto) dataGridView1.SelectedRows[0].DataBoundItem;
            if (selectedContact != null)
            {
                MessageBox.Show(selectedContact.Name + " " + selectedContact.Created.ToString());
            }
        }
    }
}
