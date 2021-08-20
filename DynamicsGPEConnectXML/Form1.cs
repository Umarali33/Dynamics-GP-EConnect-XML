using Microsoft.Dynamics.GP.eConnect;
using Microsoft.Dynamics.GP.eConnect.Serialization;
using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DynamicsGPEConnectXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetServerList();
        }
        private void GetServerList()
        {
            try
            {
                string myServer = Environment.MachineName;
                DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
                for (int i = 0; i < servers.Rows.Count; i++)
                {
                    if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine////
                    {
                        if ((servers.Rows[i]["InstanceName"] as string) != null)
                            CmbServerName.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                        else
                            CmbServerName.Items.Add(servers.Rows[i]["ServerName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetDatabaseList()
        {
            try
            {
                string connectionString = "Data Source=" + CmbServerName.SelectedItem.ToString() + "; Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                dbList.Items.Add(dr[0].ToString());
                            }
                        }
                    }
                }
                dbList.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDatabaseList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                eConnectMethods eConnect = new eConnectMethods();
                eConnectType eConnectType = new eConnectType();
                var MyConnectionString = "Data Source=" + CmbServerName.SelectedItem.ToString() + ";Initial Catalog=xxxx;Persist Security Info=False;Integrated Security=SSPI;Min Pool Size=0;Max Pool Size=32767;Pooling=true;";
                SqlConnectionStringBuilder MyConnectionStringBuilder = new SqlConnectionStringBuilder(MyConnectionString) { InitialCatalog = dbList.SelectedItem.ToString() };
                eConnect.CreateTransactionEntity(MyConnectionStringBuilder.ConnectionString, xmlEcon.Text);
                eConnect.Dispose();
            }
            catch (eConnectException ex)
            {
                excep.Text = ex.ToString();
            }
            catch (Exception ex)
            {
                excep.Text = ex.ToString();
            }
        }
        public static string PrintXML(string xml)
        {
            string result = "";

            MemoryStream mStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode);
            XmlDocument document = new XmlDocument();

            try
            {
                // Load the XmlDocument with the XML.
                document.LoadXml(xml);

                writer.Formatting = Formatting.Indented;

                // Write the XML into a formatting XmlTextWriter
                document.WriteContentTo(writer);
                writer.Flush();
                mStream.Flush();

                // Have to rewind the MemoryStream in order to read
                // its contents.
                mStream.Position = 0;

                // Read MemoryStream contents into a StreamReader.
                StreamReader sReader = new StreamReader(mStream);

                // Extract the text from the StreamReader.
                string formattedXml = sReader.ReadToEnd();

                result = formattedXml;
            }
            catch (XmlException)
            {
                // Handle the exception
            }

            mStream.Close();
            writer.Close();

            return result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(xmlEcon.Text))
            {
                string formated=PrintXML(xmlEcon.Text);
                xmlEcon.Text = formated;
            }
        }
    }
}
