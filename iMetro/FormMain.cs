using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iMetro
{
    public partial class FormMain : Form
    {
        private M m;
        private List<Test> testList;
        private BindingList<Test> testBindList;
        private Microsoft.Office.Interop.Word.Application app;
        private Document doc, tmpDoc;
        public FormMain()
        {
            InitializeComponent();
            m = new M();
            testList = new List<Test>();
            tbSearchZsdwName.Text = "安徽省第二人民医院";
            tbSearchProductName.Text = "多参数监护仪";
            tbSearchTaskName.Text = "ICU";
            //searchTest();
            docShow.CreateNew("Word.Document");
            doc = (Document)docShow.ActiveDocument;
        }


        private void toolBtnSeach_Click(object sender, EventArgs e)
        {
            searchTest();
        }

        private void tbSearchZsdwName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                searchTest();
            }
        }

        private void tbSearchProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                searchTest();
            }
        }

        private void tbSearchProductType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                searchTest();
            }
        }

        private void tbSearchProductNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                searchTest();
            }
        }

        private void tbSerachProductFactory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                searchTest();
            }
        }

        private void tbSearchTaskName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                searchTest();
            }
        }

        public void searchTest()
        {
            string where = "{";
            where += "'zsdw_name': db.RegExp({ 'regexp':'.*" + tbSearchZsdwName.Text + ".*','options': 'i'}),";
            where += "'product_name': db.RegExp({ 'regexp':'.*" + tbSearchProductName.Text + ".*','options': 'i'}),";
            where += "'product_type': db.RegExp({ 'regexp':'.*" + tbSearchProductType.Text + ".*','options': 'i'}),";
            where += "'product_number': db.RegExp({ 'regexp':'.*" + tbSearchProductNumber.Text + ".*','options': 'i'}),";
            where += "'product_factory': db.RegExp({ 'regexp':'.*" + tbSerachProductFactory.Text + ".*','options': 'i'}),";
            where += "'task_name': db.RegExp({ 'regexp':'.*" + tbSearchTaskName.Text + ".*','options': 'i'})";
            where += "}";

            string resTest = m.query("tests", where, "10", "{_id: true, zsdw_name: true, task_name: true, product_name: true, product_type: true, product_number: true, product_factory: true}");
            //Debug.WriteLine(resTest);
            resTest = Regex.Replace(resTest, "(\\\\|\")", "");
            //Debug.WriteLine(resTest);
            int total = Convert.ToInt32(Regex.Match(resTest, "total:(\\d*)", RegexOptions.IgnoreCase).Groups[1].Value);
            string data = Regex.Match(resTest, "data:\\[(.*)\\]", RegexOptions.IgnoreCase).Groups[1].Value;
            //Debug.WriteLine("total: "+ total);
            //Debug.WriteLine("data: " + data);

            string[] strTests = Regex.Split(data, "\\},\\{");
            testList.Clear();
            foreach (string strTest in strTests)
            {
                //Debug.WriteLine(strTest);
                testList.Add(new Test(strTest));
            }
            testBindList = new BindingList<Test>(testList);
            dataGridView.DataSource = testBindList;
        }

        private void btnSelectTemplate_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            Debug.WriteLine(openFileDialog.FileName);
            if (tmpDoc == null)
            {
                app = new Microsoft.Office.Interop.Word.Application();
                tmpDoc = app.Documents.Add(openFileDialog.FileName);
                tmpDoc.ActiveWindow.Visible = false;
            }
            MessageBox.Show(openFileDialog.FileName);
        }

        private void btnCreateRecord_Click(object sender, EventArgs e)
        {
            if (tmpDoc == null) 
            {
                MessageBox.Show("请先选择模版");
                return;
            }
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一条检测记录");
                return;
            }
            if (doc == null)
            {
                docShow.CreateNew("Word.Document");
                doc = (Document)docShow.ActiveDocument;
            }

            string id = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Debug.WriteLine(id);
            string res = m.query("tests", "{_id: '" + id + "'}", "1", "{test_data: true}");
            //Debug.WriteLine(res);
            res = Regex.Replace(res, "(\\\\|\")", "");
            Debug.WriteLine(res);

            MatchCollection matchesGroup = Regex.Matches(res, "detail:(.*?)name:([^,\\}]+)\\}+");
            int ii = 0, jj;
            string test_data = "";
            foreach (Match matchGroup in matchesGroup)
            {

                //Debug.WriteLine("groupName:" + matchGroup.Groups[2].Value);
                //Debug.WriteLine("groupDetail:" + matchGroup.Groups[1].Value);
                jj = 0;
                MatchCollection matchesDetail = Regex.Matches(matchGroup.Groups[1].Value, "collapse.*?name:(.*?),.*?type:(.*?),.*?value:(.*?)\\}");
                foreach (Match matchDetail in matchesDetail)
                {
                    //Debug.WriteLine("    DetailName:" + matchDetail.Groups[1].Value);
                    //Debug.WriteLine("    DetailType:" + matchDetail.Groups[2].Value);
                    string value = matchDetail.Groups[3].Value;
                    if (matchDetail.Groups[2].Value == "布尔")
                    {
                        //Debug.WriteLine("    groupDetail:" + matchDetail.Groups[0].Value);
                        GroupCollection g = Regex.Match(matchDetail.Groups[0].Value, "falseString:(.*?),.*?trueString:(.*?),").Groups;
                        //Debug.WriteLine("    falseString:" + g[1].Value);
                        //Debug.WriteLine("    trueString:" + g[2].Value);

                        if (value == "true")
                        {
                            value = g[2].Value;
                        }
                        else
                        {
                            value = g[1].Value;
                        }
                    }
                    //Debug.WriteLine("    DetailValue:" + value);
                    test_data += "g" + ii + "d" + jj + ":" + value +",";
                    //Debug.WriteLine(test_data);

                    jj++;
                }
                ii++;
            }

            DataGridViewCellCollection cells= dataGridView.SelectedRows[0].Cells;
            for (int i = 0; i < cells.Count; i++)
            {
                Debug.WriteLine(cells[i].Value);
            }

            foreach (Section sec in tmpDoc.Sections)
            {
                sec.Range.Copy();
                try
                {
                    doc.Sections[1].Range.PasteAndFormat(WdRecoveryType.wdPasteDefault);
                }
                catch (Exception)
                {
                    MessageBox.Show("未知错误！");
                    return;
                }
                
            }

            foreach (Bookmark bk in doc.Bookmarks)
            {
                //Debug.WriteLine(bk.Name);
                switch (bk.Name)
                {
                    case "zsdw":
                        bk.Range.Text = cells[1].Value.ToString(); break;
                    case "product_name":
                        bk.Range.Text = cells[3].Value.ToString(); break;
                    case "product_type":
                        bk.Range.Text = cells[4].Value.ToString(); break;
                    case "product_number":
                        bk.Range.Text = cells[5].Value.ToString(); break;
                    case "product_factory":
                        bk.Range.Text = cells[6].Value.ToString(); break;
                    case "test_addr":
                        bk.Range.Text = cells[2].Value.ToString(); break;
                    default:
                        bk.Range.Text = Regex.Match(test_data, bk.Name + ":(.*?),").Groups[1].Value;
                        break;
                }
            }
            tabControl.SelectedTab = tabPagePreview;
            doc.PrintPreview();
            //doc.print
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (doc != null)
            {
                //docShow.Close();
                //MessageBox.Show("Close doc");
            }
            if (tmpDoc != null)
            {
                tmpDoc.Close();
                //MessageBox.Show("Close tmpDoc");
            }
            if (app != null)
            {
                //MessageBox.Show(app.Documents.Count.ToString());
                app.Quit(Type.Missing, Type.Missing, Type.Missing);
                //MessageBox.Show("Close app");
            }
            
        }

        private void tabPagePreview_SizeChanged(object sender, EventArgs e)
        {
            //Debug.WriteLine(tabPagePreview.Width + ":" + tabPagePreview.Height);
            docShow.Width = tabPagePreview.Width - 12;
            docShow.Height = tabPagePreview.Height - 9;
        }
    }

    public class Test
    {
        private string _id;
        private string _zsdw_name;
        private string _task_name;    //检测地点
        private string _product_name;
        private string _product_type;
        private string _product_number;
        private string _product_factory;

        public Test(string str)
        {
            string patt = "([\\w\\(\\)~/]*)([,\\}]*)";
            _id = Regex.Match(str, "_id:" + patt).Groups[1].Value;
            //Debug.WriteLine("id:" + _id);
            _zsdw_name = Regex.Match(str, "zsdw_name:" + patt).Groups[1].Value;
            //Debug.WriteLine("zsdw_name:" + _zsdw_name);
            _task_name = Regex.Match(str, "task_name:" + patt).Groups[1].Value;
            //Debug.WriteLine("task_name:" + _task_name);
            _product_name = Regex.Match(str, "product_name:" + patt).Groups[1].Value;
            //Debug.WriteLine("product_name:" + _product_name);
            _product_type = Regex.Match(str, "product_type:" + patt).Groups[1].Value;
            //Debug.WriteLine("product_type:" + _product_type);
            _product_number = Regex.Match(str, "product_number:" + patt).Groups[1].Value;
            //Debug.WriteLine("product_number:" + _product_number);
            _product_factory = Regex.Match(str, "product_factory:" + patt).Groups[1].Value;
            //Debug.WriteLine("product_factory:" + _product_factory);
        }

        public string id { get { return _id; } }
        public string zsdw_name { get { return _zsdw_name; } }
        public string task_name { get { return _task_name; } }
        public string product_name { get { return _product_name; } }
        public string product_type { get { return _product_type; } }
        public string product_number { get { return _product_number; } set { _product_number = value; } }
        public string product_factory { get { return _product_factory; } }

        public List<TestData> testDataList { get; set; }

    }
    

    public class TestDataGroup
    {
        public string groupName { set; get; }
        public List<TestData> testDataList { set; get; }
        public TestDataGroup(string name, string detail)
        {
            groupName = name;
            testDataList = new List<TestData>();

            MatchCollection matches = Regex.Matches(detail, "collapse.*?name:(.*?),.*?type:(.*?),.*?value:(.*?)\\}");

            foreach (Match match in matches)
            {
                //Debug.WriteLine(match.Value);
                //Debug.WriteLine("---name:" + match.Groups[1].Value);
                //Debug.WriteLine("---value:" + match.Groups[3].Value);
                //Debug.WriteLine("---type:" + match.Groups[2].Value);

                TestData testData = new TestData();
                testData.name = match.Groups[1].Value;
                testData.value = match.Groups[3].Value;
                if (match.Groups[2].Value == "布尔") 
                {
                    GroupCollection group = Regex.Match(match.Value, "falseString:(.*?),.*?trueString:(.*?),").Groups;
                    //Debug.WriteLine("---falseString:" + group[1].Value);
                    //Debug.WriteLine("---trueString:" + group[2].Value);
                    if (match.Groups[3].Value == "true")
                    {
                        testData.value = group[2].Value;
                    }
                    else 
                    {
                        testData.value = group[1].Value;
                    }
                }
                //Debug.WriteLine("---value:" + testData.value);
                testDataList.Add(testData);
            }
        }

    }

    public class TestData
    {
        public string name { set; get; }
        public string value { set; get; }
        public TestData()
        {
            
        }

    }
}
