using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManager
{
    public partial class FormCinema : Form
    {
        public FormCinema()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitSeat(3, 5);
        }
        private void InitSeat(int row, int col)
        {
            int x, y = 3, count = 1, distance = 90;
            for(int i = 0; i < row; i++)
            {
                x = 40;
                for (int j = 0; j < col; j++)
                {
                    Button btnSeat = new Button();
                    btnSeat.Location = new System.Drawing.Point(x, y);
                    btnSeat.Size = new System.Drawing.Size(76, 67);
                    btnSeat.Text = count++.ToString();
                    btnSeat.BackColor = Color.White;
                    pnSeat.Controls.Add(btnSeat);
                    btnSeat.Click += BtnSeat_Click;
                    x += distance;
                }
                y += distance;
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Button btnSeat = (Button)sender;
            //if (btnSeat.BackColor == Color.White)
            //{
            //    btnSeat.BackColor = Color.Blue;
            //}
            //if (btnSeat.BackColor == Color.Blue)
            //{
            //    btnSeat.BackColor = Color.White;
            //}
            if (btnSeat.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã được chọn, vui lòng chọn ghế khác (￣o￣) . z Z");
                return;
            }
            btnSeat.BackColor = btnSeat.BackColor == Color.White ? Color.Blue : Color.White;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            float total = 0;
            foreach(Button btnSeat in pnSeat.Controls)
            {
                if (btnSeat.BackColor == Color.Blue)
                {
                    btnSeat.BackColor = Color.Yellow;
                    total += BillCheck(btnSeat.Text);
                }
            }
            txtTotal.Text = total.ToString();
        }
        private float BillCheck(string Text)
        {
            float price = 0;
            int numberSeat = Int32.Parse(Text);
            //if (numberSeat <= 5)
            //{
            //    return 30000;
            //}
            //if (numberSeat <= 10)
            //{
            //    return 50000;
            //}
            //else
            //{
            //    return 60000;
            //}
            price = numberSeat <= 5 ? 30000 : numberSeat <= 10 ? 50000 : 60000;
            return price;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach(Button btnSeat in pnSeat.Controls)
            {
                if (btnSeat.BackColor == Color.Blue)
                {
                    btnSeat.BackColor = Color.White;
                    txtTotal.Text = 0.ToString();
                }
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ảe you sủe?", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Close();
            }
            else
            {
                return;
            }
        }
    }
}
