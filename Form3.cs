using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

namespace e_booking
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = openFile.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
           
        }

        private void Load_Data()
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Load_Data();
        }
    }
}
