using Microsoft.EntityFrameworkCore;

namespace OkulBirOkul
{
    public partial class Form1 : Form
    {
        OkulDataContext context = new();
        public Form1()
        {
            InitializeComponent();


            if (context.Database.GetPendingMigrations().Count() > 0)
                context.Database.Migrate();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bttnGetir_Click(object sender, EventArgs e)
        {


            var Liste = context.Siniflar.ToList();

            listBox1.DataSource = Liste;
            listBox1.DisplayMember = "Ad";
            listBox1.ValueMember = "id";
        }

        private void bttnEkle_Click(object sender, EventArgs e)
        {
            //veritaban� eklemek i�in

            DbS�n�f yeni = new();
            yeni.Ad = txtekleme.Text;
            context.Siniflar.Add(yeni);
            //kaydet
            context.SaveChanges();
            bttnGetir_Click(sender, e);
        }

        private void bttnGuncelle_Click(object sender, EventArgs e)
        {
            DbS�n�f secili = listBox1.SelectedItem as DbS�n�f;

            secili.Ad = txtekleme.Text;

            context.SaveChanges();

            bttnGetir_Click(sender, e);
        }

        private void bttnc�kar_Click(object sender, EventArgs e)
        {
            DbS�n�f secili = listBox1.SelectedItem as DbS�n�f;

            context.Siniflar.Remove(secili);

            context.SaveChanges();

            bttnGetir_Click(sender, e);
        }
    }
}
