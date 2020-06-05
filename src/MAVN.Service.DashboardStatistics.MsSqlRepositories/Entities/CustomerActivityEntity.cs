﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MAVN.Service.DashboardStatistics.Domain.Enums;

namespace MAVN.Service.DashboardStatistics.MsSqlRepositories.Entities
{
    [Table("customer_activities")]
    public class CustomerActivityEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        
        [Required]
        [Column("customer_id")]
        public Guid CustomerId { get; set; }

        [Column("activity_date")]
        public DateTime ActivityDate { get; set; }

        [Column("partner_id")]
        public Guid? PartnerId { get; set; }

        [Column("activity_type")]
        public ActivityType? ActivityType { get; set; }
    }
}
