using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "도서관 관리";
            // 라벨 설정
            label5.Text = DataManager.Books.Count.ToString();
            label6.Text = DataManager.Users.Count.ToString();
            label7.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
            label8.Text = DataManager.Books.Where((x) =>
            {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now;
            }).Count().ToString();
            // 데이터 그리드 설정
            dataGridView1.DataSource = DataManager.Books;
            dataGridView2.DataSource = DataManager.Users;
            dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;
            dataGridView2.CurrentCellChanged += DataGridView2_CurrentCellChanged;

        }

        private void DataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {

            try
            {

                if (dataGridView1.CurrentRow != null)
                {
                    // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                    Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
                    textBox1.Text = book.Isbn;
                    textBox2.Text = book.Name;
                }
            }
            catch (Exception exception)
            {

            }
        }
        private void DataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentRow != null)
                {
                    // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                    User user = dataGridView2.CurrentRow.DataBoundItem as User;
                    textBox3.Text = user.Id.ToString();
                }

            }
            catch (Exception exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}
