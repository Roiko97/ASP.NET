using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Users
    {
        private int id { get; set; }
        private string email { get; set; }
        private string name { get; set; }
        private string password { get; set; }
        private string avatar { get; set; } //头像地址
        private int mark { get; set; } //组号 默认情况下数据库里为-1，代表没有小组
        private int states { get; set; } //状态 默认情况下是1代表有效，0代表该状态已被锁定
        private string position { get; set; } //用户职责

    }
}