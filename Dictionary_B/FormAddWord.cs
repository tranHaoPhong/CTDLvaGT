using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dictionary_B.Form1;
namespace Dictionary_B
{
    public partial class FormAddWord : Form
    {
        public FormAddWord()
        {
            InitializeComponent();
            //Truyền dữ liệu vào combobox để người dùng dễ dàng nhập Kiểu từ
            cmbAddTypeWord.Items.Add("Động từ (v)");
            cmbAddTypeWord.Items.Add("Danh từ (n)");
            cmbAddTypeWord.Items.Add("Tính từ (adj)");
            cmbAddTypeWord.Items.Add("Trạng từ (adv)");
            cmbAddTypeWord.Items.Add("Giới từ (prep)");
            cmbAddTypeWord.Items.Add("Khác");
        }
        //Hàm sự kiện khi nhấn nút btnAddEdit
        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (txtAddWord.Text.Length != 0 && cmbAddTypeWord.SelectedItem.ToString().Length != 0 && txtAddDescription.Text.Length != 0 && txtAddExample.Text.Length != 0)
            {
                //kiểm tra các textbox, combobox liên quan đến thêm/sửa từ đã nhập hết hay chưa
                //Tạo một nút từ mới từ dữ liệu tại các textbox dùng cho việc thêm/sửa dữ liệu từ các textbox, combobox liên quan
                WordNode temp = new WordNode(txtAddWord.Text.ToLower(), cmbAddTypeWord.SelectedItem.ToString(), txtAddDescription.Text, txtAddExample.Text);
                //Sử dụng phương thức Add_Dictionary() của từ điển để thêm nút từ vừa tạo
                GlobalVariables.THONG_PHONG.Add_Dictionary(temp);
                //Làm trống các textbox, combobox dùng cho việc thêm/sửa dữ liệu từ
                txtAddWord.Clear();
                cmbAddTypeWord.SelectedIndex = -1;
                txtAddDescription.Clear();
                txtAddExample.Clear();
                //Sử dụng phương thức SaveFile() của từ điển để lưu lại dữ liệu từ điển mới
                GlobalVariables.THONG_PHONG.SaveFile(GlobalVariables.DictionaryPath);
                //Hiện thông báo đã thêm/sửa từ vào từ điển
                string message = string.Format("Đã thêm/sửa từ {0} vào từ điển", txtAddWord.Text);
                MessageBox.Show(message);
            }
            else
            {
                //Thông báo yêu cầu người dùng nhập hoàn chỉnh
                MessageBox.Show("Bạn chưa nhập hoàn chỉnh các ô !");
            }
        }
        //Hàm sự kiện khi txtAddWord nhận dữ liệu
        private void txtAddWord_TextChanged(object sender, EventArgs e)
        {
            if (txtAddWord.Text.Length != 0)
            {
                //kiểm tra dữ liệu thu được từ txtAddWord có hợp lệ hay không
                //Sử dụng phương thức Search_Dictionary() của từ điển để tìm và trả về giá trị tại nút từ temp
                WordNode temp = GlobalVariables.THONG_PHONG.Search_Dictionary(txtAddWord.Text);
                if (temp != null)
                {
                    //nếu tìm thấy
                    //Làm trống các textbox liên quan đến việc thêm/sửa từ
                    txtAddDescription.Clear();
                    txtAddExample.Clear();
                    //Ghi dữ liệu của temp lên txtAddDescription, txtAddExample
                    txtAddDescription.Text = temp.Description;
                    txtAddExample.Text = temp.Example;
                    //Chọn chỉ mục cho combobox có trùng dữ liệu với temp.TypeWord
                    for (int i = 0; i < cmbAddTypeWord.Items.Count; i++)
                    {
                        if (cmbAddTypeWord.Items[i].ToString() == temp.TypeWord)
                        {
                            cmbAddTypeWord.SelectedIndex = i;
                            break;
                        }
                    }

                }
                else
                {
                    cmbAddTypeWord.SelectedIndex = -1;
                    txtAddDescription.Clear();
                    txtAddExample.Clear();
                }
            }
        }
    }
}
