using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public static int AssignCount = 0;

        public static bool fieldIsEmpty = false;
        public static bool fieldIsMoreThan100 = false;
        public static bool addUpTo100 = true;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string uccVersion = "v1.2";
            this.Text = "Unit Contribution Calculator " + uccVersion;
            this.Size = new Size(700, 400);
            this.pnlUnits.Location = new Point(700, 0);
            this.lblAddedCalc.Location = new Point(549, 253);
            this.lblAddedManual.Location = new Point(549, 145);

            ttMark.SetToolTip(lblMark, "The mark you have scored for this assignment out of 100");
            ttCont.SetToolTip(lblCont, "The contribution this assignment has toward your unit out of 100");
            ttManual.SetToolTip(lblManual, "Manually add a unit to your list of units");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtAssignCount.Text == "")
            {
                lblHint.Text = "You must enter the amount of assignments you have for your unit";
                lblHint.ForeColor = Color.Red;
                tmrHint.Stop();
                tmrHint.Start();
            }
            else if (txtAssignCount.Text == "0")
            {
                lblHint.Text = "Amount of assignments must be more than zero";
                lblHint.ForeColor = Color.Red;
                tmrHint.Stop();
                tmrHint.Start();
            }
            else
            #region "txtbox checks"
            {
                this.txtCont2.Visible = true;
                this.txtCont3.Visible = true;
                this.txtCont4.Visible = true;
                this.txtCont5.Visible = true;
                this.txtCont6.Visible = true;
                this.txtCont7.Visible = true;
                this.txtCont8.Visible = true;

                this.txtCont2Under.Visible = true;
                this.txtCont3Under.Visible = true;
                this.txtCont4Under.Visible = true;
                this.txtCont5Under.Visible = true;
                this.txtCont6Under.Visible = true;
                this.txtCont7Under.Visible = true;
                this.txtCont8Under.Visible = true;

                this.txtMark2.Visible = true;
                this.txtMark3.Visible = true;
                this.txtMark4.Visible = true;
                this.txtMark5.Visible = true;
                this.txtMark6.Visible = true;
                this.txtMark7.Visible = true;
                this.txtMark8.Visible = true;

                this.txtMark2Under.Visible = true;
                this.txtMark3Under.Visible = true;
                this.txtMark4Under.Visible = true;
                this.txtMark5Under.Visible = true;
                this.txtMark6Under.Visible = true;
                this.txtMark7Under.Visible = true;
                this.txtMark8Under.Visible = true;

                this.lblPercL2.Visible = true;
                this.lblPercL3.Visible = true;
                this.lblPercL4.Visible = true;
                this.lblPercL5.Visible = true;
                this.lblPercL6.Visible = true;
                this.lblPercL7.Visible = true;
                this.lblPercL8.Visible = true;

                this.lblPercR2.Visible = true;
                this.lblPercR3.Visible = true;
                this.lblPercR4.Visible = true;
                this.lblPercR5.Visible = true;
                this.lblPercR6.Visible = true;
                this.lblPercR7.Visible = true;
                this.lblPercR8.Visible = true;

                if (Convert.ToInt16(txtAssignCount.Text) == 1)
                {
                    AssignCount = 1;
                    
                    this.txtCont2.Visible = false;
                    this.txtCont3.Visible = false;
                    this.txtCont4.Visible = false;
                    this.txtCont5.Visible = false;
                    this.txtCont6.Visible = false;
                    this.txtCont7.Visible = false;
                    this.txtCont8.Visible = false;

                    this.txtCont2Under.Visible = false;
                    this.txtCont3Under.Visible = false;
                    this.txtCont4Under.Visible = false;
                    this.txtCont5Under.Visible = false;
                    this.txtCont6Under.Visible = false;
                    this.txtCont7Under.Visible = false;
                    this.txtCont8Under.Visible = false;

                    this.txtMark2.Visible = false;
                    this.txtMark3.Visible = false;
                    this.txtMark4.Visible = false;
                    this.txtMark5.Visible = false;
                    this.txtMark6.Visible = false;
                    this.txtMark7.Visible = false;
                    this.txtMark8.Visible = false;

                    this.txtMark2Under.Visible = false;
                    this.txtMark3Under.Visible = false;
                    this.txtMark4Under.Visible = false;
                    this.txtMark5Under.Visible = false;
                    this.txtMark6Under.Visible = false;
                    this.txtMark7Under.Visible = false;
                    this.txtMark8Under.Visible = false;

                    this.lblPercL2.Visible = false;
                    this.lblPercL3.Visible = false;
                    this.lblPercL4.Visible = false;
                    this.lblPercL5.Visible = false;
                    this.lblPercL6.Visible = false;
                    this.lblPercL7.Visible = false;
                    this.lblPercL8.Visible = false;
                    
                    this.lblPercR2.Visible = false;
                    this.lblPercR3.Visible = false;
                    this.lblPercR4.Visible = false;
                    this.lblPercR5.Visible = false;
                    this.lblPercR6.Visible = false;
                    this.lblPercR7.Visible = false;
                    this.lblPercR8.Visible = false;
                }
                else if (Convert.ToInt16(txtAssignCount.Text) == 2)
                {
                    AssignCount = 2;
                    
                    this.txtCont3.Visible = false;
                    this.txtCont4.Visible = false;
                    this.txtCont5.Visible = false;
                    this.txtCont6.Visible = false;
                    this.txtCont7.Visible = false;
                    this.txtCont8.Visible = false;

                    this.txtCont3Under.Visible = false;
                    this.txtCont4Under.Visible = false;
                    this.txtCont5Under.Visible = false;
                    this.txtCont6Under.Visible = false;
                    this.txtCont7Under.Visible = false;
                    this.txtCont8Under.Visible = false;

                    this.txtMark3.Visible = false;
                    this.txtMark4.Visible = false;
                    this.txtMark5.Visible = false;
                    this.txtMark6.Visible = false;
                    this.txtMark7.Visible = false;
                    this.txtMark8.Visible = false;

                    this.txtMark3Under.Visible = false;
                    this.txtMark4Under.Visible = false;
                    this.txtMark5Under.Visible = false;
                    this.txtMark6Under.Visible = false;
                    this.txtMark7Under.Visible = false;
                    this.txtMark8Under.Visible = false;

                    this.lblPercL3.Visible = false;
                    this.lblPercL4.Visible = false;
                    this.lblPercL5.Visible = false;
                    this.lblPercL6.Visible = false;
                    this.lblPercL7.Visible = false;
                    this.lblPercL8.Visible = false;
                    
                    this.lblPercR3.Visible = false;
                    this.lblPercR4.Visible = false;
                    this.lblPercR5.Visible = false;
                    this.lblPercR6.Visible = false;
                    this.lblPercR7.Visible = false;
                    this.lblPercR8.Visible = false;
                }
                else if (Convert.ToInt16(txtAssignCount.Text) == 3)
                {
                    AssignCount = 3;

                    this.txtCont4.Visible = false;
                    this.txtCont5.Visible = false;
                    this.txtCont6.Visible = false;
                    this.txtCont7.Visible = false;
                    this.txtCont8.Visible = false;

                    this.txtCont4Under.Visible = false;
                    this.txtCont5Under.Visible = false;
                    this.txtCont6Under.Visible = false;
                    this.txtCont7Under.Visible = false;
                    this.txtCont8Under.Visible = false;

                    this.txtMark4.Visible = false;
                    this.txtMark5.Visible = false;
                    this.txtMark6.Visible = false;
                    this.txtMark7.Visible = false;
                    this.txtMark8.Visible = false;

                    this.txtMark4Under.Visible = false;
                    this.txtMark5Under.Visible = false;
                    this.txtMark6Under.Visible = false;
                    this.txtMark7Under.Visible = false;
                    this.txtMark8Under.Visible = false;

                    this.lblPercL4.Visible = false;
                    this.lblPercL5.Visible = false;
                    this.lblPercL6.Visible = false;
                    this.lblPercL7.Visible = false;
                    this.lblPercL8.Visible = false;
                    
                    this.lblPercR4.Visible = false;
                    this.lblPercR5.Visible = false;
                    this.lblPercR6.Visible = false;
                    this.lblPercR7.Visible = false;
                    this.lblPercR8.Visible = false;
                }
                else if (Convert.ToInt16(txtAssignCount.Text) == 4)
                {
                    AssignCount = 4;

                    this.txtCont5.Visible = false;
                    this.txtCont6.Visible = false;
                    this.txtCont7.Visible = false;
                    this.txtCont8.Visible = false;

                    this.txtCont5Under.Visible = false;
                    this.txtCont6Under.Visible = false;
                    this.txtCont7Under.Visible = false;
                    this.txtCont8Under.Visible = false;

                    this.txtMark5.Visible = false;
                    this.txtMark6.Visible = false;
                    this.txtMark7.Visible = false;
                    this.txtMark8.Visible = false;

                    this.txtMark5Under.Visible = false;
                    this.txtMark6Under.Visible = false;
                    this.txtMark7Under.Visible = false;
                    this.txtMark8Under.Visible = false;

                    this.lblPercL5.Visible = false;
                    this.lblPercL6.Visible = false;
                    this.lblPercL7.Visible = false;
                    this.lblPercL8.Visible = false;
                    
                    this.lblPercR5.Visible = false;
                    this.lblPercR6.Visible = false;
                    this.lblPercR7.Visible = false;
                    this.lblPercR8.Visible = false;
                }
                else if (Convert.ToInt16(txtAssignCount.Text) == 5)
                {
                    AssignCount = 5;

                    this.txtCont6.Visible = false;
                    this.txtCont7.Visible = false;
                    this.txtCont8.Visible = false;

                    this.txtCont6Under.Visible = false;
                    this.txtCont7Under.Visible = false;
                    this.txtCont8Under.Visible = false;

                    this.txtMark6.Visible = false;
                    this.txtMark7.Visible = false;
                    this.txtMark8.Visible = false;

                    this.txtMark6Under.Visible = false;
                    this.txtMark7Under.Visible = false;
                    this.txtMark8Under.Visible = false;

                    this.lblPercL6.Visible = false;
                    this.lblPercL7.Visible = false;
                    this.lblPercL8.Visible = false;
                    
                    this.lblPercR6.Visible = false;
                    this.lblPercR7.Visible = false;
                    this.lblPercR8.Visible = false;
                }
                else if (Convert.ToInt16(txtAssignCount.Text) == 6)
                {
                    AssignCount = 6;

                    this.txtCont7.Visible = false;
                    this.txtCont8.Visible = false;

                    this.txtCont7Under.Visible = false;
                    this.txtCont8Under.Visible = false;

                    this.txtMark7.Visible = false;
                    this.txtMark8.Visible = false;

                    this.txtMark7Under.Visible = false;
                    this.txtMark8Under.Visible = false;

                    this.lblPercL7.Visible = false;
                    this.lblPercL8.Visible = false;
                    
                    this.lblPercR7.Visible = false;
                    this.lblPercR8.Visible = false;
                }
                else if (Convert.ToInt16(txtAssignCount.Text) == 7)
                {
                    AssignCount = 7;

                    this.txtCont8.Visible = false;

                    this.txtCont8Under.Visible = false;

                    this.txtMark8.Visible = false;

                    this.txtMark8Under.Visible = false;

                    this.lblPercL8.Visible = false;
                    
                    this.lblPercR8.Visible = false;
                }
                #endregion
                tmrPanel.Enabled = true;
            }
        }

        private void tmrPanel_Tick(object sender, EventArgs e)
        {
            if (this.pnlUCC.Location.X > 0)
            {
                this.pnlUCC.Location = new Point(this.pnlUCC.Location.X - 20, this.pnlUCC.Location.Y);
            }
            else
            {
                this.tmrPanel.Enabled = false;
            }
        }

        private void txtAssignCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tmrHint_Tick(object sender, EventArgs e)
        {
            lblHint.ForeColor = Color.White;
            lblError.Hide();
            lblAddedCalc.Visible = false;
            lblAddedManual.Visible = false;
            lblHint.Text = "Check your universitys unit guide";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tmrPanelBack.Enabled = true;
            tmrLstBack.Enabled = true;

            //foreach (Control c in this.pnlUCCFields.Controls)
            //{
            //    if (c is TextBox)
            //    {
            //        ((TextBox)c).Text = String.Empty;
            //    }
            //}
        }

        private void tmrPanelBack_Tick(object sender, EventArgs e)
        {
            if (this.pnlUCC.Location.X < this.Width)
            {
                this.pnlUCC.Location = new Point(this.pnlUCC.Location.X + 20, this.pnlUCC.Location.Y);
            }
            else
            {
                this.tmrPanelBack.Enabled = false;
            }
        }

        private void txtMark1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCont1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //lblEmptyField.Show();
            //lblTotal.Text = "Total: 0";
            //tmrHint.Stop();
            //tmrHint.Start();

            double totalMark = 0;
            double totalContribution = 0;

            foreach (Control c in this.pnlUCCFields.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Text == String.Empty && ((TextBox)c).Visible)
                    {
                        fieldIsEmpty = true;
                    }
                }
            }

            foreach (Control c in this.pnlUCCFields.Controls)
            {
                if (c is TextBox)
                {
                    if ((((TextBox)c).Text) != "")
                    {
                        try
                        {
                            if (Convert.ToInt16(((TextBox)c).Text) > 100 && ((TextBox)c).Visible)
                            {
                                fieldIsMoreThan100 = true;
                            }
                        }
                        catch { }
                    }
                }
            }

            foreach (Control c in this.pnlUCCFields.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Visible && !string.IsNullOrEmpty(((TextBox)c).Text) && ((TextBox)c).Tag.ToString() == "Cont")
                    {
                        totalContribution += Convert.ToDouble(((TextBox)c).Text);
                    }
                }
            }

            if (totalContribution == 100)
            {
                addUpTo100 = false;
            }

            if (fieldIsEmpty == true)
            {
                lblError.Text = "Please fill out all fields";
                lblError.Show();
                tmrHint.Stop();
                tmrHint.Start();
            }
            else if (fieldIsMoreThan100 == true)
            {
                lblError.Text = "Please ensure all fields are less than or euqal to 100%";
                lblError.Show();
                tmrHint.Stop();
                tmrHint.Start();
            }
            else if (addUpTo100 == true)
            {
                lblError.Text = "Please ensure your unit contribution adds up to 100%";
                lblError.Show();
                tmrHint.Stop();
                tmrHint.Start();
            }
            else
            {
                if (txtCont1.Visible)
                {
                    totalMark += Convert.ToDouble(txtMark1.Text) * Convert.ToDouble(txtCont1.Text) / 100;
                }
                if (txtCont2.Visible)
                {
                    totalMark += Convert.ToDouble(txtMark2.Text) * Convert.ToDouble(txtCont2.Text) / 100;
                }
                if (txtCont3.Visible)
                {
                    totalMark += Convert.ToDouble(txtMark3.Text) * Convert.ToDouble(txtCont3.Text) / 100;
                }
                if (txtCont4.Visible)
                {
                    totalMark += Convert.ToDouble(txtMark4.Text) * Convert.ToDouble(txtCont4.Text) / 100;
                }
                if (txtCont5.Visible)
                {
                    totalMark += Convert.ToDouble(txtMark5.Text) * Convert.ToDouble(txtCont5.Text) / 100;
                }
                if (txtCont6.Visible)
                {
                    totalMark += Convert.ToDouble(txtMark6.Text) * Convert.ToDouble(txtCont6.Text) / 100;
                }
                if (txtCont7.Visible)
                {
                    totalMark += Convert.ToDouble(txtMark7.Text) * Convert.ToDouble(txtCont7.Text) / 100;
                }
                if (txtCont8.Visible)
                {
                    totalMark += Convert.ToDouble(txtMark8.Text) * Convert.ToDouble(txtCont8.Text) / 100;
                }

                if (totalMark >= 85)
                {
                    lblTotal.Text = "Total: " + totalMark + " (HD)";
                }
                else if (totalMark >= 75)
                {
                    lblTotal.Text = "Total: " + totalMark + " (D)";
                }
                else if (totalMark >= 65)
                {
                    lblTotal.Text = "Total: " + totalMark + " (CR)";
                }
                else if (totalMark >= 50)
                {
                    lblTotal.Text = "Total: " + totalMark + " (P)";
                }
                else if (totalMark < 50)
                {
                    lblTotal.Text = "Total: " + totalMark + " (F)";
                }
            }
        }

        #region "All textbox under highlights"
        private void txtAssignCount_Enter(object sender, EventArgs e)
        {
            txtAssignUnder.BackColor = Color.Cyan;
        }

        private void txtAssignCount_Leave(object sender, EventArgs e)
        {
            txtAssignUnder.BackColor = Color.RoyalBlue;
        }

        private void txtMark1_Enter(object sender, EventArgs e)
        {
            txtMark1Under.BackColor = Color.Cyan;
        }

        private void txtMark1_Leave(object sender, EventArgs e)
        {
            txtMark1Under.BackColor = Color.RoyalBlue;
        }

        private void txtMark2_Enter(object sender, EventArgs e)
        {
            txtMark2Under.BackColor = Color.Cyan;
        }

        private void txtMark2_Leave(object sender, EventArgs e)
        {
            txtMark2Under.BackColor = Color.RoyalBlue;
        }

        private void txtMark3_Enter(object sender, EventArgs e)
        {
            txtMark3Under.BackColor = Color.Cyan;
        }

        private void txtMark3_Leave(object sender, EventArgs e)
        {
            txtMark3Under.BackColor = Color.RoyalBlue;
        }

        private void txtMark4_Enter(object sender, EventArgs e)
        {
            txtMark4Under.BackColor = Color.Cyan;
        }

        private void txtMark4_Leave(object sender, EventArgs e)
        {
            txtMark4Under.BackColor = Color.RoyalBlue;
        }

        private void txtMark5_Enter(object sender, EventArgs e)
        {
            txtMark5Under.BackColor = Color.Cyan;
        }

        private void txtMark5_Leave(object sender, EventArgs e)
        {
            txtMark5Under.BackColor = Color.RoyalBlue;
        }

        private void txtMark6_Enter(object sender, EventArgs e)
        {
            txtMark6Under.BackColor = Color.Cyan;
        }

        private void txtMark6_Leave(object sender, EventArgs e)
        {
            txtMark6Under.BackColor = Color.RoyalBlue;
        }

        private void txtMark7_Enter(object sender, EventArgs e)
        {
            txtMark7Under.BackColor = Color.Cyan;
        }

        private void txtMark7_Leave(object sender, EventArgs e)
        {
            txtMark7Under.BackColor = Color.RoyalBlue;
        }

        private void txtMark8_Enter(object sender, EventArgs e)
        {
            txtMark8Under.BackColor = Color.Cyan;
        }

        private void txtMark8_Leave(object sender, EventArgs e)
        {
            txtMark8Under.BackColor = Color.RoyalBlue;
        }



        private void txtCont1_Enter(object sender, EventArgs e)
        {
            txtCont1Under.BackColor = Color.Cyan;
        }

        private void txtCont1_Leave(object sender, EventArgs e)
        {
            txtCont1Under.BackColor = Color.RoyalBlue;
        }

        private void txtCont2_Enter(object sender, EventArgs e)
        {
            txtCont2Under.BackColor = Color.Cyan;
        }

        private void txtCont2_Leave(object sender, EventArgs e)
        {
            txtCont2Under.BackColor = Color.RoyalBlue;
        }

        private void txtCont3_Enter(object sender, EventArgs e)
        {
            txtCont3Under.BackColor = Color.Cyan;
        }

        private void txtCont3_Leave(object sender, EventArgs e)
        {
            txtCont3Under.BackColor = Color.RoyalBlue;
        }

        private void txtCont4_Enter(object sender, EventArgs e)
        {
            txtCont4Under.BackColor = Color.Cyan;
        }

        private void txtCont4_Leave(object sender, EventArgs e)
        {
            txtCont4Under.BackColor = Color.RoyalBlue;
        }

        private void txtCont5_Enter(object sender, EventArgs e)
        {
            txtCont5Under.BackColor = Color.Cyan;
        }

        private void txtCont5_Leave(object sender, EventArgs e)
        {
            txtCont5Under.BackColor = Color.RoyalBlue;
        }

        private void txtCont6_Enter(object sender, EventArgs e)
        {
            txtCont6Under.BackColor = Color.Cyan;
        }

        private void txtCont6_Leave(object sender, EventArgs e)
        {
            txtCont6Under.BackColor = Color.RoyalBlue;
        }

        private void txtCont7_Enter(object sender, EventArgs e)
        {
            txtCont7Under.BackColor = Color.Cyan;
        }

        private void txtCont7_Leave(object sender, EventArgs e)
        {
            txtCont7Under.BackColor = Color.RoyalBlue;
        }

        private void txtCont8_Enter(object sender, EventArgs e)
        {
            txtCont8Under.BackColor = Color.Cyan;
        }

        private void txtCont8_Leave(object sender, EventArgs e)
        {
            txtCont8Under.BackColor = Color.RoyalBlue;
        }
        #endregion

        private void btnShowUnits_Click(object sender, EventArgs e)
        {
            double unitsTotal = 0;
            pnlUnits.BringToFront();
            tmrLst.Enabled = true;

            foreach (ListViewItem item in lstUnits.Items)
            {
                string temp = item.Text.Substring(0, item.Text.Length - 4);
                unitsTotal += double.Parse(temp, CultureInfo.InvariantCulture);
            }

            lblUnitsTotal.Text = "Total: " + Math.Round(unitsTotal / lstUnits.Items.Count, 2).ToString();

            double GPATotal = 0;

            foreach (ListViewItem item in lstUnits.Items)
            {
                if (item.Text.Contains("(HD)"))
                {
                    GPATotal += 4;
                }
                else if (item.Text.Contains("(D)"))
                {
                    GPATotal += 3;
                }
                else if (item.Text.Contains("(CR)"))
                {
                    GPATotal += 2;
                }
                else if (item.Text.Contains("(P)"))
                {
                    GPATotal += 1;
                }
            }

            lblGPA.Text = "GPA: " + Math.Round(GPATotal / lstUnits.Items.Count, 2).ToString();
        }

        private void tmrLst_Tick(object sender, EventArgs e)
        {
            if (this.pnlUnits.Location.X > pnlUCCFields.Right)
            {
                this.pnlUnits.Location = new Point(this.pnlUnits.Location.X - 10, this.pnlUnits.Location.Y);
            }
            else
            {
                this.tmrLst.Enabled = false;
                lblAddedCalc.Visible = false;
                lblAddedManual.Visible = false;
            }
        }

        private void tmrLstBack_Tick(object sender, EventArgs e)
        {
            if (this.pnlUnits.Location.X < this.Width)
            {
                this.pnlUnits.Location = new Point(this.pnlUnits.Location.X + 10, this.pnlUnits.Location.Y);
            }
            else
            {
                this.tmrLstBack.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tmrLstBack.Enabled = true;
        }

        private void btnAddCalc_Click(object sender, EventArgs e)
        {
            if (!addUpTo100 && !fieldIsEmpty && !fieldIsMoreThan100)
            {
                lstUnits.Items.Add(lblTotal.Text.Substring(7));

                tmrHint.Stop();
                tmrHint.Start();
                lblAddedCalc.Visible = true;
            }
        }

        private void btnAddManual_Click(object sender, EventArgs e)
        {
            tmrHint.Stop();
            tmrHint.Start();
            lblAddedManual.Visible = true;
        }

        private void txtManual_Leave(object sender, EventArgs e)
        {
            txtUnderManual.BackColor = Color.RoyalBlue;
        }

        private void txtManual_Enter(object sender, EventArgs e)
        {
            txtUnderManual.BackColor = Color.Cyan;
        }
    }
}
