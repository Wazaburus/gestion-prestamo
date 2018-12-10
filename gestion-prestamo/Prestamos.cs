using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_prestamo
{
    public partial class Prestamos : Form
    {

        public Prestamos()
        {
            InitializeComponent();
        }

        private void buttonPrestamosCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPrestamosGuardar_Click(object sender, EventArgs e)
        {
            var db = new db.loans_dbEntities();
            var debtorName = textBoxDeudorNombre.Text;
            var debtorDocumentId = textBoxDeudorCedula.Text;
            var debtorTelephone = textBoxDeudorTelefono.Text;
            var guarantorName = textBoxGaranteNombre.Text;
            var guarantorDocumentId = textBoxGaranteCedula.Text;
            var guarantorTelephone = textBoxGaranteTelefono.Text;
            var amountText = textBoxDatosMonto.Text;
            decimal amount = -1;
            var time = textBoxDatosTiempo.Text;
            var closingExpenseText = textBoxDatosGastos.Text;
            decimal closingExpense = -1;
            var rateText = textBoxDatosTasa.Text;
            decimal? rate = -1;

            #region validations
            if (String.IsNullOrEmpty(debtorName))
            {
                MessageBox.Show("El nombre del deudor es obligatorio!");
                return;
            }
            if (String.IsNullOrEmpty(debtorDocumentId))
            {
                MessageBox.Show("El cédula del deudor es obligatorio!");
                return;
            }
            if (String.IsNullOrEmpty(debtorName))
            {
                MessageBox.Show("El teléfono del deudor es obligatorio!");
                return;
            }
            if (String.IsNullOrEmpty(guarantorName))
            {
                MessageBox.Show("El nombre del garante es obligatorio!");
                return;
            }
            if (String.IsNullOrEmpty(guarantorDocumentId))
            {
                MessageBox.Show("El cédula del garante es obligatorio!");
                return;
            }
            if (String.IsNullOrEmpty(guarantorTelephone))
            {
                MessageBox.Show("El teléfono del garante es obligatorio!");
                return;
            }
            if (String.IsNullOrEmpty(amountText))
            {
                MessageBox.Show("El monto del préstamo es obligatorio!");
                return;
            }
            if (String.IsNullOrEmpty(time))
            {
                MessageBox.Show("El tiempo del préstamo es obligatorio!");
                return;
            }
            if (String.IsNullOrEmpty(closingExpenseText))
            {
                MessageBox.Show("Los gastos de cierre del préstamo es obligatorio!");
                return;
                // convertir al tipo.
            }
            if (String.IsNullOrEmpty(rateText))
            {
                MessageBox.Show("La tasa de cierre del préstamo es obligatorio!");
                return;
                // convertir al tipo.
            }
            try
            {
                amount = Convert.ToDecimal(amountText);
            } catch {
                MessageBox.Show("El formato del monto no es correcto!");
                return;
            }
            try
            {
                amount = Convert.ToDecimal(amountText);
            }
            catch
            {
                MessageBox.Show("El formato del monto no es correcto!");
                return;
            }
            try
            {
                closingExpense = Convert.ToDecimal(closingExpenseText);
            }
            catch
            {
                MessageBox.Show("El formato del gasto de cierre no es correcto!");
                return;
            }
            try
            {
                rate = Convert.ToDecimal(rateText);
            }
            catch
            {
                MessageBox.Show("El formato de la tasa no es correcto!");
                return;
            }
            #endregion

            #region db
            var loan = new db.loan();
            loan.debbtor_name = debtorName;
            loan.debtor_document_id = debtorDocumentId;
            loan.debtor_telephone = debtorTelephone;
            loan.guarantor_name = guarantorName;
            loan.guarantor_document_id = guarantorDocumentId;
            loan.guarantor_telephone = guarantorTelephone;
            loan.amount = amount;
            loan.debt = amount;
            loan.closing_expense = closingExpense;
            loan.time = time;
            loan.rate = rate;
            db.loans.Add(loan);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Préstamo registrado.");

                Home obj = (Home)Application.OpenForms["Home"];
                obj.loaddataPrestamos();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo almacenar en la DB");
                MessageBox.Show(ex.Message);
            }
            #endregion

        }
    }
}
