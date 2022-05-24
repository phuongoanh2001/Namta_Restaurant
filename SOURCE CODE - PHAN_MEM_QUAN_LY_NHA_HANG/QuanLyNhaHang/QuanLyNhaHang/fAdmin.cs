using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        //gọi foodList là một BindingSource mới => khi xem lại thông tin sẽ không thay đổi

        BindingSource accountList = new BindingSource();
        //gọi accountList là một BindingSource mới => khi xem lại thông tin sẽ không thay đổi

        public Account loginAccount;
        
        public fAdmin()
        {
            InitializeComponent();
            Load();
          
        }
        
        #region methods

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            //Name từ FoodDAO

            return listFood;
        }
        void Load()
        {
            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;

            LoadDateTimePickerBill();
            LoadListBillByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbPageBill.Text));
           
            LoadListFood();
            // thông tin table food
            LoadAccount();
            // thông tin bảng account
            LoadCategoryIntoCombobox(cbFoodCategory);
            AddFoodBinding();
            AddAccountBinding();
        }
        //Gọi tất cả hàm support bên dưới
        void AddAccountBinding()
        //Binding - các thuộc tính liên kết với nhau, khi 1 thuộc tính thay đổi, các thuộc tính khác cũng thay đổi theo
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "TenDN", true, DataSourceUpdateMode.Never));
            //Tạo dataBindings Textbox UserName kết nối thuộc tính Text và TenDN từ dtgvAccount trong DataSource
            //true, DataSourceUpdateMode.Never => không thay đổi giá trị của bảng khi type mà data chỉ thay đổi khi click button Addfood
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "TenHienThi", true, DataSourceUpdateMode.Never));
            txbAccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "LoaiTK", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDateAndPage(DateTime checkIn, DateTime checkOut, int pageNum)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDateAndPage(checkIn, checkOut, pageNum);
            //GetBillListByDate từ BillDAO
        }
        

        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            //GetListCategory từ CategoryDAO
            cb.DisplayMember = "Name";
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        void AddAccount(string userName, string displayName, string type)
        {
            string query = "select * from DANGNHAP where TenDN = '" + userName + "'";
            DataTable re = DataProvider.Instance.ExecuteQuery(query);
            if(re.Rows.Count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
                return;
            }
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
                
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, string type)
        {
            if (AccountDAO.Instance.UppdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
            
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        
        #endregion

        #region events
       
        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                    //Gán id (int) , chọn 1 ô đầu tiên, dòng của ô đó, giá trị tên của ô đó 

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbFoodCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbFoodCategory.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbFoodCategory.SelectedIndex = index;
                }
            }
            catch { }
        }
        //Chuyển đổi dữ liệu mã loại hàng hóa và tên của mã loại hàng hóa tương ứng khi binding (ex: 1-Pizza)
        //Binding các giá trị trong txbFoodID 
        

      
        

        #endregion              

        private void txbPageBill_TextChanged(object sender, EventArgs e)
        // Load thông tin theo trang lên danh sách mỗi trang chỉ tối da 10 bills
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbPageBill.Text));
        }

        
        

        private void btnViewBill_Click_1(object sender, EventArgs e)
        {
            LoadListBillByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbPageBill.Text));
        }

        private void btnAddFood_Click_1(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            //đặt biến name, categoryID theo từng chức năng tương ứng để type vào textbox 
            //categoryID gán ID từ lớp Category DTO
            string query = "select * from HANGHOA where TenHH = '" + name + "'";
            DataTable re = DataProvider.Instance.ExecuteQuery(query);
            if (re.Rows.Count > 0)
            {
                MessageBox.Show("Món này đã tồn tại");
                return;
            }
            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                //điều kiện trả về giá trị True
                LoadListFood();
                if (insertFood != null)
                    //Nếu thêm món thành công => update lại hóa đơn truy xuất EventArgs từ fTableManager - adminToolStripMenuItem
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }
        private void gunaGradientTileButton9_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteFood_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);
            
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                    //Nếu xóa món thành công => update lại hóa đơn truy xuất EventArgs từ fTableManager - adminToolStripMenuItem
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
            
            
        }
       



        // update hóa đơn khi thêm xóa sửa món trong admin mà không cần thoát màn hình
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void btnEditFood_Click_1(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void btnShowFood_Click_1(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void nmFoodPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchFood_Click_1(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbSearchFoodName.Text);
        }

        private void btnAddAccount_Click_1(object sender, EventArgs e)
        {
            
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            string type = txbAccountType.Text;

            AddAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click_1(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            DeleteAccount(userName);
        }
       
       
        

        
        private void btnShowAccount_Click_1(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFristBillPage1_Click(object sender, EventArgs e)
        //button trang đầu => txbPageBill chuyển về trang số 1
        {
            txbPageBill.Text = "1";
        }

        private void btnPrevioursBillPage1_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageBill.Text);

            if (page > 1)
                page--;

            txbPageBill.Text = page.ToString();
        }

        private void btnNextBillPage1_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageBill.Text);
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

            if (page < sumRecord)
                page++;

            txbPageBill.Text = page.ToString();
        }

        private void btnLastBillPage1_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumBillListByDate (dtpkFromDate.Value, dtpkToDate.Value);

            int lastPage = sumRecord / 10;

            if (sumRecord % 10 != 0)
                lastPage++;

            txbPageBill.Text = lastPage.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddEmployee_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimeEmployee_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nmFoodPrice_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void tpFood_Click(object sender, EventArgs e)
        {

        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            string type = txbAccountType.Text;
            EditAccount(userName, displayName, type);

        }

        private void dtgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}