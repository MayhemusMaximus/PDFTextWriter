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
        //public String originalFullFile = String.Empty;
        //public String originalFileSafeName = String.Empty;

        public String originalDirectory = String.Empty;
        public String destinationDirectory = String.Empty;

        List<File> fileList = new List<File>();


        public PDFHeatTextWriter()
        {
            InitializeComponent();
        }

        private void PDFHeatTextWriter_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "PDF Heat Text Writer v" + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch
            {
                this.Text = "PDF Heat Text Writer v: " + "Debug";
            }

            BTNWriteHeat.Enabled = false;
            
        }

        private void WriteHeat_Click(object sender, EventArgs e)
        {
            if (originalDirectory != String.Empty)
            {
                if (destinationDirectory != string.Empty)
                {
                    //string oldFile = originalFullFile;

                    foreach (File file in fileList)
                    {
                        if (file.Heat != string.Empty)
                        {

                            // open the reader
                            PdfReader reader = new PdfReader(originalDirectory + "\\" + file.FileName);
                            Rectangle size = reader.GetPageSizeWithRotation(1);
                            Document document = new Document(size);

                            // open the writer
                            string newFile = destinationDirectory + "\\" + file.FileName.Substring(0, file.FileName.Length - 4) + " Ht " + file.Heat + ".pdf";
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
                            string text = "Heat #: " + file.Heat;

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

                    }
                }
                else
                {
                    MessageBox.Show("Select a destination folder.");
                }
            }
            else
            {
                MessageBox.Show("Select an origin folder.");
            }
        }

        private void BrowseFolder_Click(object sender, EventArgs e)
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

                    if (((Button)sender).Name == "BTNDestinationBrowse")
                    {
                        destinationDirectory = selectedFolders[0]; // set the new folder
                        TBDestination.Text = destinationDirectory; // provide visual feedback
                    }

                    if (((Button)sender).Name == "BTNOriginBrowse")
                    {
                        
                        string[] files;

                        originalDirectory = selectedFolders[0]; // set the orignal Directory

                        files = Directory.GetFiles(originalDirectory, "*.pdf"); // get only the pdf files
                        if (files.Count() == 0) // validation - PDF files need to exist in the directory bofore we can continue.
                        {
                            MessageBox.Show("There are no PDF's in the selected directory."); // Give user visual feedback about no directory being selected.
                            TBOrigin.Text = String.Empty; // Give user visual feedback about no directory being selected.
                            originalDirectory = String.Empty; // This will insure validation after else works
                        }
                        else
                        {
                            fileList.Clear(); // Clear the fileList
                            foreach (string file in files) // loop through the files to build the list
                            {
                                TBOrigin.Text = originalDirectory; // set feedback for textbox
                                string fileName = GetFileName(file); // set filename
                                string heat = string.Empty; // set heat to empty
                                File dgvFile = new File(fileName, heat); // create file object
                                fileList.Add(dgvFile); // add file object to list
                            }

                            DGVFiles.DataSource = fileList; // set the list as the datagridview source.
                            DGVFiles.Columns[0].ReadOnly = true; // don't let the user adjust the file name.
                        }
                        
                    }

                    // If two valid directories have been provided enable the WriteHeat Button.
                    BTNWriteHeat.Enabled = (originalDirectory != String.Empty 
                                            && destinationDirectory != String.Empty);
                }
            }

            
        }

        public String GetFileName(string file)
        {
            return file.Substring(file.LastIndexOf("\\") + 1, file.Length - file.LastIndexOf("\\") - 1);
        }

        public class File
        {
            #region Declarations

            // These fields hold the values for the public properties.
            private Guid idValue = Guid.NewGuid();
            private String fileName = String.Empty;
            private String heat = String.Empty;
            public event PropertyChangedEventHandler PropertyChanged;

            #endregion

            #region EventHandling

            private void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }

            #endregion

            #region Constructors

            // The constructor is private to enforce the factory pattern.
            private File()
            {
                fileName = "no data";
                heat = "no data";
            }

            public File(String fileName, string heat)
            {
                this.fileName = fileName;
                this.heat = heat;
            }

            #endregion

            #region Methods

            // This is the public factory method.
            public static File CreateNewFile()
            {
                return new File();
            }

            #endregion

            #region Properties

            public String FileName
            {
                get { return this.fileName; }
                set
                {
                    if (value != this.fileName)
                    {
                        this.fileName = value;
                        NotifyPropertyChanged("File");
                    }
                }
            }

            public String Heat
            {
                get { return this.heat; }
                set
                {
                    if (value != this.heat)
                    {
                        this.heat = value;
                        NotifyPropertyChanged("Heat");
                    }
                }
            }

            #endregion


        }
    }
}
