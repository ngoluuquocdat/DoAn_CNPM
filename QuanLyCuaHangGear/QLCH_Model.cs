namespace QuanLyCuaHangGear
{
    using QuanLyCuaHangGear.DTO;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class QLCH_Model : DbContext
    {
        // Your context has been configured to use a 'QLCH_Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QuanLyCuaHangGear.QLCH_Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLCH_Model' 
        // connection string in the application configuration file.
        public QLCH_Model()
            : base("name=QLCH_Model")
        {
            Database.SetInitializer<QLCH_Model>(new CreateDB());
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonInfo> HoaDonInfoes { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}