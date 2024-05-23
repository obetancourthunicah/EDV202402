namespace PrimerForm
{
    public partial class FrmGeneradorDeCuenta : Form
    {
        private GeneradorCuenta miGeneradorDeCuenta;
        public FrmGeneradorDeCuenta()
        {
            InitializeComponent();
            this.miGeneradorDeCuenta = new GeneradorCuenta();
        }

        private void btnSubstituir_Click(object sender, EventArgs e)
        {
            Boolean invertir = chkInvertir.Checked;
            string cuentaConSubstitucion = miGeneradorDeCuenta.obtenerNuevaCuenta(invertir);
            this.txtNuevoNumero.Text = cuentaConSubstitucion;
        }

        private void txtNumerCuenta_OnTextChanged(object sender, EventArgs e)
        {
            string numeroDeCuenta = this.txtNumeroCuenta.Text;
            miGeneradorDeCuenta.setNumeroCuenta(numeroDeCuenta);
            if (String.IsNullOrEmpty(numeroDeCuenta))
            {
                this.btnAddSubstituciones.Enabled = false;
            } else
            {
                this.btnAddSubstituciones.Enabled = true;
            }
        }

        private void btnAddSubstituciones_Click(object sender, EventArgs e)
        {
            string substitucion = this.txtSubstituir.Text;
            string por = this.txtPor.Text;
            this.miGeneradorDeCuenta.agregarSubstitucion(substitucion, por);
            this.btnSubstituir.Enabled = true;

            this.txtSubstituciones.Text = this.miGeneradorDeCuenta.getSubstituciones();
        }
    }
}
