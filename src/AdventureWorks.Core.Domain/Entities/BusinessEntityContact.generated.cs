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
    [Table("BusinessEntityContact", Schema = "Person")]
    public partial class BusinessEntityContact
    {
        #region Members
        [Key]
        public int BusinessEntityId { get; set; }
        [Key]
        public int PersonId { get; set; }
        [Key]
        public int ContactTypeId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid Rowguid { get; set; }
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
            BusinessEntityContact other = obj as BusinessEntityContact;
            if (other == null) return false;

            if (BusinessEntityId != other.BusinessEntityId)
                return false;
            if (ContactTypeId != other.ContactTypeId)
                return false;
            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (PersonId != other.PersonId)
                return false;
            if (Rowguid != other.Rowguid)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (BusinessEntityId == default(int) ? 0 : BusinessEntityId.GetHashCode());
                hash = hash * 23 + (ContactTypeId == default(int) ? 0 : ContactTypeId.GetHashCode());
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (PersonId == default(int) ? 0 : PersonId.GetHashCode());
                hash = hash * 23 + (Rowguid == default(Guid) ? 0 : Rowguid.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(BusinessEntityContact left, BusinessEntityContact right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BusinessEntityContact left, BusinessEntityContact right)
        {
            return !Equals(left, right);
        }

        #endregion Equals / GetHashCode
    }
}