/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2019 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using System.Collections.Generic;
using Dev2.Web;
using Warewolf.Resource.Errors;


namespace Dev2.DataList.Contract
{
    public sealed class DataListFormat
    {
        #region Static Members
        static readonly object FormatLock = new object();
        static readonly Dictionary<string, DataListFormat> ExistingFormats = new Dictionary<string, DataListFormat>(StringComparer.Ordinal);

        public static DataListFormat CreateFormat(string formatName) => CreateFormat(formatName, EmitionTypes.XML, "");
        public static DataListFormat CreateFormat(string formatName, EmitionTypes publicFormatName, string headerType)
        {
            if(String.IsNullOrEmpty(formatName))
            {
                throw new ArgumentException(ErrorResource.FormatNameCannotBeNull);
            }

            DataListFormat format;

            lock(FormatLock)
            {
                if(!ExistingFormats.TryGetValue(formatName, out format))
                {
                    format = new DataListFormat(formatName, publicFormatName, headerType);
                    ExistingFormats.Add(formatName, format);
                }
            }

            return format;
        }
        #endregion

        #region Instance Fields
        readonly string _formatName;
        #endregion

        #region Public Properties
        /// <summary>
        /// The display name of the format.
        /// </summary>
        public string FormatName => _formatName;

        public EmitionTypes PublicFormatName { get; set; }

        public string ContentType { get; set; }
        #endregion

        #region Constructor

        DataListFormat(string formatName, EmitionTypes publicType, string headerType)
        {
            _formatName = formatName;
            PublicFormatName = publicType;
            ContentType = headerType;
        }
        #endregion

        #region Overrides
        public override string ToString() => "Datalist Format [" + _formatName + "]";
        #endregion
    }
}
