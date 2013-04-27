using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDFLibNet;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PDFWrapper _pdfDoc = new PDFWrapper();
            _pdfDoc.LoadPDF(@"C:\Users\guxiaoshi\Desktop\PDF\浪潮之巅(1-18)完整版.pdf");
            //加上%d,把pdf所有页都生成图片
            _pdfDoc.ExportJpg(@"C:\Users\guxiaoshi\Desktop\PDF\bjcb_001%d.jpg", 90);
        }
    }
}
