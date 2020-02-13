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
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            // DataTableにデータを追加する
            bookDataSet.bookDataTable.AddbookDataTableRow(
                this.bookName.Text,
                this.author.Text,
                int.Parse(this.price.Text)
                );
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            // 選択した行のデータを削除する
            if (this.bookDataGrid.CurrentRow != null)   // 選択した行がnullだとrowに数値を代入できなくてエラーが出る
            {
                int row = this.bookDataGrid.CurrentRow.Index;
                this.bookDataGrid.Rows.RemoveAt(row);
            }
        }
    }
}
