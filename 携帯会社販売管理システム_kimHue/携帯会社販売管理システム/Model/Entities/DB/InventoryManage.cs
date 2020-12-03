namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InventoryManage : DbContext
    {
        public InventoryManage()
            : base("name=InventoryManage")
        {
        }

        public virtual DbSet<M_Client> M_Client { get; set; }
        public virtual DbSet<M_Employee> M_Employee { get; set; }
        public virtual DbSet<M_Maker> M_Maker { get; set; }
        public virtual DbSet<M_Position> M_Position { get; set; }
        public virtual DbSet<M_Product> M_Product { get; set; }
        public virtual DbSet<M_SalesOffice> M_SalesOffice { get; set; }
        public virtual DbSet<T_Arrival> T_Arrival { get; set; }
        public virtual DbSet<T_ArrivalDetail> T_ArrivalDetail { get; set; }
        public virtual DbSet<T_Hacchu> T_Hacchu { get; set; }
        public virtual DbSet<T_HacchuDetail> T_HacchuDetail { get; set; }
        public virtual DbSet<T_LoginHistory> T_LoginHistory { get; set; }
        public virtual DbSet<T_Order> T_Order { get; set; }
        public virtual DbSet<T_OrderDetail> T_OrderDetail { get; set; }
        public virtual DbSet<T_Sale> T_Sale { get; set; }
        public virtual DbSet<T_SaleDetail> T_SaleDetail { get; set; }
        public virtual DbSet<T_Shipment> T_Shipment { get; set; }
        public virtual DbSet<T_ShipmentDetail> T_ShipmentDetail { get; set; }
        public virtual DbSet<T_Stock> T_Stock { get; set; }
        public virtual DbSet<T_Syukko> T_Syukko { get; set; }
        public virtual DbSet<T_SyukkoDetails> T_SyukkoDetails { get; set; }
        public virtual DbSet<T_Warehousing> T_Warehousing { get; set; }
        public virtual DbSet<T_WarehousingDetails> T_WarehousingDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<M_Client>()
                .Property(e => e.ClID)
                .IsFixedLength();

            modelBuilder.Entity<M_Client>()
                .Property(e => e.ClPnumber)
                .IsFixedLength();

            modelBuilder.Entity<M_Client>()
                .Property(e => e.ClPostal)
                .IsFixedLength();

            modelBuilder.Entity<M_Client>()
                .Property(e => e.ClEmail)
                .IsFixedLength();

            modelBuilder.Entity<M_Client>()
                .Property(e => e.ClFax)
                .IsFixedLength();

            modelBuilder.Entity<M_Client>()
                .Property(e => e.EmID)
                .IsFixedLength();

            modelBuilder.Entity<M_Employee>()
                .Property(e => e.EmID)
                .IsFixedLength();

            modelBuilder.Entity<M_Employee>()
                .Property(e => e.Passwork)
                .IsFixedLength();

            modelBuilder.Entity<M_Employee>()
                .Property(e => e.EmPnumber)
                .IsFixedLength();

            modelBuilder.Entity<M_Maker>()
                .Property(e => e.MaID)
                .IsFixedLength();

            modelBuilder.Entity<M_Maker>()
                .Property(e => e.MaPhone)
                .IsFixedLength();

            modelBuilder.Entity<M_Maker>()
                .Property(e => e.MaPostal)
                .IsFixedLength();

            modelBuilder.Entity<M_Maker>()
                .Property(e => e.MaFAX)
                .IsFixedLength();

            modelBuilder.Entity<M_Position>()
                .HasMany(e => e.M_Employee)
                .WithOptional(e => e.M_Position)
                .HasForeignKey(e => e.SOID);

            modelBuilder.Entity<M_Product>()
                .Property(e => e.PrID)
                .IsFixedLength();

            modelBuilder.Entity<M_Product>()
                .Property(e => e.PrTotal)
                .IsFixedLength();

            modelBuilder.Entity<M_Product>()
                .Property(e => e.PrCode)
                .IsFixedLength();

            modelBuilder.Entity<M_SalesOffice>()
                .Property(e => e.SOPnumber)
                .IsFixedLength();

            modelBuilder.Entity<M_SalesOffice>()
                .Property(e => e.SOPost)
                .IsFixedLength();

            modelBuilder.Entity<M_SalesOffice>()
                .Property(e => e.SOFax)
                .IsFixedLength();

            modelBuilder.Entity<T_Arrival>()
                .Property(e => e.ArID)
                .IsFixedLength();

            modelBuilder.Entity<T_Arrival>()
                .Property(e => e.EmID)
                .IsFixedLength();

            modelBuilder.Entity<T_Arrival>()
                .Property(e => e.ClID)
                .IsFixedLength();

            modelBuilder.Entity<T_Arrival>()
                .Property(e => e.OrID)
                .IsFixedLength();

            modelBuilder.Entity<T_ArrivalDetail>()
                .Property(e => e.ArDetailID)
                .IsFixedLength();

            modelBuilder.Entity<T_ArrivalDetail>()
                .Property(e => e.ArID)
                .IsFixedLength();

            modelBuilder.Entity<T_ArrivalDetail>()
                .Property(e => e.PrID)
                .IsFixedLength();

            modelBuilder.Entity<T_Hacchu>()
                .Property(e => e.HaID)
                .IsFixedLength();

            modelBuilder.Entity<T_Hacchu>()
                .Property(e => e.MaID)
                .IsFixedLength();

            modelBuilder.Entity<T_Hacchu>()
                .Property(e => e.EmID)
                .IsFixedLength();

            modelBuilder.Entity<T_HacchuDetail>()
                .Property(e => e.HaDetailID)
                .IsFixedLength();

            modelBuilder.Entity<T_HacchuDetail>()
                .Property(e => e.HaID)
                .IsFixedLength();

            modelBuilder.Entity<T_HacchuDetail>()
                .Property(e => e.PrID)
                .IsFixedLength();

            modelBuilder.Entity<T_LoginHistory>()
                .Property(e => e.EmID)
                .IsFixedLength();

            modelBuilder.Entity<T_Order>()
                .Property(e => e.OrID)
                .IsFixedLength();

            modelBuilder.Entity<T_Order>()
                .Property(e => e.EmID)
                .IsFixedLength();

            modelBuilder.Entity<T_Order>()
                .Property(e => e.ClID)
                .IsFixedLength();

            modelBuilder.Entity<T_OrderDetail>()
                .Property(e => e.OrDerailID)
                .IsFixedLength();

            modelBuilder.Entity<T_OrderDetail>()
                .Property(e => e.OrID)
                .IsFixedLength();

            modelBuilder.Entity<T_OrderDetail>()
                .Property(e => e.PrID)
                .IsFixedLength();

            modelBuilder.Entity<T_Sale>()
                .Property(e => e.SaID)
                .IsFixedLength();

            modelBuilder.Entity<T_Sale>()
                .Property(e => e.ClID)
                .IsFixedLength();

            modelBuilder.Entity<T_Sale>()
                .Property(e => e.EmID)
                .IsFixedLength();

            modelBuilder.Entity<T_Sale>()
                .Property(e => e.OrID)
                .IsFixedLength();

            modelBuilder.Entity<T_SaleDetail>()
                .Property(e => e.SaDetailID)
                .IsFixedLength();

            modelBuilder.Entity<T_SaleDetail>()
                .Property(e => e.SaID)
                .IsFixedLength();

            modelBuilder.Entity<T_SaleDetail>()
                .Property(e => e.PrID)
                .IsFixedLength();

            modelBuilder.Entity<T_Shipment>()
                .Property(e => e.ShID)
                .IsFixedLength();

            modelBuilder.Entity<T_Shipment>()
                .Property(e => e.OrID)
                .IsFixedLength();

            modelBuilder.Entity<T_ShipmentDetail>()
                .Property(e => e.ShDetailID)
                .IsFixedLength();

            modelBuilder.Entity<T_ShipmentDetail>()
                .Property(e => e.ShID)
                .IsFixedLength();

            modelBuilder.Entity<T_ShipmentDetail>()
                .Property(e => e.PrID)
                .IsFixedLength();

            modelBuilder.Entity<T_Stock>()
                .Property(e => e.PrID)
                .IsFixedLength();

            modelBuilder.Entity<T_Stock>()
                .HasOptional(e => e.M_Product)
                .WithRequired(e => e.T_Stock);

            modelBuilder.Entity<T_Syukko>()
                .Property(e => e.SyID)
                .IsFixedLength();

            modelBuilder.Entity<T_Syukko>()
                .Property(e => e.EmID)
                .IsFixedLength();

            modelBuilder.Entity<T_Syukko>()
                .Property(e => e.ClID)
                .IsFixedLength();

            modelBuilder.Entity<T_Syukko>()
                .Property(e => e.OrID)
                .IsFixedLength();

            modelBuilder.Entity<T_SyukkoDetails>()
                .Property(e => e.SyDID)
                .IsFixedLength();

            modelBuilder.Entity<T_SyukkoDetails>()
                .Property(e => e.PrID)
                .IsFixedLength();

            modelBuilder.Entity<T_SyukkoDetails>()
                .Property(e => e.SyID)
                .IsFixedLength();

            modelBuilder.Entity<T_Warehousing>()
                .Property(e => e.WaID)
                .IsFixedLength();

            modelBuilder.Entity<T_Warehousing>()
                .Property(e => e.HaID)
                .IsFixedLength();

            modelBuilder.Entity<T_Warehousing>()
                .Property(e => e.EmID)
                .IsFixedLength();

            modelBuilder.Entity<T_Warehousing>()
                .Property(e => e.WaHidden)
                .IsFixedLength();

            modelBuilder.Entity<T_WarehousingDetails>()
                .Property(e => e.WDID)
                .IsFixedLength();

            modelBuilder.Entity<T_WarehousingDetails>()
                .Property(e => e.WaID)
                .IsFixedLength();

            modelBuilder.Entity<T_WarehousingDetails>()
                .Property(e => e.PrID)
                .IsFixedLength();

            modelBuilder.Entity<T_WarehousingDetails>()
                .Property(e => e.EmID)
                .IsFixedLength();
        }
    }
}
