using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovayaBD
{
    public partial class EditServiceForm : Form
    {
        public EditServiceForm()
        {
            InitializeComponent();
        }

        private void adServicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adServicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.advertiseKursovayaDataSet);

        }

        private void EditServiceForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertiseKursovayaDataSet.adServices". При необходимости она может быть перемещена или удалена.
            this.adServicesTableAdapter.Fill(this.advertiseKursovayaDataSet.adServices);

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            adServicesBindingSource.EndEdit();
            adServicesTableAdapter.Update(advertiseKursovayaDataSet);
            this.Close();
        }

        private void cancelChangesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
