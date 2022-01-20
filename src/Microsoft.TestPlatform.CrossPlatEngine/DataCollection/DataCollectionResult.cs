﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.DataCollection
{
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Information returned after data collection.
    /// </summary>
    public class DataCollectionResult
    {
        public DataCollectionResult(Collection<AttachmentSet> attachments, Collection<InvokedDataCollector> invokedDataCollectors)
        {
            this.Attachments = attachments;
            this.InvokedDataCollectors = invokedDataCollectors;
        }

        /// <summary>
        /// Get list of attachments
        /// </summary>
        public Collection<AttachmentSet> Attachments { get; }

        /// <summary>
        /// Get the list of the invoked data collectors.
        /// </summary>
        public Collection<InvokedDataCollector> InvokedDataCollectors { get; }
    }
}