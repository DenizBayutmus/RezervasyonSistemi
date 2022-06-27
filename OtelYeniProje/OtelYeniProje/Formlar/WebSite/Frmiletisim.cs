﻿using OtelYeniProje.Entity;
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
    public partial class Frmiletisim : Form
    {
        public Frmiletisim()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        private void Frmiletisim_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblMesaj
                                       select new
                                       {
                                           x.MesajıD,
                                           x.Gonderen,
                                           x.Mail,
                                           x.Konu,
                                           x.Mesaj
                                       }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMesajKarti fr = new FrmMesajKarti();
            fr.id2 = int.Parse(gridView1.GetFocusedRowCellValue("MesajıD").ToString());
            fr.Show();
        }
    }
}
