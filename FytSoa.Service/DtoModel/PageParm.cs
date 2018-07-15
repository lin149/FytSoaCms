﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FytSoa.Service.DtoModel
{
    /// <summary>
    /// 分页参数
    /// </summary>
    public class PageParm
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int page { get; set; } = 0;

        /// <summary>
        /// 每页总条数
        /// </summary>
        public int limit { get; set; } = 15;

        /// <summary>
        /// 编号
        /// </summary>
        public string guid { get; set; }

        /// <summary>
        /// 搜索关键字
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// 类型条件
        /// </summary>
        public int types { get; set; } = 0;

        /// <summary>
        /// 搜索日期，可能是2个日期，通过-分隔
        /// </summary>
        public string time { get; set; }

        /// <summary>
        /// 排序方式，可根据数字来判断，
        /// </summary>
        public int orderType { get; set; } = 0;
    }

    public class AppSearchParm
    {
        public string btime { get; set; }
        public string etime { get; set; }
        public string brand { get; set; }
        public int saleType { get; set; } = 0;
        public int activityTypes { get; set; } = 0;
    }
}
