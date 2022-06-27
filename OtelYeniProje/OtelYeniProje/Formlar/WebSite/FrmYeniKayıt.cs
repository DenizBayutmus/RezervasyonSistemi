using OtelYeniProje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYeniProje.Formlar.WebSite
{
    public partial class FrmYeniKayıt : Form
    {
        public FrmYeniKayıt()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        private void FrmYeniKayıt_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblYeniKayit
                                       select new
                                       {
                                           x.AdSoyad,
                                           x.Mail,
                                           x.Telefon
                                       }).ToList();
        }
    }
}
