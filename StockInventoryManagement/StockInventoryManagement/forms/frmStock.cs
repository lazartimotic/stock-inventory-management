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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            refreshReport();
        }

        public void init()
        {
            loadItems();
        }

        public void loadItems()
        {
            try
            {
                new System.Threading.Thread(() =>
                {

                    #region Thread
                    try
                    {
                        while (!Enabled) { System.Threading.Thread.Sleep(1000); }

                        Invoke(new Action(() =>
                        {
                            Enabled = false;
                        }));

                        Invoke(new Action(() =>
                        {
                            stockSelectedItemCb.Items.Clear();
                        }));

                        List<classes.Item> items = Job.Database.getAllItems();

                        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                        foreach (classes.Item item in items)
                        {
                            auto.Add(item.itemName);
                            if (item.itemCode != null && item.itemCode.Trim().Length > 0)
                            {
                                auto.Add(item.itemCode);
                            }
                            Invoke(new Action(() =>
                            {
                                stockSelectedItemCb.Items.Add(item);
                            }));
                        }
                        Invoke(new Action(() =>
                        {
                            stockSelectedItemCb.AutoCompleteCustomSource = auto;
                        }));
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() =>
                        {
                            MessageBox.Show(this, "Please try again, unable to load stock items into auto-complete." + Environment.NewLine + "Error message : " + ex.Message, "Auto-complete Error #1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                    }
                    finally
                    {
                        Invoke(new Action(() =>
                        {
                            Enabled = true;
                        }));
                    }
                    #endregion
                }).Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Sorry, unable to load items into auto-complete list, please try again." + Environment.NewLine + "Error message : " + ex.Message, "Auto-complete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void refreshReport()
        {
            new System.Threading.Thread(() =>
            {

                try
                {
                    while (!Enabled) { System.Threading.Thread.Sleep(1000); }
                    Invoke(new Action(() =>
                    {
                        Enabled = false;
                        lvStock.ClearObjects();
                    }));

                    List<classes.Item> items = Job.Database.getStockReport();

                    Invoke(new Action(() =>
                    {
                        lvStock.SetObjects(items);
                    }));

                }
                catch (Exception ex)
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show(this, "Sorry, unable to refresh stock report, please try again." + Environment.NewLine + "Error message : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
                finally
                {
                    Invoke(new Action(() =>
                    {
                        Enabled = true;
                    }));
                }

            }).Start();
        }

        private void lvStock_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            
        }

        private void lvStock_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvStock.SelectedIndex > -1 && lvStock.SelectedObject != null)
            {
                try
                {
                    new frmStockReport((lvStock.SelectedObject as classes.Item).id, (lvStock.SelectedObject as classes.Item).itemName).ShowDialog(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "System error : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void stockSelectedItemCb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (stockSelectedItemCb.SelectedIndex > -1)
            {
                stockPrice.Text = ((classes.Item)stockSelectedItemCb.SelectedItem).itemPPU.ToString();
                stockCode.Text = ((classes.Item)stockSelectedItemCb.SelectedItem).itemCode.ToString();

                double purchased = 0;
                double saled = 0;
                if (Job.Database.getItemReport(((classes.Item)stockSelectedItemCb.SelectedItem).id, ref purchased, ref saled))
                {
                    double stockStatus = purchased - saled;
                    stockNumberOfPieces.Text = stockStatus.ToString();
                }
            }
        }
    }
}
