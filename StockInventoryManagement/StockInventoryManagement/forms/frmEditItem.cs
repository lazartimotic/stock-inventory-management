using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockInventoryManagement.forms
{
    public partial class frmEditItem : Form
    {
        private long itemID = 0;

        public frmEditItem(long id, string name, string code, string price)
        {
            InitializeComponent();

            itemID = id;
            editName.Text = name;
            editCode.Text = code;
            editPrice.Text = price;
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {

        }

        private void btn_edit_ok_Click(object sender, EventArgs e)
        {
            if (itemID == 0)
            {
                MessageBox.Show(this, "Nije moguce izmeniti artikal, identifikator iz baze nevalidan. Cimnite Lazara", "Identifikator nevalidan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string name = editName.Text.Trim();
            string code = editCode.Text.Trim();
            string ppt_string = editPrice.Text.Trim();
            double ppt = 0;

            if (name.Length == 0)
            {
                MessageBox.Show(this, "Unesite validno ime.", "Ime nevalidno", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                editName.Focus();
                return;
            }

            if (code.Length == 0)
            {
                MessageBox.Show(this, "Unesite validnu sifru.", "Sifra nevalidna", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                editCode.Focus();
                return;
            }

            if (ppt_string.Length == 0)
            {
                MessageBox.Show(this, "Unesite validnu cenu.", "Cena nevalidna", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                editPrice.Focus();
                return;
            }

            double.TryParse(ppt_string, out ppt);

            new System.Threading.Thread(() => {
                try
                {
                    #region MyRegion
                    if (Job.Database.updateItem(itemID, name, code, ppt))
                    {
                        Invoke(new Action(() =>
                        {
                            editName.Text = editCode.Text = editPrice.Text = "";
                            MessageBox.Show(this, "Uspesno modifikovan element.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }));
                    }
                    else
                    {
                        Invoke(new Action(() => {
                            MessageBox.Show(this, "Greska prilikom modifikacije, pokusajte ponovo.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            editName.Focus();
                        }));
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() => { MessageBox.Show(this, "Greska prilikom modifikacije artikla, pokusajte ponovo, ako nece sacuvajte text greske i cimnite Lazara." + Environment.NewLine + "Greska :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }));
                }
                finally
                {
                    Close();
                }
            }).Start();
        }
    }
}
