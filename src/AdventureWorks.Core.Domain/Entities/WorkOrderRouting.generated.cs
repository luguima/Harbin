﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using AdventureWorks.Core.Domain.Entities;

namespace AdventureWorks.Core.Domain.Entities
{
    [Table("WorkOrderRouting", Schema = "Production")]
    public partial class WorkOrderRouting
    {
        #region Members
        [Key]
        public int WorkOrderId { get; set; }
        [Key]
        public int ProductId { get; set; }
        [Key]
        public short OperationSequence { get; set; }
        public decimal? ActualCost { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public decimal? ActualResourceHrs { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public short LocationId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public decimal PlannedCost { get; set; }
        public DateTime ScheduledEndDate { get; set; }
        public DateTime ScheduledStartDate { get; set; }
        #endregion Members

        #region Equals / GetHashCode
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            WorkOrderRouting other = obj as WorkOrderRouting;
            if (other == null) return false;

            if (ActualCost != other.ActualCost)
                return false;
            if (ActualEndDate != other.ActualEndDate)
                return false;
            if (ActualResourceHrs != other.ActualResourceHrs)
                return false;
            if (ActualStartDate != other.ActualStartDate)
                return false;
            if (LocationId != other.LocationId)
                return false;
            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (OperationSequence != other.OperationSequence)
                return false;
            if (PlannedCost != other.PlannedCost)
                return false;
            if (ProductId != other.ProductId)
                return false;
            if (ScheduledEndDate != other.ScheduledEndDate)
                return false;
            if (ScheduledStartDate != other.ScheduledStartDate)
                return false;
            if (WorkOrderId != other.WorkOrderId)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (ActualCost == null ? 0 : ActualCost.GetHashCode());
                hash = hash * 23 + (ActualEndDate == null ? 0 : ActualEndDate.GetHashCode());
                hash = hash * 23 + (ActualResourceHrs == null ? 0 : ActualResourceHrs.GetHashCode());
                hash = hash * 23 + (ActualStartDate == null ? 0 : ActualStartDate.GetHashCode());
                hash = hash * 23 + (LocationId == default(short) ? 0 : LocationId.GetHashCode());
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (OperationSequence == default(short) ? 0 : OperationSequence.GetHashCode());
                hash = hash * 23 + (PlannedCost == default(decimal) ? 0 : PlannedCost.GetHashCode());
                hash = hash * 23 + (ProductId == default(int) ? 0 : ProductId.GetHashCode());
                hash = hash * 23 + (ScheduledEndDate == default(DateTime) ? 0 : ScheduledEndDate.GetHashCode());
                hash = hash * 23 + (ScheduledStartDate == default(DateTime) ? 0 : ScheduledStartDate.GetHashCode());
                hash = hash * 23 + (WorkOrderId == default(int) ? 0 : WorkOrderId.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(WorkOrderRouting left, WorkOrderRouting right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WorkOrderRouting left, WorkOrderRouting right)
        {
            return !Equals(left, right);
        }

        #endregion Equals / GetHashCode
    }
}