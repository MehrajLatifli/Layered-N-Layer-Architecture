﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Radio_player._Entities.Concrete.DatabaseFirst;

public partial class RadioPlayer_DbContext : DbContext
{
    public RadioPlayer_DbContext()
    {
    }

    public RadioPlayer_DbContext(DbContextOptions<RadioPlayer_DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Radio> Radio { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost,1430;Initial Catalog=RadioPlayer_Db;User ID=sa;Password=admin1234@;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Radio>(entity =>
        {
            entity.HasKey(e => e.IdRadio).HasName("PK__Radio__B273BC990161A28C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}