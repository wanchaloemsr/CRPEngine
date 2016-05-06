using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRPEngine
{
    public partial class CRPEngine : Form
    {
        public CRPEngine()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            FetchingData myFetchingData = new FetchingData();
            myFetchingData.downloadData();
            download_msg.Text = "Successfully Downloaded!!";
            
        }

        private void delete_file_Click(object sender, EventArgs e)
        {

            FileAccess myFileAccess = new FileAccess();
            string deleteMessage;

            deleteMessage =  myFileAccess.deleteFile();

            download_msg.Text = deleteMessage;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelReader er = new ExcelReader();
            er.readingExcel();
        }
    }
}
