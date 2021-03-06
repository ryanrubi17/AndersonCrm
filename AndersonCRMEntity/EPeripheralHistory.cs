﻿using BaseEntity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonCRMEntity
{
    [Table("PeripheralHistory")]
    public class EPeripheralHistory : EBase
    {
        public DateTime DateAssigned { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PeripheralHistoryId { get; set; }
        [ForeignKey("Peripheral")]
        public int PeripheralId { get; set; }

        public virtual EEmployee Employee { get; set; }
        public virtual EPeripheral Peripheral { get; set; }
    }
}