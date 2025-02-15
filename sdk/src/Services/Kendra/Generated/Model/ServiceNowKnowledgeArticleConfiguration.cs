/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for crawling knowledge articles in the ServiceNow
    /// site.
    /// </summary>
    public partial class ServiceNowKnowledgeArticleConfiguration
    {
        private bool? _crawlAttachments;
        private string _documentDataFieldName;
        private string _documentTitleFieldName;
        private List<string> _excludeAttachmentFilePatterns = new List<string>();
        private List<DataSourceToIndexFieldMapping> _fieldMappings = new List<DataSourceToIndexFieldMapping>();
        private string _filterQuery;
        private List<string> _includeAttachmentFilePatterns = new List<string>();

        /// <summary>
        /// Gets and sets the property CrawlAttachments. 
        /// <para>
        /// Indicates whether Amazon Kendra should index attachments to knowledge articles.
        /// </para>
        /// </summary>
        public bool CrawlAttachments
        {
            get { return this._crawlAttachments.GetValueOrDefault(); }
            set { this._crawlAttachments = value; }
        }

        // Check to see if CrawlAttachments property is set
        internal bool IsSetCrawlAttachments()
        {
            return this._crawlAttachments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocumentDataFieldName. 
        /// <para>
        /// The name of the ServiceNow field that is mapped to the index document contents field
        /// in the Amazon Kendra index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DocumentDataFieldName
        {
            get { return this._documentDataFieldName; }
            set { this._documentDataFieldName = value; }
        }

        // Check to see if DocumentDataFieldName property is set
        internal bool IsSetDocumentDataFieldName()
        {
            return this._documentDataFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentTitleFieldName. 
        /// <para>
        /// The name of the ServiceNow field that is mapped to the index document title field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DocumentTitleFieldName
        {
            get { return this._documentTitleFieldName; }
            set { this._documentTitleFieldName = value; }
        }

        // Check to see if DocumentTitleFieldName property is set
        internal bool IsSetDocumentTitleFieldName()
        {
            return this._documentTitleFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludeAttachmentFilePatterns. 
        /// <para>
        /// List of regular expressions applied to knowledge articles. Items that don't match
        /// the inclusion pattern are not indexed. The regex is applied to the field specified
        /// in the <code>PatternTargetField</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ExcludeAttachmentFilePatterns
        {
            get { return this._excludeAttachmentFilePatterns; }
            set { this._excludeAttachmentFilePatterns = value; }
        }

        // Check to see if ExcludeAttachmentFilePatterns property is set
        internal bool IsSetExcludeAttachmentFilePatterns()
        {
            return this._excludeAttachmentFilePatterns != null && this._excludeAttachmentFilePatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// Mapping between ServiceNow fields and Amazon Kendra index fields. You must create
        /// the index field before you map the field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> FieldMappings
        {
            get { return this._fieldMappings; }
            set { this._fieldMappings = value; }
        }

        // Check to see if FieldMappings property is set
        internal bool IsSetFieldMappings()
        {
            return this._fieldMappings != null && this._fieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FilterQuery. 
        /// <para>
        /// A query that selects the knowledge articles to index. The query can return articles
        /// from multiple knowledge bases, and the knowledge bases can be public or private.
        /// </para>
        ///  
        /// <para>
        /// The query string must be one generated by the ServiceNow console. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/servicenow-query.html">Specifying
        /// documents to index with a query</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FilterQuery
        {
            get { return this._filterQuery; }
            set { this._filterQuery = value; }
        }

        // Check to see if FilterQuery property is set
        internal bool IsSetFilterQuery()
        {
            return this._filterQuery != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeAttachmentFilePatterns. 
        /// <para>
        /// List of regular expressions applied to knowledge articles. Items that don't match
        /// the inclusion pattern are not indexed. The regex is applied to the field specified
        /// in the <code>PatternTargetField</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> IncludeAttachmentFilePatterns
        {
            get { return this._includeAttachmentFilePatterns; }
            set { this._includeAttachmentFilePatterns = value; }
        }

        // Check to see if IncludeAttachmentFilePatterns property is set
        internal bool IsSetIncludeAttachmentFilePatterns()
        {
            return this._includeAttachmentFilePatterns != null && this._includeAttachmentFilePatterns.Count > 0; 
        }

    }
}