using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W05___Practice___Create_Button
{
    public partial class Form1 : Form
    {
        List<Button> listButton = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TextBox input = new TextBox();
            //input.Size = new Size(150, 30);
            //input.Location = new Point(30, 0);
            //input.Text = "5";
            //this.Controls.Add(input);
           
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (listButton != null)
            {
                foreach (Button button in listButton)
                {
                    this.Controls.Remove(button);
                }
            }
            listButton.Clear();
            int countLocation = 30;
            for (int i = 0; i < Convert.ToInt32(tBox_Create.Text); i++)
            {
                Button btn = new Button();
                btn.Text = "button" + (i+1);
                btn.Tag = "button ke " + (i + 1);
                btn.Size = new Size(150, 30);
                btn.Location = new Point(30, countLocation);
                btn.BackColor = Color.Cyan;
                btn.ForeColor = Color.Green;
                btn.Click += new EventHandler(btn_Click);
                listButton.Add(btn);
                this.Controls.Add(btn);
                countLocation += 30;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //button adalah isinya sender yang diubah menjadi sebuah button
            Button button = (Button) sender;
            button.Text = "uwu";
            MessageBox.Show(button.Tag.ToString());
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(listButton[Convert.ToInt32(tBox_Remove.Text) - 1]);
        }
    }
}
