using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using dao.common;
using dao.user;
using dao;
using System.IO;

namespace common.editEmail
{
    public partial class EditFrm : Form
    {
        public EditFrm()
        {
            InitializeComponent();
            richTextBoxBody.Tick += new Editor.TickDelegate(richTextBoxBody_Tick);
        }

        private void richTextBoxBody_Tick()
        {
            undoToolStripMenuItem.Enabled = richTextBoxBody.CanUndo();
            redoToolStripMenuItem.Enabled = richTextBoxBody.CanRedo();
            cutToolStripMenuItem.Enabled = richTextBoxBody.CanCut();
            copyToolStripMenuItem.Enabled = richTextBoxBody.CanCopy();
            pasteToolStripMenuItem.Enabled = richTextBoxBody.CanPaste();
        }

        public int id=0;
        private String title = "";
        private String content = "";
        private EmailInfoDao editEmailDao = new EmailInfoDao();
        public MainForm mainForm;

        private string _filename = null;

        // 编辑数据，加载数据
        private void EditFrm_Load(object sender, EventArgs e)
        {
            if(id>0){
             Dictionary<String,Object> emailInfoDictionary= editEmailDao.loadEmailInfoById(id);
             object titleObj = "";
             object contentObj = "";
             emailInfoDictionary.TryGetValue("title",out titleObj);
             emailInfoDictionary.TryGetValue("content",out contentObj);
             this.textBoxTitle.Text = titleObj.ToString();
             contentObj = contentObj.ToString().Replace("href=\"http://ema.qianlongsoft.com/CF_url.asp?u=" + InfoHelper.userName + "&g=", "href=\"");
             contentObj = contentObj.ToString().Replace("&l=","");
             String repstr = "";
             int start = contentObj.ToString().IndexOf("href=\"");
             if (start!=-1)
             {
                 repstr = contentObj.ToString().Substring(start);
                 int end =repstr.IndexOf("http://") ;
                 if (end != -1)
                 {
                    repstr= repstr.Substring(6,end-6);
                    if (repstr.Length==12)
                    {
                     contentObj = contentObj.ToString().Replace(repstr, "");
                     }
                 }
             }
             _filename = titleObj.ToString();

             //this.richTextBoxBody.BodyHtml = 
             richTextBoxBody.DocumentText = contentObj.ToString();
             Text = richTextBoxBody.DocumentTitle;
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _filename = null;
            Text = null;
            richTextBoxBody.BodyHtml = string.Empty;
        }

        private void LoadOpenFile(string filename)
        {
            using (StreamReader reader = File.OpenText(filename))
            {
                richTextBoxBody.DocumentText = reader.ReadToEnd();
                reader.Close();
                Text = richTextBoxBody.DocumentTitle;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "HTML files (*.html;*.htm)|*.html;*.htm";
                DialogResult res = dlg.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    _filename = dlg.FileName;
                }
                else
                    return;
            } LoadOpenFile(_filename);
        }

        //保存按钮
        private void buttonSave_Click(object sender, EventArgs e)
        {
            title =this.textBoxTitle.Text.Trim();
            content = this.richTextBoxBody.BodyHtml;
            content = content.Replace("href=\"http://", "href=\"http://ema.qianlongsoft.com/CF_url.asp?u="+InfoHelper.userName +"&g="+ Constant.GenerateRandomNumber(6) + "&l=http://");

            if (check(title, content))
            {
                if (id > 0)
                {
                    editEmailDao.updateEmailInfo(title,content,id);
                }
                else
                {
                   
                    editEmailDao.saveCreate(title, content);
                }
                mainForm.loadEmailInfo();
                this.Close();
            }
        }
       /// <summary>
        /// 验证内容
       /// </summary>
       /// <param name="title"></param>
       /// <param name="content"></param>
       /// <returns></returns>
        private Boolean check(String title,String  content) {
            Boolean result = false;
            String msg = "";
          if(title.Equals("")||title==null){
              msg="请填写邮件标题";
           }else if(content.Equals("")||content==null){
               msg = "请填写邮件内容";
           }
          else if (title.Length>100 ||title.Length<2)
          {
              msg = "邮件的标题请控制在2到100个字符以内";
           }else if(content.Length<2){
               msg = "邮件的内容请控制在2到2000个字符之间";
           }else{
               result = true;
           }
            if(!msg.Equals("")){
              MessageBox.Show(msg,"提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            return result;
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadFile(string filename)
        {
            using (StreamReader reader = File.OpenText(filename))
            {
                richTextBoxBody.DocumentText = reader.ReadToEnd();
                reader.Close();
                Text = richTextBoxBody.DocumentTitle;
            }
        }


        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SearchDialog dlg = new SearchDialog(richTextBoxBody))
            {
                dlg.ShowDialog(this);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxBody.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxBody.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxBody.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxBody.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxBody.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxBody.Redo();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, richTextBoxBody.BodyText);
        }

        private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, richTextBoxBody.BodyHtml);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxBody.Print();
        }

        private void breakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxBody.InsertBreak();
        }

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (TextInsertForm form = new TextInsertForm(richTextBoxBody.BodyHtml))
            {
                form.ShowDialog(this);
                if (form.Accepted)
                {
                    richTextBoxBody.BodyHtml = form.HTML;
                }
            }
        }

        private void paragraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxBody.InsertParagraph();
        }

     

    }
}
