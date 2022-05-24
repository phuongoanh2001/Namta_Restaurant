﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Table
    {
        public Table(int id, string name, string status)//hàm dựng
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public Table(DataRow row)
        //DataRow từ DataTable chuyển thành ListTable
        {
            this.ID = (int)row["MaBan"];
            this.Name = row["TenBan"].ToString();
            this.Status = row["TrangThai"].ToString();
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
