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
    [Table("Currency", Schema = "Sales")]
    public partial class Currency
    {
        #region Members
        [Key]
        public string CurrencyCode { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Name { get; set; }
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
            Currency other = obj as Currency;
            if (other == null) return false;

            if (CurrencyCode != other.CurrencyCode)
                return false;
            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (Name != other.Name)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (CurrencyCode == null ? 0 : CurrencyCode.GetHashCode());
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (Name == null ? 0 : Name.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(Currency left, Currency right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Currency left, Currency right)
        {
            return !Equals(left, right);
        }

        #endregion Equals / GetHashCode
    }
}
