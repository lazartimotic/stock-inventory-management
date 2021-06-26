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
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }
        
        public void initMethod()
        {
            Enabled = false;
            new System.Threading.Thread(() => {
                try
                {
                    #region MyRegion
                    List<classes.Item> items = Job.Database.getAllItems();
                    Invoke(new Action(() => {
                        lvItems.SetObjects(items);
                    }));
                    #endregion
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() => {
                        MessageBox.Show(this, "Error occured while initializing items page, please try again." + Environment.NewLine + "Error message :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
                finally {
                    Invoke(new Action(() => {
                        Enabled = true;
                    }));
                }
            }).Start();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {

        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            new forms.frmNewItem().ShowDialog(this);
            initMethod();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "Odaberite makar jedan artikal za brisanje.", "Ni jedan artikal nije selektovan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(this, "Da li ste sigurni da zelite da obrisete artikal/artikle ?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Collections.IList list = lvItems.SelectedObjects;
                Enabled = false;
                new System.Threading.Thread(()=>{
                    try
                    {
                        #region MyRegion
                        foreach (classes.Item item in list)
                        {
                            item.delete();
                        }
                        Invoke(new Action(() => { MessageBox.Show(this, "Artikal uspesno obrisan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information); initMethod(); }));
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() => { MessageBox.Show(this, "Dogodila se greska prilikom brisanja, pokusajte ponovo." + Environment.NewLine + "Greska :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }));
                    }
                    finally
                    {
                        Invoke(new Action(() => { Enabled = true; }));
                    }
                }).Start();

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) 
        {
            initMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count != 1)
            {
                MessageBox.Show(this, "Odaberite tacno jedan artikal za modifikaciju.", "Neadekvatan artikal selektovan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            System.Collections.IList list = lvItems.SelectedObjects;
            classes.Item itemToEdit = null;

            // it should be only one in the list, do not have time now to extract it in a better way
            foreach (classes.Item item in list)
            {
                itemToEdit = item;
            }

            if (itemToEdit == null)
            {
                MessageBox.Show(this, "Artikal za izmenu nije pronadjen.", "Artikal nije pronadjen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new forms.frmEditItem(itemToEdit.id, itemToEdit.itemName.ToString(), itemToEdit.itemCode.ToString(), itemToEdit.itemPPU.ToString()).ShowDialog(this);
            initMethod();
        }
    }
}
