using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
//thư viện MP5 mã hóa
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class AccountDAO
    {
        // cấu tạo symbathon
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }
        
        public bool Login(string userName, string passWord)
        ///đặt biến userName và passWord từ Login
        {

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            /// tạo mảng temp, kiểu byte, mảng chứa các ký tự trong passWord
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            /// tạo mảng hasData, kiểu byte, mảng chứa các ký tự đã mã hóa từ mảng temp
            string hasPass = "";
            /// tạo mảng hasPass với các ký tự kiểu string 
            foreach (byte item in hasData)
            ///Câu lệnh lặp lấy item từ hasData
            {
                hasPass += item;
                ///Mảng hasPass = hasPass+item
            }
            //var list = hasData.ToString();
            //list.Reverse();

            string query = "USP_Login @userName , @passWord";
            ///mở dãy ký tự đã mã hóa trong mảng hasPass
            ///string query = "USP_Login @userName , @passWord";
            ///insertbreakpoint => debug => type userName & PassWord => click Đăng nhập 
            ///hasPass

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hasPass /*list*/});
            //ExecuteNonQuery trả ra dòng kết quả 
            return result.Rows.Count > 0;//số dòng trả ra lớn hơn 0
        }

       

        public DataTable GetListAccount()
        //List lấy thông tin không bao gồm mật khẩu 
        {
            return DataProvider.Instance.ExecuteQuery("SELECT TenDN, TenHienThi, LoaiTK FROM dbo.DANGNHAP");
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from DANGNHAP where TenDN = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            //dữ liệu dòng 
            {
                return new Account(item);
            }

            return null;
            //trả ra null
        }

        public bool InsertAccount(string name, string displayName, string type)
        {
            string query = string.Format("INSERT dbo.DANGNHAP ( TenDN, TenHienThi, LoaiTK, MatKhau )VALUES  ( N'{0}', N'{1}', N'{2}', N'{3}')", name, displayName, type, "1962026656160185351301320480154111117132155");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UppdateAccount(string name, string displayName, string type)
        {
            string query = string.Format("UPDATE dbo.DANGNHAP SET TenHienThi = N'{1}', LoaiTK = N'{2}' WHERE TenDN = N'{0}'", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;






        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete DANGNHAP where TenDN = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        
    }
}