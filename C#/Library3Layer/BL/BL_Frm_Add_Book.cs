﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
    public class BL_Frm_Add_Book: DataAccess
    {
        public string ISBN;
        public string Title;
        public int Subject;
        public string Writer;
        public string publisher;
        public string Year_Date;
        public int NumPage;
        public int Price;

        public DataTable Select()
        {
            base.Link();
            string Query = "select * from TB_Subject";
            DataTable Output_Q = base.SelectData(Query);
            base.UnLink();
            return Output_Q;
        }


        public void Add()
        {
            base.Link();
            string Query = "insert into TB_Book(ISBN, Title, Subject, Writer, publisher, Year_Date, NumPage, Price) values (N'{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', '{6}', '{7}')";
            Query = string.Format(Query, ISBN, Title, Subject, Writer, publisher, Year_Date, NumPage, Price);
            base.CommandTex(Query);
            base.UnLink();
        }
    }
}
