using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;


using itextsharp;

namespace PDFTextWriter
{
    public partial class PDFHeatTextWriter : Form
    {
        public string originalFullFile = "";
        public string originalFileSafeName = "";
        public string newFolder = "";


        public PDFHeatTextWriter()
        {
            InitializeComponent();
        }

        private void PDFHeatTextWriter_Load(object sender, EventArgs e)
        {
            PDFHeatTextWriter.ActiveForm.Text = "PDF Heat Text Writer v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void WriteHeat_Click(object sender, EventArgs e)
        {

            string oldFile = originalFullFile;
            string newFile = newFolder + "\\" + originalFileSafeName.Substring(0,originalFileSafeName.Length - 4) + " with Heat.pdf";

            // open the reader
            PdfReader reader = new PdfReader(oldFile);
            Rectangle size = reader.GetPageSizeWithRotation(1);
            Document document = new Document(size);

            // open the writer
            FileStream fs = new FileStream(newFile, FileMode.Create, FileAccess.Write);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            // the pdf content
            PdfContentByte cb = writer.DirectContent;

            // select the font proprerties
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.DARK_GRAY);
            cb.SetFontAndSize(bf, 20);

            // write the text in the pdf content
            cb.BeginText();
            string text = "Heat #: " + txtboxHeatNumber.Text;
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 560, 500, 270);
            cb.EndText();

            // create the new page and add it to the pdf
            PdfImportedPage page = writer.GetImportedPage(reader, 1);
            cb.AddTemplate(page, 0, 0);

            // close the streams and voila the file should be changed :)
            document.Close();
            fs.Close();
            writer.Close();
            reader.Close();
        }

        private void BrowseFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                /*
                 * Directory - Thinking could be useful...
                MessageBox.Show(ofd.FileName.Substring(0,ofd.FileName.Length - ofd.SafeFileName.Length));
                 */

                originalFullFile = ofd.FileName;
                originalFileSafeName = ofd.SafeFileName;
                txtboxOriginalPDF.Text = originalFileSafeName;
            }
        }

        private void BF_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Microsoft.Office.Core.FileDialog fd = app.get_FileDialog(Microsoft.Office.Core.MsoFileDialogType.msoFileDialogFolderPicker);

            fd.InitialFileName = "e:\\Parts\\"; // Start with the Parts folder

            int nres = fd.Show();
            if (nres == -1) // ok
            {
                Microsoft.Office.Core.FileDialogSelectedItems selectedItems = fd.SelectedItems;

                string[] selectedFolders = selectedItems.Cast<string>().ToArray();  // catch selected items with an array of string

                if (selectedFolders.Length > 0) // if not empty
                {
                    newFolder = selectedFolders[0]; // set the new folder
                    txtboxToDirectory.Text = newFolder; // provide visual feedback
                }

                
            }
        }
    }
}
