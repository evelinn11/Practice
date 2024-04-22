using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W08___Practice___Open_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Baca_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\UC\\Semester 2\\Application Development\\Folder TXT"; //set default folder yang akan dibuka
            ofd.Filter = "EXO saranghaja (*.txt)|*.txt|All Files (*.*)|*.*"; //filter jenis file di folder
            ofd.FilterIndex = 2; //set default filter
            ofd.ShowDialog();
            MessageBox.Show(ofd.FileName);

            StreamReader sr = new StreamReader(ofd.FileName); //membaca file
            string line = sr.ReadLine(); //membaca 1 baris di file
            while (line != null)
            {
                MessageBox.Show(line);
                line = sr.ReadLine();
            }
            sr.Close(); //jika sudah tidak dipakai 

            StreamWriter sw = new StreamWriter(ofd.FileName);
            sw.WriteLine("Baekhyun;Seoul;01012322445");
            sw.WriteLine("Juyeon;Seoul;010465432");
            sw.Close();
        }
    }
}
