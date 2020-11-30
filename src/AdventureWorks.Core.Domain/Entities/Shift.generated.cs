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
    [Table("Shift", Schema = "HumanResources")]
    public partial class Shift
    {
        #region Members
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ShiftId { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
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
            Shift other = obj as Shift;
            if (other == null) return false;

            if (EndTime != other.EndTime)
                return false;
            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (Name != other.Name)
                return false;
            if (StartTime != other.StartTime)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (EndTime == default(DateTime) ? 0 : EndTime.GetHashCode());
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (Name == null ? 0 : Name.GetHashCode());
                hash = hash * 23 + (StartTime == default(DateTime) ? 0 : StartTime.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(Shift left, Shift right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Shift left, Shift right)
        {
            return !Equals(left, right);
        }

        #endregion Equals / GetHashCode
    }
}
