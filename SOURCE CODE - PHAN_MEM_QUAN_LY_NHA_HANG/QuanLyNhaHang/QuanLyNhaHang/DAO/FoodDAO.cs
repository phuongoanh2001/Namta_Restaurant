using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null)instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from HANGHOA where MaLHH = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "select * from HANGHOA";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> SearchFoodByName(string name)
        {                     

            List<Food> list = new List<Food>();

            string query = string.Format("SELECT * FROM dbo.HANGHOA WHERE dbo.fuConvertToUnsign1(TenHH) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            // % - lấy một trong các ký tự trong chuỗi 
            // các ký tự có dấu được hỗ trợ từ hàm trong sql - CREATE FUNCTION [dbo].[fuConvertToUnsign1] - chức năng tìm kiếm 

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public bool InsertFood(string name, int id, float price)
        {
            string query = string.Format("INSERT dbo.HANGHOA ( TenHH, MaLHH, DonGia )VALUES  ( N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFood(int idFood, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.HANGHOA SET TenHH = N'{0}', MaLHH = {1}, DonGia = {2} WHERE MaHH = {3}", name, id, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFood(int idFood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);
            //xóa món trong BillInfo trước khi xóa món trong danh sách 
            //update lại BillInfo khi xóa món đó ra khỏi bill từ sql TRIGGER UTG_UpdateBillInfo

            string query = string.Format("Delete HANGHOA where MaHH = {0}",idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
            
        }
        public bool reset(int index)
        {
            string query = string.Format("DBCC CHECKIDENT('dbo.HANGHOA', RESEED, {0})", index);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
