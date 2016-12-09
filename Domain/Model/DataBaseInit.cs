using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Domain.Model
{
    public class DataBaseInit : System.Data.Entity.CreateDatabaseIfNotExists<Entities>
    {
        protected override void Seed(Entities context)
        {
            //季节
            var sysSeasons = new List<Season>
            {
                new Season{ Name="春季"},
                new Season{ Name="夏季"},
                new Season{ Name="秋季"},
                new Season{ Name="冬季"}
            };
            foreach (var item in sysSeasons)
            {
                context.Seasons.Add(item);
            }

            //会员类型
            var sysMemberTypes = new List<MemberType>
            {
                new MemberType{ Name="普通会员",Profile="注册会员"},
                new MemberType{ Name="黄金会员",Profile="半年套餐会员"},
                new MemberType{ Name="钻石会员",Profile="年套餐会员"}
            };
            foreach (var item in sysMemberTypes)
            {
                context.MemberTypes.Add(item);
            }
            context.SaveChanges();

            //产品类型
            var sysProductTypes = new List<ProductType>
            {
                new ProductType{ Name="粗粮"},
                new ProductType{ Name="果蔬"}
            };
            foreach (var item in sysProductTypes)
            {
                context.ProductTypes.Add(item);
            }
            context.SaveChanges();

            var User = new User
            {
                Name = "admin",
                Password = "kangkai100",
                Type = 1
            };
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(User.Password));
            User.Password= System.Text.Encoding.Default.GetString(result);
            context.Users.Add(User);
            context.SaveChanges();
        }
    }
}