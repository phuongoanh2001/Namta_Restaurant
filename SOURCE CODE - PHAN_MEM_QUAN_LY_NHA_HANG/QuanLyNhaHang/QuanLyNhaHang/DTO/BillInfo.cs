﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int foodID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["MaTTHD"];
            this.BillID = (int)row["MaHD"];
            this.FoodID = (int)row["MaHH"];
            this.Count = (int)row["SoLuong"];
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int foodID;

        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

        private int billID;

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}