using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TRMDesktopUI.Views
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }





        #region Actions
        private void OpenForm<T>(T myForm, bool isDialog = false) where T : Form
        {
            try
            {
                if (!Application.OpenForms.OfType<T>().Any())
                {
                    if (!isDialog) myForm.MdiParent = this;

                    myForm.Show();
                }
                else
                {
                    Application.OpenForms[myForm.Name]?.Focus();
                    //myForm.Focus();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Main OpenForm Error Message!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}