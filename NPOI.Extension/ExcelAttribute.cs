﻿// Copyright (c) RigoFunc (xuyingting). All rights reserved.

namespace NPOI.Extension {
    using System;

    /// <summary>
    /// Represents a custom attribute to control object's properties to excel columns behaviors.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ColumnAttribute : Attribute {
        /// <summary>
        /// Gets or sets the title of the column.
        /// </summary>
        /// <remarks>
        /// If the <see cref="Title"/> is null or empty, will use property name as the excel column title.
        /// </remarks>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the index of the column.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets a value indicating wheter allow to sum the cell values
        /// </summary>
        public bool AllowSum { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether allow merge the same value cells.
        /// </summary>
        public bool AllowMerge { get; set; }
    }

    /// <summary>
    /// Represents a custom attribute to control excel filter behaviors.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class FilterAttribute : Attribute {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttribute"/> class.
        /// </summary>
        public FilterAttribute() {
            LastRow = null;
        }

        /// <summary>
        /// Gets or sets the first row index.
        /// </summary>
        public int FirstRow { get; set; }

        /// <summary>
        /// Gets or sets  the last row index.
        /// </summary>
        /// <remarks>
        /// If the <see cref="LastRow"/> is null, the value is dynamic calculate by code.
        /// </remarks>
        public int? LastRow { get; set; }

        /// <summary>
        /// Gets or sets the first column index.
        /// </summary>
        public int FirstCol { get; set; }

        /// <summary>
        /// Gets or sets the last column index.
        /// </summary>
        public int LastCol { get; set; }
    }

    /// <summary>
    /// Represents a custom attribute to control excel freeze behaviors.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class FreezeAttribute : Attribute {
        /// <summary>
        /// Initializes a new instance of the <see cref="FreezeAttribute"/> class.
        /// </summary>
        public FreezeAttribute() {
            ColSplit = 0;
            RowSplit = 1;
            LeftMostColumn = 0;
            TopRow = 1;
        }

        /// <summary>
        /// Gets or sets the column number to split.
        /// </summary>
        public int ColSplit { get; set; }

        /// <summary>
        /// Gets or sets the row number to split.
        /// </summary>
        public int RowSplit { get; set; }

        /// <summary>
        /// Gets or sets the left most culomn index.
        /// </summary>
        public int LeftMostColumn { get; set; }

        /// <summary>
        /// Gets or sets the top most row index.
        /// </summary>
        public int TopRow { get; set; }
    }
}
