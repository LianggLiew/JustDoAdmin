using Microsoft.EntityFrameworkCore;
using WebApplicationTest.Models;

namespace WebApplicationTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // 添加一些示例数据
             modelBuilder.Entity<Product>().HasData(
                 // 原有20个产品数据
                 new Product { Id = 1, Name = "笔记本电脑", Description = "高性能商务笔记本", Price = 5999.00M, Stock = 50, CreatedDate = DateTime.Now.AddDays(-30) },
                 new Product { Id = 2, Name = "智能手机", Description = "最新款智能手机", Price = 3999.00M, Stock = 100, CreatedDate = DateTime.Now.AddDays(-25) },
                 new Product { Id = 3, Name = "平板电脑", Description = "轻薄便携平板", Price = 2999.00M, Stock = 30, CreatedDate = DateTime.Now.AddDays(-20) },
                 new Product { Id = 4, Name = "智能手表", Description = "多功能智能手表", Price = 1299.00M, Stock = 80, CreatedDate = DateTime.Now.AddDays(-15) },
                 new Product { Id = 5, Name = "无线耳机", Description = "降噪无线耳机", Price = 899.00M, Stock = 120, CreatedDate = DateTime.Now.AddDays(-10) },
                 new Product { Id = 6, Name = "智能音箱", Description = "AI智能音箱", Price = 599.00M, Stock = 60, CreatedDate = DateTime.Now.AddDays(-5) },
                 new Product { Id = 7, Name = "电子书阅读器", Description = "墨水屏电子书", Price = 999.00M, Stock = 40, CreatedDate = DateTime.Now.AddDays(-4) },
                 new Product { Id = 8, Name = "游戏主机", Description = "高性能游戏主机", Price = 3499.00M, Stock = 25, CreatedDate = DateTime.Now.AddDays(-3) },
                 new Product { Id = 9, Name = "数码相机", Description = "高清数码相机", Price = 4299.00M, Stock = 15, CreatedDate = DateTime.Now.AddDays(-2) },
                 new Product { Id = 10, Name = "蓝牙音箱", Description = "便携蓝牙音箱", Price = 399.00M, Stock = 90, CreatedDate = DateTime.Now.AddDays(-1) },
                 new Product { Id = 11, Name = "机械键盘", Description = "游戏机械键盘", Price = 499.00M, Stock = 70, CreatedDate = DateTime.Now },
                 new Product { Id = 12, Name = "显示器", Description = "4K高清显示器", Price = 1999.00M, Stock = 35, CreatedDate = DateTime.Now },
                 new Product { Id = 13, Name = "路由器", Description = "高速WiFi6路由器", Price = 799.00M, Stock = 55, CreatedDate = DateTime.Now },
                 new Product { Id = 14, Name = "移动硬盘", Description = "1TB移动硬盘", Price = 499.00M, Stock = 85, CreatedDate = DateTime.Now },
                 new Product { Id = 15, Name = "打印机", Description = "彩色喷墨打印机", Price = 1299.00M, Stock = 20, CreatedDate = DateTime.Now },
                 new Product { Id = 16, Name = "投影仪", Description = "家用高清投影仪", Price = 2999.00M, Stock = 10, CreatedDate = DateTime.Now },
                 new Product { Id = 17, Name = "电动牙刷", Description = "声波电动牙刷", Price = 299.00M, Stock = 110, CreatedDate = DateTime.Now },
                 new Product { Id = 18, Name = "智能门锁", Description = "指纹智能门锁", Price = 1599.00M, Stock = 25, CreatedDate = DateTime.Now },
                 new Product { Id = 19, Name = "扫地机器人", Description = "自动扫地机器人", Price = 1999.00M, Stock = 30, CreatedDate = DateTime.Now },
                 new Product { Id = 20, Name = "空气净化器", Description = "家用空气净化器", Price = 1499.00M, Stock = 40, CreatedDate = DateTime.Now },
        //         // 新增30个产品数据
                 new Product { Id = 21, Name = "电饭煲", Description = "智能多功能电饭煲", Price = 699.00M, Stock = 45, CreatedDate = DateTime.Now.AddDays(-2) },
                 new Product { Id = 22, Name = "微波炉", Description = "家用变频微波炉", Price = 899.00M, Stock = 30, CreatedDate = DateTime.Now.AddDays(-3) },
                 new Product { Id = 23, Name = "洗衣机", Description = "滚筒全自动洗衣机", Price = 2599.00M, Stock = 15, CreatedDate = DateTime.Now.AddDays(-4) },
                 new Product { Id = 24, Name = "冰箱", Description = "双门对开冰箱", Price = 3299.00M, Stock = 10, CreatedDate = DateTime.Now.AddDays(-5) },
                 new Product { Id = 25, Name = "吸尘器", Description = "无线手持吸尘器", Price = 1299.00M, Stock = 25, CreatedDate = DateTime.Now.AddDays(-6) },
                 new Product { Id = 26, Name = "电视机", Description = "4K智能液晶电视", Price = 3999.00M, Stock = 20, CreatedDate = DateTime.Now.AddDays(-7) },
                 new Product { Id = 27, Name = "加湿器", Description = "静音家用加湿器", Price = 299.00M, Stock = 60, CreatedDate = DateTime.Now.AddDays(-8) },
                 new Product { Id = 28, Name = "电热水壶", Description = "不锈钢保温电水壶", Price = 199.00M, Stock = 75, CreatedDate = DateTime.Now.AddDays(-9) },
                 new Product { Id = 29, Name = "咖啡机", Description = "全自动咖啡机", Price = 1599.00M, Stock = 18, CreatedDate = DateTime.Now.AddDays(-10) },
                 new Product { Id = 30, Name = "榨汁机", Description = "家用多功能榨汁机", Price = 399.00M, Stock = 40, CreatedDate = DateTime.Now.AddDays(-11) },
                 new Product { Id = 31, Name = "电动剃须刀", Description = "智能感应剃须刀", Price = 599.00M, Stock = 55, CreatedDate = DateTime.Now.AddDays(-12) },
                 new Product { Id = 32, Name = "电烤箱", Description = "家用多功能电烤箱", Price = 799.00M, Stock = 22, CreatedDate = DateTime.Now.AddDays(-13) },
                 new Product { Id = 33, Name = "电磁炉", Description = "智能触控电磁炉", Price = 499.00M, Stock = 35, CreatedDate = DateTime.Now.AddDays(-14) },
                 new Product { Id = 34, Name = "电风扇", Description = "静音落地电风扇", Price = 299.00M, Stock = 48, CreatedDate = DateTime.Now.AddDays(-15) },
                 new Product { Id = 35, Name = "空调", Description = "变频冷暖空调", Price = 2999.00M, Stock = 12, CreatedDate = DateTime.Now.AddDays(-16) },
                 new Product { Id = 36, Name = "热水器", Description = "即热式电热水器", Price = 1899.00M, Stock = 15, CreatedDate = DateTime.Now.AddDays(-17) },
                 new Product { Id = 37, Name = "电动牙刷替换头", Description = "电动牙刷替换刷头4支装", Price = 99.00M, Stock = 150, CreatedDate = DateTime.Now.AddDays(-18) },
                 new Product { Id = 38, Name = "智能体重秤", Description = "蓝牙连接智能体重秤", Price = 199.00M, Stock = 65, CreatedDate = DateTime.Now.AddDays(-19) },
                 new Product { Id = 39, Name = "电动按摩椅", Description = "全身多功能按摩椅", Price = 4999.00M, Stock = 8, CreatedDate = DateTime.Now.AddDays(-20) },
                 new Product { Id = 40, Name = "面包机", Description = "家用全自动面包机", Price = 699.00M, Stock = 28, CreatedDate = DateTime.Now.AddDays(-21) },
                 new Product { Id = 41, Name = "电动晾衣架", Description = "智能遥控电动晾衣架", Price = 899.00M, Stock = 18, CreatedDate = DateTime.Now.AddDays(-22) },
                 new Product { Id = 42, Name = "智能门铃", Description = "无线可视智能门铃", Price = 399.00M, Stock = 42, CreatedDate = DateTime.Now.AddDays(-23) },
                 new Product { Id = 43, Name = "智能窗帘", Description = "自动遥控智能窗帘", Price = 799.00M, Stock = 25, CreatedDate = DateTime.Now.AddDays(-24) },
                 new Product { Id = 44, Name = "智能马桶盖", Description = "自动加热智能马桶盖", Price = 1299.00M, Stock = 20, CreatedDate = DateTime.Now.AddDays(-25) },
                 new Product { Id = 45, Name = "电动剪草机", Description = "家用小型电动剪草机", Price = 599.00M, Stock = 15, CreatedDate = DateTime.Now.AddDays(-26) },
                 new Product { Id = 46, Name = "电动螺丝刀", Description = "充电式电动螺丝刀", Price = 199.00M, Stock = 60, CreatedDate = DateTime.Now.AddDays(-27) },
                 new Product { Id = 47, Name = "智能灯泡", Description = "WiFi智能彩色灯泡", Price = 99.00M, Stock = 80, CreatedDate = DateTime.Now.AddDays(-28) },
                 new Product { Id = 48, Name = "智能插座", Description = "远程控制智能插座", Price = 129.00M, Stock = 70, CreatedDate = DateTime.Now.AddDays(-29) },
                 new Product { Id = 49, Name = "电动牙线器", Description = "便携式电动牙线器", Price = 159.00M, Stock = 45, CreatedDate = DateTime.Now.AddDays(-30) },
                 new Product { Id = 50, Name = "智能手环", Description = "健康监测智能手环", Price = 299.00M, Stock = 55, CreatedDate = DateTime.Now.AddDays(-31) }
             );
        }
    }
}