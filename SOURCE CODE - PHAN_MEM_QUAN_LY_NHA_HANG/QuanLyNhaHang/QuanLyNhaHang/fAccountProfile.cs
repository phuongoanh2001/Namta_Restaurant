using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txbUserName.Text = LoginAccount.UserName;
            //txbDisplayName.Text = LoginAccount.DisplayName;
        }

       

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        




        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            
            //string displayName = txbDisplayName.Text;
            string password = txbPassWord.Text;
            string newpass = txbNewPass.Text.Trim();
            string reenterPass = txbReEnterPass.Text.Trim();
            string userName = txbUserName.Text;
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            // tạo mảng temp, kiểu byte, mảng chứa các ký tự trong passWord
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            // tạo mảng hasData, kiểu byte, mảng chứa các ký tự đã mã hóa từ mảng temp
            string hasPass = "";
            // tạo mảng hasPass với các ký tự kiểu string 
            foreach (byte item in hasData)
            //Câu lệnh lặp lấy item từ hasData
            {
                hasPass += item;
                ///Mảng hasPass = hasPass+item
            }
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hasPass /*list*/});
            if(result.Rows.Count == 0)
            {
                MessageBox.Show("Error", "Bạn nhập sai mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            byte[] temp1 = ASCIIEncoding.ASCII.GetBytes(newpass);
            // tạo mảng temp, kiểu byte, mảng chứa các ký tự trong passWord
            byte[] hasData1 = new MD5CryptoServiceProvider().ComputeHash(temp1);
            // tạo mảng hasData, kiểu byte, mảng chứa các ký tự đã mã hóa từ mảng temp
            string hasNewPass = "";
            //tạo mảng hasPass với các ký tự kiểu string 
            foreach (byte item1 in hasData1)
            //Câu lệnh lặp lấy item từ hasData
            {
                hasNewPass += item1;
                //Mảng hasPass = hasPass+item
            }
            string a = hasNewPass;
            
            if ( newpass == "" )
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!");
                return;
            }
            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
                return;
            }
            
            string k = "update DANGNHAP set MatKhau = '" + hasNewPass + "' where TenDN = '" + userName + "'";
            DataTable result1 = DataProvider.Instance.ExecuteQuery(k);
            MessageBox.Show("Cập nhật thành công");

        }

        private void btnExti_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbReEnterPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientTileButton8_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientTileButton2_Click(object sender, EventArgs e)
        {

        }
    }

    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
