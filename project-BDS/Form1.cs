using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_BDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<User> userList = new List<User>();
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (checkdatabox())
            {
                string filePath = "";
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName;
                }
                try
                {
                    var package = new ExcelPackage(new FileInfo(filePath));

                    // lấy ra sheet đầu tiên để thao tác
                    ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

                    try
                    {
                        for (int i = workSheet.Dimension.Start.Row + 2; i <= workSheet.Dimension.End.Row; i++)
                        {
                            try
                            {
                                // biến j biểu thị cho một column trong file
                                int j = 1;

                                // lấy ra cột họ tên tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 2
                                // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh

                                // lấy ra cột ngày sinh tương ứng giá trị tại vị trí [i, 2]. i lần đầu là 2
                                // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                                // lấy ra giá trị ngày tháng và ép kiểu thành DateTime  
                                int hoten = Convert.ToInt32(txtHoten.Text);
                                int sdt = Convert.ToInt32(txtSDT.Text);
                                int tp = Convert.ToInt32(txtTP.Text);

                                string fullname = workSheet.Cells[i, hoten].Value == null ? string.Empty : workSheet.Cells[i, hoten].Value.ToString();
                                string province = workSheet.Cells[i, tp].Value == null ? string.Empty : workSheet.Cells[i, tp].Value.ToString();
                                string phone = workSheet.Cells[i, sdt].Value == null ? string.Empty : workSheet.Cells[i, sdt].Value.ToString();

                                // tạo UserInfo từ dữ liệu đã lấy được
                                User user = new User(fullname, province, phone);

                                // add UserInfo vào danh sách userList
                                userList.Add(user);
                            }
                            catch (Exception exe)
                            {
                                MessageBox.Show("Lỗi" + exe);
                            }
                        }
                    }
                    catch (Exception eee)
                    {
                        MessageBox.Show("Loi");
                    }
                    btnImport.Enabled = false;
                    txtHoten.Enabled = false;
                    txtSDT.Enabled = false;
                    txtTP.Enabled = false;
                    MessageBox.Show("Nếu chọn nhầm kiểu dữ liệu vui lòng tắt ứng dụng và chạy lại");
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn tệp khác !");
                }
            }
            else
            {

            }
            if (userList.Count > 0)
            {
                dtgExcel.DataSource = userList;
            }
            lblTong.Text = $"Tổng cộng có {userList.Count} khách hàng";
            if (userList.Count > 0)
            {
                btnExport.Enabled = true;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Text | *.txt";
            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine($"Đây là danh sách các số điện thoại của các khách hàng ở: {txtDinhDangTP.Text} có {DemUserTP()} khách hàng");
                    for (int j = 0; j < userList.Count; j++)
                    {
                        if (userList[j].checkAdress(txtDinhDangTP.Text))
                        {
                            if (string.Compare(cboKieusdt.Text, "Đầu 84") == 0)
                            {

                                string str = $"84{userList[j].newphone(cboDinhDangsdt.Text).Substring(1)}";
                                sw.WriteLine(str);
                            }
                            else
                            {
                                sw.WriteLine($"{userList[j].newphone(cboDinhDangsdt.Text)} ");
                            }
                        }
                    }
                }
                MessageBox.Show("Đã lưu tất cả sdt vào file theo đường dẫn yêu cầu", "Thông báo");
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Bạn đã làm sai thao tác nào đó, vui lòng tắt ứng dụng và chạy lại !", "Thông báo");
            }
        }
        public bool checkdatabox()
        {
            try
            {
                int hoten = Convert.ToInt32(txtHoten.Text);
                int sdt = Convert.ToInt32(txtSDT.Text);
                int tp = Convert.ToInt32(txtTP.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập dữ liệu số vào các ô dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoten.Text = "";
                txtSDT.Text = "";
                txtTP.Text = "";
                return false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtgExcel.DataSource = null;
            btnExport.Enabled = false;
            cboDinhDangsdt.Items.Add("+84 xxxxxxxxx");
            cboDinhDangsdt.Items.Add("xxx xxx xxxx");
            cboDinhDangsdt.Items.Add("xxxx xxx xxx");
            cboDinhDangsdt.SelectedIndex = 0;
            cboKieusdt.Items.Add("Đầu 84");
            cboKieusdt.Items.Add("Đầu 0");
            cboKieusdt.SelectedIndex = 1;
        }
        public int DemUserTP()
        {
            int dem = 0;
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].checkAdress(txtDinhDangTP.Text))
                {
                    dem++;
                }
            }
            return dem;
        }


    }
}