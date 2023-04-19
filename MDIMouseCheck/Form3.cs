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
using System.Runtime.Serialization.Formatters.Binary;

namespace MDIMouseCheck
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("../../../fs.txt"))
            {
                sw.Write(textBox1.Text);
                MessageBox.Show("텍스트가 파일에 저장되었습니다");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            try
            {
                using (StreamReader sr = new StreamReader("../../../fs.txt"))
                {
                    textBox1.Text = sr.ReadToEnd();
                    MessageBox.Show("파일을 읽었습니다");
                }
            }
            catch
            {
                MessageBox.Show("읽을 텍스트가 경로에 없습니다");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All File |*.*|Text|*.txt|Binary|*.bin";
            saveFileDialog.Title = "Save an Text File";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName != "")
            {
                if (saveFileDialog.FileName.Contains(".txt"))
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.Write(textBox1.Text);
                    }
                }
                else if (saveFileDialog.FileName.Contains(".bin"))
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, textBox1.Text);
                    }
                }
                else
                    MessageBox.Show("올바른 형식을 정해주세요");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All File|*|Text|*.txt";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ShowDialog();

            if(openFileDialog.FileName != "")
            {

                try
                {
                    if (openFileDialog.FileName.Contains(".txt"))
                    {
                        using (StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                        {
                            textBox1.Text = sr.ReadToEnd();
                        }
                    }
                    else if (openFileDialog.FileName.Contains(".bin"))
                    {
                        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                        {
                            textBox1.Text = "";
                            String result;

                            BinaryFormatter bf = new BinaryFormatter();
                            result = (string)bf.Deserialize(fs);
                            textBox1.Text = result;
                        }
                    }
                    else
                        throw new Exception();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("형식을 읽을수 없습니다");
                    MessageBox.Show(ex.ToString());

                    //예외처리 스택트레이스를 직렬화 저장
                    using (FileStream fs = new FileStream("../../../error.log", FileMode.Create))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, ex.ToString());
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using(FileStream fs = new FileStream("../../../Binary.bin", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, textBox1.Text);
                MessageBox.Show("텍스트가 바이너리로 파일에 저장되었습니다.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream("../../../Binary.bin", FileMode.Open))
                {
                    textBox1.Text = "";
                    string result;

                    BinaryFormatter bf = new BinaryFormatter();
                    result = (string)bf.Deserialize(fs);
                    textBox1.Text = result;
                    MessageBox.Show("바이너리를 모두 읽어왔습니다");
                }
            }
            catch
            {
                MessageBox.Show("경로에 바이너리파일이 없습니다");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Unchecked)
            {
                using (StreamWriter sw = new StreamWriter("../../../normal.txt"))
                {
                    sw.Write(textBox1.Text);
                    MessageBox.Show("일반저장 되었습니다");
                }
            }
            else if (checkBox1.CheckState == CheckState.Unchecked && checkBox2.CheckState == CheckState.Checked)
            {
                using (FileStream fs = new FileStream("../../../se.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, textBox1.Text);
                    MessageBox.Show("직렬화저장 되었습니다");
                }
            }
            else if (checkBox1.CheckState == CheckState.Unchecked && checkBox2.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("아무것도 선택 안하셨습니다");
            }
            //체크박스 둘다 되었을때
            else
            {
                //일반저장
                using (StreamWriter sw = new StreamWriter("../../../save.txt"))
                {
                    sw.Write(textBox1.Text);
                }

                //직렬화 저장
                using (FileStream fs = new FileStream("../../../Binary.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, textBox1.Text);
                }
                MessageBox.Show("둘다 저장 되었습니다");
            }

            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //일반읽기
            if(radioButton1.Checked)
            {
                textBox1.Text = "";

                try
                {
                    using (StreamReader sr = new StreamReader("../../../normal.txt"))
                    {
                        textBox1.Text = sr.ReadToEnd();
                        MessageBox.Show("파일을 읽었습니다");
                    }
                }
                catch
                {
                    MessageBox.Show("normal.txt가 경로에 없습니다");
                }
            }
            //역직렬화 읽기
            else if(radioButton2.Checked)
            {
                try
                {
                    using (FileStream fs = new FileStream("../../../se.bin", FileMode.Open))
                    {
                        textBox1.Text = "";
                        string result;

                        BinaryFormatter bf = new BinaryFormatter();
                        result = (string)bf.Deserialize(fs);
                        textBox1.Text = result;
                        MessageBox.Show("바이너리를 모두 읽어왔습니다");
                    }
                }
                catch
                {
                    MessageBox.Show("경로에 se.bin이 없습니다");
                }
            }
            else
                MessageBox.Show("아무것도 선택되지 않으셨습니다");

            radioButton1.Checked = false;
            radioButton2.Checked = false;


        }
    }
}
