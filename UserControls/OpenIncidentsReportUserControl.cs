using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    public partial class OpenIncidentsReportUserControl : UserControl
    {
        public OpenIncidentsReportUserControl()
        {
            InitializeComponent();
            RefreshReport();
        }

        /// <summary>
        /// Refreshes report
        /// </summary>
        public void RefreshReport()
        {
            this.openIncidentsTableAdapter1.Fill(this.techSupportDataSet.OpenIncidents);
            this.reportViewer1.RefreshReport();
        }
    }
}
