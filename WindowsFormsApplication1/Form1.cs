using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectDb();
        }

        private void connectDb()
        {
            string connectionString = getConnectionString();

            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    //lblConnection.Text = connection.State.ToString();
                    lblConnection.Text = "DB에 연결되었습니다";
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        static private string getConnectionString()
        {
            return "server = DESKTOP-1ELA5GB\\SQLEXPRESS; uid = antaehyeon; pwd = xogus1696; database = BROADCASTING_STATION";
        }

        public DataTable GetDBTable(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string connectString = getConnectionString();
            using (connection = new SqlConnection(connectString))
            {
                try
                {
                    if (item == "BROADCASTING_STATION")
                    {
                        //connection.Open();
                        string queryString = "SELECT BNO, BROADNAME, LOCATION FROM BROADCASTING_STATION";
                        //SqlCommand command = new SqlCommand(queryString, connection);
                        //SqlDataAdapter adapter = new SqlDataAdapter(command);
                        //DataSet dataSet = new DataSet();
                        //adapter.Fill(dataSet);
                        //rtbList.Clear();
                        //if (dataSet.Tables.Count > 0)
                        //{
                        //    foreach (DataRow row in dataSet.Tables[0].Rows)
                        //    {
                        //        rtbList.AppendText(row["BNO"].ToString());
                        //        rtbList.AppendText("\t");
                        //        rtbList.AppendText(row["BROADNAME"].ToString());
                        //        rtbList.AppendText("\t");
                        //        rtbList.AppendText(row["LOCATION"].ToString());
                        //        rtbList.AppendText("\n");
                        //    }
                        //}
                        DataTable dt = GetDBTable(queryString);
                        dataGridView1.DataSource = dt;
                    }
                    else if (item == "CAST")
                    {
                        connection.Open();
                        string queryString = "SELECT CASTNO, CASTJOB, CASTNAME, CASTAGE, F_ENTNO, F_TVPNO FROM CAST_";
                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        rtbList.Clear();
                        if (dataSet.Tables.Count > 0)
                        {
                            foreach (DataRow row in dataSet.Tables[0].Rows)
                            {
                                rtbList.AppendText(row["CASTNO"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["CASTJOB"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["CASTNAME"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["CASTAGE"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["F_ENTNO"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["F_TVPNO"].ToString());
                                rtbList.AppendText("\n");
                            }
                        }
                    }

                    else if (item == "DEPENDENT")
                    {
                        connection.Open();
                        string queryString = "SELECT DEPNAME, WEDDINGANNVIERSARY, F_EMPNO  FROM DEPENDENT_";
                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        rtbList.Clear();
                        if (dataSet.Tables.Count > 0)
                        {
                            foreach (DataRow row in dataSet.Tables[0].Rows)
                            {
                                rtbList.AppendText(row["DEPNAME"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["WEDDINGANNVIERSARY"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["F_EMPNO"].ToString());
                                rtbList.AppendText("\n");
                            }
                        }
                    }

                    else if (item == "EMPLOYEE")
                    {
                        connection.Open();
                        string queryString = "SELECT EMPNO, EMPNAME, SALARY, F_BNO_EMP FROM EMPLOYEE";
                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        rtbList.Clear();
                        if (dataSet.Tables.Count > 0)
                        {
                            foreach (DataRow row in dataSet.Tables[0].Rows)
                            {
                                rtbList.AppendText(row["EMPNO"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["EMPNAME"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["SALARY"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["F_BNO_EMP"].ToString());
                                rtbList.AppendText("\n");
                            }
                        }
                    }
                    
                    else if (item == "ENTERTAINMENT")
                    {
                        connection.Open();
                        string queryString = "SELECT ENTNO, ENTNAME, LOCATION FROM ENTERTAINMENT";
                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        rtbList.Clear();
                        if (dataSet.Tables.Count > 0)
                        {
                            foreach (DataRow row in dataSet.Tables[0].Rows)
                            {
                                rtbList.AppendText(row["ENTNO"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["ENTNAME"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["LOCATION"].ToString());
                                rtbList.AppendText("\n");
                            }
                        }
                    }

                    else if (item == "TVPROGRAM")
                    {
                        connection.Open();
                        string queryString = "SELECT TVPNO, TVPNAME, RATING, TVPTIME, F_BNO_TV FROM TVPROGRAM";
                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        rtbList.Clear();
                        if (dataSet.Tables.Count > 0)
                        {
                            foreach (DataRow row in dataSet.Tables[0].Rows)
                            {
                                rtbList.AppendText(row["TVPNO"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["TVPNAME"].ToString());
                                rtbList.AppendText("");
                                rtbList.AppendText(row["RATING"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["TVPTIME"].ToString());
                                rtbList.AppendText("\t");
                                rtbList.AppendText(row["F_BNO_TV"].ToString());
                                rtbList.AppendText("\n");
                            }
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex = checkedListBox1.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < checkedListBox1.Items.Count; iIndex++)
                checkedListBox1.SetItemCheckState(iIndex, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(iSelectedIndex, CheckState.Checked);

            int index = checkedListBox1.SelectedIndex;
            item = checkedListBox1.SelectedItem.ToString();
        }
    }
}
