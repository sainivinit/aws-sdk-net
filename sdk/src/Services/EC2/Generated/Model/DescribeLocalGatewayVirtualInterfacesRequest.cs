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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLocalGatewayVirtualInterfaces operation.
    /// Describes the specified local gateway virtual interfaces.
    /// </summary>
    public partial class DescribeLocalGatewayVirtualInterfacesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _localGatewayVirtualInterfaceIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>local-address</code> - The local address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>local-bgp-asn</code> - The Border Gateway Protocol (BGP) Autonomous System
        /// Number (ASN) of the local gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>local-gateway-id</code> - The ID of the local gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>local-gateway-virtual-interface-id</code> - The ID of the virtual interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>local-gateway-virtual-interface-group-id</code> - The ID of the virtual interface
        /// group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code> - The ID of the Amazon Web Services account that owns the local
        /// gateway virtual interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>peer-address</code> - The peer address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>peer-bgp-asn</code> - The peer BGP ASN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vlan</code> - The ID of the VLAN.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceIds. 
        /// <para>
        /// The IDs of the virtual interfaces.
        /// </para>
        /// </summary>
        public List<string> LocalGatewayVirtualInterfaceIds
        {
            get { return this._localGatewayVirtualInterfaceIds; }
            set { this._localGatewayVirtualInterfaceIds = value; }
        }

        // Check to see if LocalGatewayVirtualInterfaceIds property is set
        internal bool IsSetLocalGatewayVirtualInterfaceIds()
        {
            return this._localGatewayVirtualInterfaceIds != null && this._localGatewayVirtualInterfaceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}