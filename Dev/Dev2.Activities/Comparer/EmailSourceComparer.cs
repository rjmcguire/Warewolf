#pragma warning disable
﻿using Dev2.Runtime.ServiceModel.Data;
using System.Collections.Generic;

namespace Dev2.Comparer
{
    internal class EmailSourceComparer : IEqualityComparer<EmailSource>
    {
#pragma warning disable S1541 // Methods and properties should not be too complex
        public bool Equals(EmailSource x, EmailSource y)
#pragma warning restore S1541 // Methods and properties should not be too complex
        {
            if (x == null && y == null)
            {
                return true;
            }

            if ((x != null && y == null) || (x == null && y != null))
            {
                return false;
            }

            return string.Equals(x.Host, y.Host)
                && string.Equals(x.UserName, y.UserName)
                && string.Equals(x.Password, y.Password)
                && string.Equals(x.TestFromAddress, y.TestFromAddress)
                && string.Equals(x.TestToAddress, y.TestToAddress)
                && string.Equals(x.DataList, y.DataList)
                && x.EnableSsl.Equals(y.EnableSsl)
                && x.Timeout.Equals(y.Timeout);
        }

        public int GetHashCode(EmailSource obj) => 1;
    }
}