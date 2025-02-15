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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the PutLifecycleConfiguration operation.
    /// Enables lifecycle management by creating a new <code>LifecycleConfiguration</code>
    /// object. A <code>LifecycleConfiguration</code> object defines when files in an Amazon
    /// EFS file system are automatically transitioned to the lower-cost EFS Infrequent Access
    /// (IA) storage class. To enable EFS Intelligent Tiering, set the value of <code>TransitionToPrimaryStorageClass</code>
    /// to <code>AFTER_1_ACCESS</code>. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/lifecycle-management-efs.html">EFS
    /// Lifecycle Management</a>.
    /// 
    ///  
    /// <para>
    /// Each Amazon EFS file system supports one lifecycle configuration, which applies to
    /// all files in the file system. If a <code>LifecycleConfiguration</code> object already
    /// exists for the specified file system, a <code>PutLifecycleConfiguration</code> call
    /// modifies the existing configuration. A <code>PutLifecycleConfiguration</code> call
    /// with an empty <code>LifecyclePolicies</code> array in the request body deletes any
    /// existing <code>LifecycleConfiguration</code> and turns off lifecycle management for
    /// the file system.
    /// </para>
    ///  
    /// <para>
    /// In the request, specify the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The ID for the file system for which you are enabling, disabling, or modifying lifecycle
    /// management.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <code>LifecyclePolicies</code> array of <code>LifecyclePolicy</code> objects that
    /// define when files are moved to the IA storage class. Amazon EFS requires that each
    /// <code>LifecyclePolicy</code> object have only have a single transition, so the <code>LifecyclePolicies</code>
    /// array needs to be structured with separate <code>LifecyclePolicy</code> objects. See
    /// the example requests in the following section for more information.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation requires permissions for the <code>elasticfilesystem:PutLifecycleConfiguration</code>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// To apply a <code>LifecycleConfiguration</code> object to an encrypted file system,
    /// you need the same Key Management Service permissions as when you created the encrypted
    /// file system. 
    /// </para>
    /// </summary>
    public partial class PutLifecycleConfigurationRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;
        private List<LifecyclePolicy> _lifecyclePolicies = new List<LifecyclePolicy>();

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system for which you are creating the <code>LifecycleConfiguration</code>
        /// object (String).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property LifecyclePolicies. 
        /// <para>
        /// An array of <code>LifecyclePolicy</code> objects that define the file system's <code>LifecycleConfiguration</code>
        /// object. A <code>LifecycleConfiguration</code> object informs EFS lifecycle management
        /// and intelligent tiering of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When to move files in the file system from primary storage to the IA storage class.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When to move files that are in IA storage to primary storage.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// When using the <code>put-lifecycle-configuration</code> CLI command or the <code>PutLifecycleConfiguration</code>
        /// API action, Amazon EFS requires that each <code>LifecyclePolicy</code> object have
        /// only a single transition. This means that in a request body, <code>LifecyclePolicies</code>
        /// needs to be structured as an array of <code>LifecyclePolicy</code> objects, one object
        /// for each transition, <code>TransitionToIA</code>, <code>TransitionToPrimaryStorageClass</code>.
        /// See the example requests in the following section for more information.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Max=2)]
        public List<LifecyclePolicy> LifecyclePolicies
        {
            get { return this._lifecyclePolicies; }
            set { this._lifecyclePolicies = value; }
        }

        // Check to see if LifecyclePolicies property is set
        internal bool IsSetLifecyclePolicies()
        {
            return this._lifecyclePolicies != null && this._lifecyclePolicies.Count > 0; 
        }

    }
}