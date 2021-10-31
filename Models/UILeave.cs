﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebOA.Models
{
    public class UILeave
    {
        public int ID
        {
            get; set;
        }
        public string LEAVE_NAME
        {
            get; set;
        }
        public int DEPART_ID
        {
            get; set;
        }
        public DateTime START_DATE
        {
            get; set;
        }
        public DateTime END_DATE
        {
            get; set;
        }
        public int LEAVE_TYPE
        {
            get; set;
        }
        public string REASONS
        {
            get; set;
        }
        public DateTime CHECK_DATE
        {
            get; set;
        }
        public int CHECK_FLAG
        {
            get; set;
        }
        public string CHECK_NAME
        {
            get; set;
        }
        public string REMARK
        {
            get; set;
        }
    }
}