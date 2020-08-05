using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;



namespace OtomasyonProje.Forms
{
    public partial class ElemanAyar : Form
    {
         public IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "V5wWFhFXNCsu6blhxslTfYwilQ7S2zJjnKYIb1bm",
            BasePath = "https://sirketotomasyon.firebaseio.com/"
        };

         public IFirebaseClient client;
 

        public ElemanAyar()
        {
            InitializeComponent();
        }

        private void ElemanAyar_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private async void ekleButon_ClickAsync(object sender, EventArgs e)
        {
            var data = new Data
            {
                ID = textBoxID.Text,
                adSoyad = textBoxAdSoyad.Text,
                departman = textBoxDepartman.Text,
                aylıkGelir = textBoxGelir.Text,
                telefonNo = textBoxTelefon.Text,
                mailAdres = textBoxMail.Text,
            };

            SetResponse response = await client.SetTaskAsync("Elemanlar/" + textBoxID.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Eleman Eklendi", "Eleman Islemleri");

            textBoxID.Text = "";
            textBoxAdSoyad.Text = "";
            textBoxDepartman.Text = "";
            textBoxGelir.Text = "";
            textBoxTelefon.Text = "";
            textBoxMail.Text = "";

        }

        private async void getirButon_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Elemanlar/" + textBoxIDGetir.Text);
            try
            {
                Data obj = response.ResultAs<Data>();

                textBoxAdSoyadGetir.Text = obj.adSoyad;
                textBoxDepartmanGetir.Text = obj.departman;
                textBoxGelirGetir.Text = obj.aylıkGelir;
                textBoxTelefonGetir.Text = obj.telefonNo;
                textBoxMailGetir.Text = obj.mailAdres;

                MessageBox.Show("Eleman Getirildi", "Eleman Islemleri");
            }
            catch (Exception)
            {
                MessageBox.Show("Bu ID'ye sahip kullanici bulunmamaktadir!", "Eleman Islemleri");
            }
        }

        private async void silButon_Click(object sender, EventArgs e)
        {
           
            FirebaseResponse response = await client.DeleteTaskAsync("Elemanlar/" + textBoxIDGetir.Text);
            MessageBox.Show(textBoxIDGetir.Text + " ID numarasına sahip eleman silinmistir.","Eleman Silme İslemi");

            textBoxIDGetir.Text = "";
            textBoxAdSoyadGetir.Text = "";
            textBoxDepartmanGetir.Text = "";
            textBoxGelirGetir.Text = "";
            textBoxTelefonGetir.Text ="";
            textBoxMailGetir.Text = "";
        
        }
    }
}
