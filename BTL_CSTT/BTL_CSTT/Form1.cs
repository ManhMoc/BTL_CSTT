using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CSTT
{
    public partial class Form1 : Form
    {
        public static TextBox[] TXT1;
        public static TextBox[] TXT2;
        public static TextBox[] TXTD1;
        public static TextBox[] TXTD2;
        public  Form1()
        {
            InitializeComponent();          
        }
        //
        //
        //PHAN ENCODE
        public void button1_Click(object sender, EventArgs e)
        {
            foreach(var ctr in pel.Controls)// Clear all in panel when change So_Lop_Tin
            {                
                pel.Controls.Clear();
            }
            try
            {
                int n = int.Parse(txtN.Text);


                XacSuat.LT = new char[n];
                XacSuat.XS = new double[n];
                TXT1 = new TextBox[n];
                TXT2 = new TextBox[n];

                Label lbl1 = new Label();
                lbl1.Text = "Nhập các lớp tin";
                lbl1.Width = 100;
                lbl1.Top = 30;
                pel.Controls.Add(lbl1);

                for (int i = 0; i < n; i++)//Nhap cac lop tin
                {
                    TXT1[i] = new TextBox();
                    TXT1[i].Width = 50; TXT1[i].Top = 30;
                    //TXT1[i].Left = TXT1[i].Width+50*(2*i+1);
                    TXT1[i].Left = TXT1[i].Width * i + 150;
                    TXT1[i].Enabled = true;
                    pel.Controls.Add(TXT1[i]);

                }
                Label lbl2 = new Label();
                lbl2.Text = "Nhập các xác suất tương ứng";
                lbl2.Top = 70;
                lbl2.Width = 100;
                pel.Controls.Add(lbl2);
                for (int i = 0; i < n; i++)//Nhap cac xac suat
                {
                    TXT2[i] = new TextBox();
                    TXT2[i].Top = 70;
                    TXT2[i].Width = 50;
                    TXT2[i].Left = TXT2[i].Width * i + 150;
                    TXT2[i].Enabled = true;
                    pel.Controls.Add(TXT2[i]);

                }
                Button btn = new Button();
                pel.Controls.Add(btn);
                btn.Top = 100; btn.Left = 350;
                btn.Text = "OK";
                btn.Click += new EventHandler(buttonclick);
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message+"\n\n Lỗi Nhập");
            }
        }

        private void buttonclick(object sender, EventArgs e)
        {
            double Sum = 0;
            try
            {
                for (int i = 0; i < int.Parse(txtN.Text); i++)
                {
                    XacSuat.LT[i] = char.Parse(TXT1[i].Text);
                    //XacSuat.XS[i] = double.Parse(TXT2[i].Text);
                   // Sum += XacSuat.XS[i];
                }
                for (int i = 0; i < int.Parse(txtN.Text)-1; i++)
                {
                    XacSuat.XS[i] = double.Parse(TXT2[i].Text);
                    Sum += XacSuat.XS[i];
                }
                XacSuat.XS[int.Parse(txtN.Text) - 1] = 1 - Sum;
                TXT2[int.Parse(txtN.Text) - 1].Text = XacSuat.XS[int.Parse(txtN.Text) - 1].ToString();
                /* if (Sum >= 0.99 && Sum <= 1.01)
                 MessageBox.Show("Thành công");
             else MessageBox.Show("Nhập sai Sum!=1");*/
                
            }
            catch(Exception m)
            {
                MessageBox.Show(m.Message + "\n\n Nhập chưa đúng cấu trúc");
            }
          // Sum= Math.Round(Sum,2);
            
        }

        


        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEncode_Click(object sender, EventArgs e)// Qua trinh ma hoa
        {
            try
            {
                string mn = txtNguonTin.Text;//Tinh chieu dai nguon tin
                lblLength1.Text = mn.Length.ToString();//

                int n = int.Parse(txtN.Text);
                string s = txtNguonTin.Text;
                XacSuat.PC = new double[n];
                double last = 0;
                for (int i = 0; i < n; i++)//Tinh Xac Suat Cong Don
                {
                    XacSuat.PC[i] = last + XacSuat.XS[i];
                    last = XacSuat.PC[i];
                }
                double l = 0, u = 1;
                double last_l = l, last_u = u;
                int value = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    for (int j = 0; j < n; j++)
                    {
                        if (c == XacSuat.LT[j]) value = j;
                    }
                    if (value == 0)
                    {
                        l = last_l;
                        u = last_l + (last_u - last_l) * XacSuat.PC[value];
                    }
                    else
                    {
                        l = last_l + (last_u - last_l) * XacSuat.PC[value - 1];
                        u = last_l + (last_u - last_l) * XacSuat.PC[value];
                    }
                    last_l = l;
                    last_u = u;
                }
                double tag = (u + l) / 2;
                txtEncode.Text = tag.ToString();
                double H = 0;//Tinh toan he so Kt,Kn
                for (int i = 0; i < int.Parse(txtN.Text); i++)
                {
                    H += XacSuat.XS[i] * Math.Log(1 / (XacSuat.XS[i]), 2);
                }
                double Kt = 0, Kn=0;                            
                string s1 = txtNguonTin.Text;
                double leng = s1.Length;
                double Hmax = Math.Log(leng, 2);
                double avg_leng = (H + H + 2 / leng)/2;
                Kt = H / avg_leng;
                Kn = Hmax / avg_leng;
                txtKT.Text = Kt.ToString();
                txtKn.Text = Kn.ToString();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message + "\n\n Lỗi Nhập");
            }
        }

        //
        //
        //PHAN DECODE
        private void btnNhap_Click(object sender, EventArgs e)
        {
            foreach (var ctr in pel2.Controls)// Clear all in panel when change So_Lop_Tin
            {
                pel2.Controls.Clear();
            }
            try
            {
                int n = int.Parse(txtN2.Text);

                XS_Decode.LT = new char[n];
                XS_Decode.XS = new double[n];
                TXTD1 = new TextBox[n];
                TXTD2 = new TextBox[n];

                Label lbl1 = new Label();
                lbl1.Text = "Nhập các lớp tin";
                lbl1.Width = 100;
                lbl1.Top = 20;
                pel2.Controls.Add(lbl1);
                for (int i = 0; i < n; i++)//Nhap cac lop tin
                {
                    TXTD1[i] = new TextBox();
                    TXTD1[i].Width = 50; TXTD1[i].Top = 20;
                    TXTD1[i].Left = TXTD1[i].Width * i + 150;
                    TXTD1[i].Enabled = true;
                    pel2.Controls.Add(TXTD1[i]);

                }
                Label lbl2 = new Label();
                lbl2.Text = "Nhập các xác suất tương ứng";
                lbl2.Top = 70;

                pel2.Controls.Add(lbl2);
                for (int i = 0; i < n; i++)//Nhap cac xac suat
                {
                    TXTD2[i] = new TextBox();
                    TXTD2[i].Top = 70;
                    TXTD2[i].Width = 50;
                    TXTD2[i].Left = TXTD2[i].Width * i + 150;
                    TXTD2[i].Enabled = true;
                    pel2.Controls.Add(TXTD2[i]);

                }
                Button btn = new Button();
                pel2.Controls.Add(btn);
                btn.Top = 150; btn.Left = 350;
                btn.Text = "OK";
                btn.Click += new EventHandler(buttonclick2);
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message + "\n\n Lỗi Nhập");
            }
            
        }

        private void buttonclick2(object sender, EventArgs e)
        {
            double Sum = 0;
            try
            {
                for (int i = 0; i < int.Parse(txtN2.Text); i++)
                {
                    XS_Decode.LT[i] = char.Parse(TXTD1[i].Text);
                    XS_Decode.XS[i] = double.Parse(TXTD2[i].Text);
                    Sum += XS_Decode.XS[i];
                }
                if (Sum >= 0.99 && Sum <= 1.01)
                    MessageBox.Show("Thành công");
                else MessageBox.Show("Tổng các xác suất không bằng 1");
            }
            catch(Exception m)
            {
                MessageBox.Show(m.Message+"\n\nNhập chưa đúng cấu trúc");
            }
            
        }

        private void btnDE_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtN2.Text);
                double Tag = double.Parse(txtNhap.Text);
                XS_Decode.PC = new double[n];
                double last = 0;
                for (int i = 0; i < n; i++)//Cong don xac suat
                {
                    XS_Decode.PC[i] = XS_Decode.XS[i] + last;
                    last = XS_Decode.PC[i];
                }
                int leng = int.Parse(txtLeng.Text);
                char[] nguontin = new char[leng];
                double l = 0, u = 1;

                for (int i = 0; i < leng; i++)
                {
                    if (Tag < XS_Decode.PC[0])
                    {
                        l = 0;
                        u = XS_Decode.PC[0];
                        nguontin[i] = XS_Decode.LT[0];
                    }
                    else
                        for (int j = 1; j < n; j++)
                        {
                            if (Tag >= XS_Decode.PC[j - 1] && Tag < XS_Decode.PC[j])
                            {
                                nguontin[i] = XS_Decode.LT[j];
                                l = XS_Decode.PC[j - 1];
                                u = XS_Decode.PC[j];
                            }
                        }
                    Tag = (Tag - l) / (u - l);

                }
                string s = new string(nguontin);
                txtKq.Text = s;
            }catch(Exception E)
            {
                MessageBox.Show(E.Message + "\n\n Lỗi Nhập");
            }
        }
        
        private void txtLeng_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabP2_Click(object sender, EventArgs e)
        {

        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKq_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEncode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLength1_Click(object sender, EventArgs e)
        {

        }

        private void pel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblKT_Click(object sender, EventArgs e)
        {

        }

        private void lblKn_Click(object sender, EventArgs e)
        {

        }
    }
    
}
