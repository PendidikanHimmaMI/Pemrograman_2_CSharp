using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekBesarPendidikan.Laporan
{
    public partial class LaporanTrs: Form
    {
        private object pTable;

        public LaporanTrs()
        {
            InitializeComponent();
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_RentalPlayStationDataSet3.vw_listTransaksiPenyewaan' table. You can move, or remove it, as needed.
            this.vw_listTransaksiPenyewaanTableAdapter.Fill(this.db_RentalPlayStationDataSet3.vw_listTransaksiPenyewaan);
            // TODO: This line of code loads data into the 'db_RentalPlayStationDataSet2.rps_trpenyewaan' table. You can move, or remove it, as needed.
            this.rps_trpenyewaanTableAdapter.Fill(this.db_RentalPlayStationDataSet2.rps_trpenyewaan);

        }

        private void exportPDF_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName); 
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data in disk"+ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTbale = new PdfPTable(dgvReport.Columns.Count);
                            pTbale.DefaultCell.Padding = 2;
                            pTbale.WidthPercentage = 100;
                            pTbale.HorizontalAlignment = Element.ALIGN_LEFT;
                               
                            foreach (DataGridViewColumn col in dgvReport.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTbale.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgvReport.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTbale.AddCell(dcell.Value.ToString());
                                }
                            }


                            using(FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4,8f,16f,16f, 8f);
                                document.Open();
                                document.Add(pTbale);
                                document.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info"); 
            }
        }
    }
}
