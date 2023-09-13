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
    public partial class EditTypeOfAdForm : Form
    {
        public EditTypeOfAdForm()
        {
            InitializeComponent();
        }

        private void placeOfAdvertisementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.placeOfAdvertisementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.advertiseKursovayaDataSet);

        }

        private void EditTypeOfAdForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertiseKursovayaDataSet.placeOfAdvertisement". При необходимости она может быть перемещена или удалена.
            this.placeOfAdvertisementTableAdapter.Fill(this.advertiseKursovayaDataSet.placeOfAdvertisement);

        }

        private void saveChangesTypeOfAdButton_Click(object sender, EventArgs e)
        {
            placeOfAdvertisementBindingSource.EndEdit();
            placeOfAdvertisementTableAdapter.Update(advertiseKursovayaDataSet);
            this.Close();
        }

        private void cancelChangesTypeOfAdButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
