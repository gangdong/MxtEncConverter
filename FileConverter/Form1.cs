using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Text.RegularExpressions;

namespace FileConverter
{
    public partial class Form1 : Form
    {

        private StringBuilder convertData = new StringBuilder();
        private StringBuilder originalData = new StringBuilder();

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // Set filter options and filter index.
            openFileDialog1.Filter = "ENC Files (.enc)|*.enc|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;


            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();
            if (userClickedOK == DialogResult.OK)
            {
                System.IO.Stream fileStream;
                textBoxOpen.Text = openFileDialog1.FileName;
                // Open the selected file to read.
                fileStream = openFileDialog1.OpenFile();

                tbResults.Clear();
                originalData.Clear();
                convertData.Clear();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    // Read the first line from the file and write it the textbox.
                    ////tbResults.Text = reader.ReadLine();
                    char[] c = null;
                    
                    while (reader.Peek() >= 0)
                    {
                        c = new char[1000];
                        reader.Read(c, 0, c.Length);
                        // tbResults.AppendText(new string(c));

                        originalData.Append(new string(c));
                        tbResults.AppendText(new string(c));
                        progressBar.Value = (int)fileStream.Position * 100 / (int)fileStream.Length;
                    }
                }
                fileStream.Close();
                MessageBox.Show("The ENC file has been loaded successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "header files (*.h)|*.h";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = ".h";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);

                string prx = "#ifndef _ATMEL_MXT_FW_H \r\n" + "#define _ATMEL_MXT_FW_H \r\n" + "const unsigned char mxt_fw_data[] = { \r\n";
                string suf = "};\r\n" + "#endif";

                string content = "";

                if (this.checkBoxAddIdInfo.Checked)
                {

                    string familyId = this.textBoxFamilyID.Text;
                    string variantId = this.textBoxVariantID.Text;
                    string version = this.textBoxVersion.Text;
                    string build = this.textBoxBuild.Text;
                    string infoCRC = this.textBoxInfoCRC.Text;

                    if ((familyId.Length <2 ) || (variantId.Length < 2 ) || (version.Length < 2) || (build.Length < 2) || (infoCRC.Length < 6))
                    {

                        MessageBox.Show("The data length is not correct, Please input correct info data! ","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        try
                        {
                            string data0 = "0x" + familyId.Substring(0, 2) + ",";
                            string data1 = "0x" + variantId.Substring(0, 2) + ",";
                            string data2 = "0x" + version.Substring(0, 2) + ",";
                            string data3 = "0x" + build.Substring(0, 2) + ",";
                            string data4 = "0x" + infoCRC.Substring(0, 2) + ",";
                            string data5 = "0x" + infoCRC.Substring(2, 2) + ",";
                            string data6 = "0x" + infoCRC.Substring(4, 2) + ",";
                            content = data0 + data1 + data2 + data3 + data4 + data5 + data6 + convertData.ToString();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("wrong data!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //throw; ArgumentOutOfRangeException;
                        }
                        
                        writer.Write(prx + content + suf);
                        writer.Close();
                        MessageBox.Show("Files Saved!\n"+filePath, "File Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else {

                    content = convertData.ToString(); ;
                    writer.Write(prx + content + suf);
                    writer.Close();
                    MessageBox.Show("Files Saved!\n" + filePath, "File Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

               
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            //convert the string to Hex
            //bt = System.Text.RegularExpressions.Regex.Split(tbResults.Text, @"(\w{2})").Where(t => t.Trim() != "").Select(t => Convert.ToByte(t, 16)).ToArray();
            
            //add "0x" and "," 
            string bufferString, bufferTbresultText;
            bufferTbresultText = originalData.ToString();
            
            tbResults.Clear();
            convertData.Clear();

            MatchCollection mc = new Regex("\\w{2}").Matches(bufferTbresultText);
            int index=1;
            foreach (Match m in mc)
            {
                progressBar.Value = (index++)*100/mc.Count;
                bufferString = m.Value.Insert(0, "0x");
                bufferString = bufferString.Insert(4, ",");
                convertData.Append(bufferString);
                tbResults.AppendText(bufferString);
            }
           // tbResults.Text = convertData.ToString();
            MessageBox.Show("Data Convert Completed!","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            tbResults.Text = "";
            textBoxOpen.Text = "";

            originalData.Clear();
            convertData.Clear();
        }

        
        private void checkBoxAddIdInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAddIdInfo.Checked)
            {
                this.textBoxFamilyID.Enabled = true;
                this.textBoxVariantID.Enabled = true;
                this.textBoxVersion.Enabled = true;
                this.textBoxBuild.Enabled = true;
                this.textBoxInfoCRC.Enabled = true;

                this.labelFamily.ForeColor = Color.Black;
                this.labelFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                this.labelVariant.ForeColor = Color.Black;
                this.labelVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                this.labelVersion.ForeColor = Color.Black;
                this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                this.labelBuild.ForeColor = Color.Black;
                this.labelBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                this.labelCrc.ForeColor = Color.Black;
                this.labelCrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                this.label6.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label8.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label10.ForeColor = Color.Black;
                
                this.label12.ForeColor = Color.Black;
                this.label13.ForeColor = Color.Black;
                this.label14.ForeColor = Color.Black;
                this.label15.ForeColor = Color.Black;
                this.label16.ForeColor = Color.Black;
            }
            else {
                

                this.textBoxFamilyID.Enabled = false;
                this.textBoxVariantID.Enabled = false;
                this.textBoxVersion.Enabled = false;
                this.textBoxBuild.Enabled = false;
                this.textBoxInfoCRC.Enabled = false;

                this.labelFamily.ForeColor = Color.Gray;
                this.labelFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                this.labelVariant.ForeColor = Color.Gray;
                this.labelVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                this.labelVersion.ForeColor = Color.Gray;
                this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                this.labelBuild.ForeColor = Color.Gray;
                this.labelBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                this.labelCrc.ForeColor = Color.Gray;
                this.labelCrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));


                this.label6.ForeColor = Color.Gray;
                this.label7.ForeColor = Color.Gray;
                this.label8.ForeColor = Color.Gray;
                this.label9.ForeColor = Color.Gray;
                this.label10.ForeColor = Color.Gray;
                
                this.label12.ForeColor = Color.Gray;
                this.label13.ForeColor = Color.Gray;
                this.label14.ForeColor = Color.Gray;
                this.label15.ForeColor = Color.Gray;
                this.label16.ForeColor = Color.Gray;


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

            string aboutText = "ENC2Array Converter, one of MXT Touch series tool, convert the ENC format MXT devices firmware file to hex data array.\n\nVersion: V1.0.00\nAuthor: daviddong@solomon-systech.com\nDate: 2018-2-1";
            MessageBox.Show(aboutText,"ENC to Array Converter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
