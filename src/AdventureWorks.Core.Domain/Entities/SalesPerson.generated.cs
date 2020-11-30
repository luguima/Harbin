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
    [Table("SalesPerson", Schema = "Sales")]
    public partial class SalesPerson
    {
        #region Members
        [Key]
        public int BusinessEntityId { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid Rowguid { get; set; }
        public decimal SalesLastYear { get; set; }
        public decimal? SalesQuota { get; set; }
        public decimal SalesYtd { get; set; }
        public int? TerritoryId { get; set; }
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
            SalesPerson other = obj as SalesPerson;
            if (other == null) return false;

            if (Bonus != other.Bonus)
                return false;
            if (BusinessEntityId != other.BusinessEntityId)
                return false;
            if (CommissionPct != other.CommissionPct)
                return false;
            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (Rowguid != other.Rowguid)
                return false;
            if (SalesLastYear != other.SalesLastYear)
                return false;
            if (SalesQuota != other.SalesQuota)
                return false;
            if (SalesYtd != other.SalesYtd)
                return false;
            if (TerritoryId != other.TerritoryId)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Bonus == default(decimal) ? 0 : Bonus.GetHashCode());
                hash = hash * 23 + (BusinessEntityId == default(int) ? 0 : BusinessEntityId.GetHashCode());
                hash = hash * 23 + (CommissionPct == default(decimal) ? 0 : CommissionPct.GetHashCode());
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (Rowguid == default(Guid) ? 0 : Rowguid.GetHashCode());
                hash = hash * 23 + (SalesLastYear == default(decimal) ? 0 : SalesLastYear.GetHashCode());
                hash = hash * 23 + (SalesQuota == null ? 0 : SalesQuota.GetHashCode());
                hash = hash * 23 + (SalesYtd == default(decimal) ? 0 : SalesYtd.GetHashCode());
                hash = hash * 23 + (TerritoryId == null ? 0 : TerritoryId.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(SalesPerson left, SalesPerson right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SalesPerson left, SalesPerson right)
        {
            return !Equals(left, right);
        }

        #endregion Equals / GetHashCode
    }
}
