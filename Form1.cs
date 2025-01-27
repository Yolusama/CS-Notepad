using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MyNotePad
{
    public partial class Form1 : Form
    {
        static int index;
       int i = 0;
        string fn = "";//文件名写入中介
        string s = "";
        bool modified=false;//文本是否被写过
        string filter = "文本文件|*.txt;*.cs;*.c;*.cpp;*.java;*.html|所有文件|*.*";//文件格式
        bool fstate=false;
        public Form1()
        {
            InitializeComponent();
        }
        DateTime dt = DateTime.Now;
        void gettime()
        {
            label7.Text = dt.Hour.ToString() + ":" + dt.Minute.ToString() + ":" + dt.Second.ToString(); 

        }
        void Flushtime()
        {
            dt =DateTime.Now;
            label7.Text = dt.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = label5.Text ="";
            gettime();
            Flushtime();
        }
        void openfile()
        {
            openFileDialog1.Title = "打开";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = this.filter;
            openFileDialog1.FilterIndex = 1;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn=openFileDialog1.FileName;
                richTextBox1.LoadFile(fn, RichTextBoxStreamType.PlainText);//富文本打开文件指令
                modified=true;
            }
        }
        void savefileas()
        {
            if (i == 0)
                saveFileDialog1.Title = "另存为";
            else saveFileDialog1.Title = "保存";
            saveFileDialog1.Filter = this.filter;
            if(this.saveFileDialog1.ShowDialog()==DialogResult.OK)//显示对话框执行以下操作r
            {
                if(saveFileDialog1.FileName!="")
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);//富文本存文件指令
                    fn=saveFileDialog1.FileName;
                    modified = false;
                }
            }

        }
        void savefile()//保存是另存为的特殊方式
        {
            if (fn == "") { i=1; savefileas(); }
            else
            {
                richTextBox1.SaveFile(fn, RichTextBoxStreamType.PlainText);
                modified = false;

            }
            i = 0;
        }
        DialogResult wethersave()
        {
            DialogResult re=DialogResult.None;
            if(modified)
            {
                re=MessageBox.Show("是否保存","提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    savefile();
                }
            }
            return re;
        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void 保存CTRLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefile();
        }

        private void 打开CTRLOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openfile();
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefileas();
        }

        private void 撤销ZCTRLZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 重新填写ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        void createfile()
        {
            Form1 f=new Form1();
            this.Hide();
           SaveFileDialog s=new SaveFileDialog();
            s.Title = "新建";
            s.FileName = "新建文件";
            s.Filter = this.filter;
            f.Text=s.FileName;
            f.ShowDialog();
            this.Close();
        }
        private void 新建CRTLNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createfile();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            savefile();
        }

        private void 新建CTRLNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createfile();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form3 fm=new Form3();
            this.Hide();
            fm.ShowDialog();
           fm.Close();
            fm.Dispose();
            this.Show();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 复制CTRLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
             richTextBox1.Copy();
        }

        private void 字体FCTRLFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void 背景颜色BCTRLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void 粘贴CTRLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
           richTextBox1.Paste();
        }
 Form2 f;
        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Form2();
            f.label2.Hide();
            f.ShowDialog();
            f.s = f.textBox1.Text;
            index = richTextBox1.Text.IndexOf(f.s);
            richTextBox1.Find(f.s);
            if (f.button1.DialogResult == DialogResult.OK)
            {
                if (f.s == "")
                    MessageBox.Show("没有选择文本内容", "空选项", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(richTextBox1.Find(f.s)==-1)
                    MessageBox.Show("文本中不存在此内容","不存在内容项",MessageBoxButtons.OK, MessageBoxIcon.Error);
                f.Close();
            }
            f.Dispose();
        }

        private void 剪切CTRLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        public string getfn() { return fn; }

        private void 字体颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if(colorDialog2.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog2.Color;
            }
        }

        private void 全选CTRLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs E)
        {
            DialogResult r = wethersave();
            if ( r== DialogResult.OK||r == DialogResult.Cancel) E.Cancel = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
               
                try
                {
                    richTextBox1.Find(f.s, index + f.s.Length, richTextBox1.Text.Length, RichTextBoxFinds.None);
                    index = richTextBox1.Text.Substring(index).IndexOf(f.s) + f.s.Length;
                    if (index == richTextBox1.Text.Length)
                        richTextBox1.Find(f.s, index - f.s.Length, index, RichTextBoxFinds.None);
                    if(f.s==""||richTextBox1.Find(f.s, index + f.s.Length, richTextBox1.Text.Length, RichTextBoxFinds.None)==-1)
                    MessageBox.Show("无更多的待搜寻文本","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            /*if (f.button1.DialogResult == DialogResult.OK)
            {
                if (f.s == "")
                    MessageBox.Show("没有更多的选择文本内容", "空选项", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (richTextBox1.Find(f.s) == -1)
                    MessageBox.Show("文本中不存在更多的此内容", "不存在内容项", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } */
          
        }

        private void 替换RCTRLRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s,s1;
            this.Hide();
            f=new Form2(); 
            f.ShowDialog(); 
            f.label1.Hide();
            s1 = richTextBox1.SelectedText;
            try {
            f.s = f.textBox1.Text;
            s=richTextBox1.Text.Replace(s1, f.s)+f.s.Length;
                richTextBox1.Text = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
            if(f.button1.DialogResult == DialogResult.OK)
            {
                if(f.s=="")
                    MessageBox.Show("空字符串替换","空字符串异常",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (s1 == "")
                    MessageBox.Show("替换空字符串", "字符串空异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            f.Close();
            f.Dispose();
            this.Show();
        }

        private void 替换使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用替换前请先选择替换的文本","说明",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void 删除CTRLDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool b = false;
            int i=0;
            string s= richTextBox1.SelectedText;
            i = s.IndexOf(richTextBox1.Text);
            if (s != "")
            {
                b = true;
            }
            try
            {
                if (b)
                {
                     if (s == richTextBox1.Text)
                        richTextBox1.Clear(); 
                    else richTextBox1.Text = richTextBox1.Text.Remove(i + 1, i + s.Length + 1);
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "索引异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            savefileas();
        }
        
       
        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("文本采用ANIC标准","说明",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void richTextBox1_HideSelectionChanged(object sender, EventArgs e)
        {
            
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            modified=true;
        }
        static int count = 0;
        static int count1 = 0;
        static int count2 = 0; 
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            count++;
            if (count%2== 1)
            {
                label4.Hide();
            }
            else label4.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            count2++;
            if (count2 %2== 1)
            {
                label5.Hide();
            }
            else label5.Show();
        }

        private void richTextBox1_SelectionChanged_1(object sender, EventArgs e)
        {
            int col=0;
        int row=0;
            col = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
            row = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(col);
            label4.Text = (col+1).ToString();
            label5.Text = (row+1).ToString();
        }

        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(linkLabel2.Text);
        }

        void openca()
        {
            Form4 fm=new Form4();
            this.Hide();
            fm.ShowDialog();
            fm.Close();
            fm.Dispose();
            this.Show();
        }
        private void 日历CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openca();
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            count2++;
            if (count2 % 2 == 1)
            {
                label7.Hide();
            }
            else label7.Show();
            Flushtime();
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            Flushtime();
        }
    }
}
