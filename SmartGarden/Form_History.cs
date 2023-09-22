using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Threading;

namespace SmartGarden
{
    public partial class Form_History : Form
    {
        public Form_History()
        {
            InitializeComponent();            
        }
        JavaScriptSerializer jss = new JavaScriptSerializer();
        List<history_Json> json_Respone = new List<history_Json>();
        WebRequest webRequest;
        WebResponse webResponse;
        string resContent = string.Empty;
        private void Form_History_Load(object sender, EventArgs e)
        {
            string url = string.Empty;          
            url = "https://vuonthongminh-328d9-default-rtdb.firebaseio.com/History.json";
            webRequest = WebRequest.Create(url);
            webResponse = webRequest.GetResponse();
            resContent = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            var obj = jss.Deserialize<dynamic>(resContent);
            int len = obj.Length;
            for (int i = 0; i < len; i++)
            {
                var data = new history_Json
                {
                    Date = obj[i]["Date"],
                    Time = obj[i]["Time"],
                    Fan = obj[i]["Fan"],
                    Humi = obj[i]["Humidity"],
                    Lamp = obj[i]["Lamp"],
                    Light = obj[i]["Light"],
                    Mode = obj[i]["Mode"],
                    Pump = obj[i]["Pump"],
                    Weather = obj[i]["Rain"],
                    
                    Soil = obj[i]["Soil"],
                    Stepper = obj[i]["Stepper"],
                    Temp = obj[i]["Temperature"]              
                };
                json_Respone.Add(data);           
            }
            dtgv_history.DataSource = json_Respone;
            
        }
        ojbJson json = new ojbJson();
        private void button1_Click(object sender, EventArgs e)
        {

            
            
            var obj = jss.Deserialize<dynamic>(resContent);
            var len = obj.Length;
            List<history_Json> json_Respone1 = new List<history_Json>();
            for (int i = 0; i < len; i++)
            {                
                if (dateTimePicker1.Value.ToString("dd-MM-yyyy") == obj[i]["Date"])
                {
                    var data = new history_Json
                    {
                        Date = obj[i]["Date"],
                        Time = obj[i]["Time"],
                        Fan = obj[i]["Fan"],
                        Humi = obj[i]["Humidity"],
                        Lamp = obj[i]["Lamp"],
                        Light = obj[i]["Light"],
                        Mode = obj[i]["Mode"],
                        Pump = obj[i]["Pump"],
                        Weather = obj[i]["Rain"],
                       
                        Soil = obj[i]["Soil"],
                        Stepper = obj[i]["Stepper"],
                        Temp = obj[i]["Temperature"]
                    };
                    json_Respone1.Add(data);                    
                }
            }
            dtgv_history.DataSource = json_Respone1;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dtgv_history.Rows.Count > 0)
            {
                Thread t = new Thread((ThreadStart)(() => { 
                    SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Report.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dtgv_history.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dtgv_history.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dtgv_history.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close(); 
                                stream.Close();
                            }
                               

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
                }));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
            }
        }
    }
}
