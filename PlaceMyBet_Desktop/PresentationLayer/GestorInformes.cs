using CrystalDecisions.CrystalReports.Engine;
using PlaceMyBet_Desktop.BusinessLayer;
using PlaceMyBet_Desktop.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaceMyBet_Desktop.PresentationLayer
{
    public partial class GestorInformes : Form
    {
        public GestorInformes()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.RefreshReport();
        }

        private void listadoDeEventosActualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReport3.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.RefreshReport();
        }

        private void listadoDeEventosEntreFechasDeterminadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReport2.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.RefreshReport();
        }

        private void listadoDeApuestasPorEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReport4.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.RefreshReport();
        }

        private void listadoDeApuestasPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReport5.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.RefreshReport();
        }

        private void datosEconómicosPorEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReport6.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.RefreshReport();
        }

        private void datosEconómicosPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReport7.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.RefreshReport();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String reportPath = System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(reportPath + "CrystalReport8.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.RefreshReport();
        }
    }
}
