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

namespace Video_To_Html
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            lbl_durum2.Text = "";
            lbl_video2.Text = "";

            OpenFileDialog files = new OpenFileDialog();
            files.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            files.Filter = "MP4 Dosyası |*.mp4";
            files.RestoreDirectory = true;
            files.Multiselect = true;

            if (files.ShowDialog() == DialogResult.OK)
            {
                string dosyaadi = files.SafeFileName;
                lbl_video2.Text= dosyaadi;
            }
        }

        private void btn_html_olustur_Click(object sender, EventArgs e)
        {
            try
            {

                //string swrite = "<!DOCTYPE html>< html lang = 'tr' >< head >< title > Abdiibrahim </ title ></ head >< body bgcolor = 'black' >< center >< video width = '1024' height = '768' controls loop autoplay muted>< source src = 'MP4VIDEO' type = 'video/mp4' ></ video ></ center ></ body ></ html > ";
                //swrite = swrite.Replace("MP4VIDEO", lbl_video2.Text);


                using (FileStream fs = new FileStream("C:\\Users\\" + Environment.UserName + "\\Desktop\\AbdiibrahimVideo.html", FileMode.Create))
                {
                    Encoding encoding = Encoding.GetEncoding("ISO-8859-9");
                    using (StreamWriter w = new StreamWriter(fs, encoding))
                    {
                        //w.WriteLine(swrite.ToString());
                        w.WriteLine("< !DOCTYPE html >");
                        w.WriteLine("<html lang='tr'>");
                        w.WriteLine("<head>");
                        w.WriteLine("<title>Abdiibrahim</title>");
                        w.WriteLine("</head>");
                        w.WriteLine("<body bgcolor='black'>");
                        w.WriteLine("<center>");
                        w.WriteLine("<video width='1024' height='768' controls loop autoplay muted>");
                        w.WriteLine("<source src='"+ lbl_video2.Text + "' type='video/mp4' >");
                        w.WriteLine("</video>");
                        w.WriteLine("</center>");
                        w.WriteLine("</body>");
                        w.WriteLine("</html>");
                        w.Close();
                    }
                }
                lbl_durum2.Text = "OLUŞTURULDU!";
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
