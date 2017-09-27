using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using Palindromic_prime;
using _3ShapeTestPalindromic_Prime.Properties;

namespace _3ShapeTestPalindromic_Prime
{
    /// <summary>
    /// The only Form in this Project
    /// </summary>
    public partial class PalindromicPrime : Form
    {
        #region constructors
        /// <summary>
        /// Constructor for the Form.
        /// </summary>
        public PalindromicPrime()
        {
            InitializeComponent();
            Icon = Resources.mr_logo;
            // Create sources for Combobox
            Dictionary<int, string> comboSource =
                new Dictionary<int, string> { { 0, string.Empty }, { 2, "Binary" }, { 10, "Decimal" } };
            // Is only added if the app.config allows it
            if (ConfigurationManager.AppSettings["OctalEnabled"].ToLower().Equals("true"))
            {
                comboSource.Add(8, "Octal");
            }
            // Is only added if the app.config allows it
            if (ConfigurationManager.AppSettings["HexaEnabled"].ToLower().Equals("true"))
            {
                comboSource.Add(16, "Hexadecimal");
            }
            cmbNumberSystem.DataSource = new BindingSource(comboSource.OrderBy(x => x.Key), null);
            cmbNumberSystem.DisplayMember = "Value";
            cmbNumberSystem.ValueMember = "Key";
        }

        #endregion

        #region private procedures

        private void cmbNumberSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbResult.Items.Clear();
            if (cmbNumberSystem != null && cmbNumberSystem.SelectedIndex > 0)
            {
                var minvalue = (int)nudMinValue.Value;
                var maxvalue = (int)nudMaxValue.Value;
                foreach (var i in PalinDromicPrime.PalinDromePrime(minvalue, maxvalue, (int)cmbNumberSystem.SelectedValue))
                {
                    lbResult.Items.Add(i);
                }

            }
        }
        #endregion
    }
}
