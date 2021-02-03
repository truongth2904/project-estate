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
            // tạo ra danh sách UserInfo rỗng để hứng dữ liệu.
            try
            {
                // mở file excel
                string filePath = "";
                // tạo SaveFileDialog để lưu file excel
                SaveFileDialog dialog = new SaveFileDialog();

                // chỉ lọc ra các file có định dạng Excel
                //dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

                // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName;
                }

                //MessageBox.Show(filePath);
                var package = new ExcelPackage(new FileInfo(filePath));

                // lấy ra sheet đầu tiên để thao tác
                ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

                // duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file. lưu ý file excel bắt đầu từ số 1 không phải số 0
                for (int i = workSheet.Dimension.Start.Row + 2; i <= workSheet.Dimension.End.Row; i++)
                {
                    try
                    {
                        // biến j biểu thị cho một column trong file
                        int j = 1;

                        // lấy ra cột họ tên tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 2
                        // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                        string id = workSheet.Cells[i, j++].Value.ToString();

                        // lấy ra cột ngày sinh tương ứng giá trị tại vị trí [i, 2]. i lần đầu là 2
                        // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                        // lấy ra giá trị ngày tháng và ép kiểu thành DateTime                      
                        string title = workSheet.Cells[i, j++].Value.ToString();
                        string fullname = workSheet.Cells[i, j++].Value.ToString();
                        string address = workSheet.Cells[i, j++].Value.ToString();
                        string no = workSheet.Cells[i, j++].Value.ToString();
                        string province = workSheet.Cells[i, j++].Value.ToString();
                        string country = workSheet.Cells[i, j++].Value.ToString();
                        string phone = workSheet.Cells[i, j++].Value.ToString();


                        // tạo UserInfo từ dữ liệu đã lấy được
                        User user = new User(id, title, fullname, address, province, country, phone);

                        // add UserInfo vào danh sách userList
                        userList.Add(user);

                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show("Lỗi khi lấy đường dẫn");
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error!" + ee);
            }

            dtgExcel.DataSource = userList;
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
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Đây là danh sách các số điện thoại của các khách hàng ở tp hcm");
                for (int j = 0; j < userList.Count; j++)
                {
                    if (userList[j].checkAdress())
                    {
                        sw.WriteLine($"{userList[j].Phone}");
                    }
                }
            }
            MessageBox.Show("Đã lưu tất cả sdt vào file theo đường dẫn yêu cầu");
        }
    }
}
