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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBParameterGroup operation.
    /// Modifies the parameters of a DB parameter group. To modify more than one parameter,
    /// submit a list of the following: <code>ParameterName</code>, <code>ParameterValue</code>,
    /// and <code>ApplyMethod</code>. A maximum of 20 parameters can be modified in a single
    /// request. 
    /// 
    ///  <important> 
    /// <para>
    /// After you modify a DB parameter group, you should wait at least 5 minutes before creating
    /// your first DB instance that uses that DB parameter group as the default parameter
    /// group. This allows Amazon RDS to fully complete the modify action before the parameter
    /// group is used as the default for a new DB instance. This is especially important for
    /// parameters that are critical when creating the default database for a DB instance,
    /// such as the character set for the default database defined by the <code>character_set_database</code>
    /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
    /// RDS console</a> or the <i>DescribeDBParameters</i> command to verify that your DB
    /// parameter group has been created or modified.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ModifyDBParameterGroupRequest : AmazonRDSRequest
    {
        private string _dbParameterGroupName;
        private List<Parameter> _parameters = new List<Parameter>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ModifyDBParameterGroupRequest() { }

        /// <summary>
        /// Instantiates ModifyDBParameterGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="dbParameterGroupName">The name of the DB parameter group. Constraints: <ul> <li> If supplied, must match the name of an existing <code>DBParameterGroup</code>. </li> </ul></param>
        /// <param name="parameters">An array of parameter names, values, and the application methods for the parameter update. At least one parameter name, value, and application method must be supplied; later arguments are optional. A maximum of 20 parameters can be modified in a single request. Valid Values (for the application method): <code>immediate | pending-reboot</code>  You can use the <code>immediate</code> value with dynamic parameters only. You can use the <code>pending-reboot</code> value for both dynamic and static parameters. When the application method is <code>immediate</code>, changes to dynamic parameters are applied immediately to the DB instances associated with the parameter group. When the application method is <code>pending-reboot</code>, changes to dynamic and static parameters are applied after a reboot without failover to the DB instances associated with the parameter group. <note> You can't use <code>pending-reboot</code> with dynamic parameters on RDS for SQL Server DB instances. Use <code>immediate</code>. </note> For more information on modifying DB parameters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithParamGroups.html">Working with DB parameter groups</a> in the <i>Amazon RDS User Guide</i>.</param>
        public ModifyDBParameterGroupRequest(string dbParameterGroupName, List<Parameter> parameters)
        {
            _dbParameterGroupName = dbParameterGroupName;
            _parameters = parameters;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the name of an existing <code>DBParameterGroup</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBParameterGroupName
        {
            get { return this._dbParameterGroupName; }
            set { this._dbParameterGroupName = value; }
        }

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this._dbParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// An array of parameter names, values, and the application methods for the parameter
        /// update. At least one parameter name, value, and application method must be supplied;
        /// later arguments are optional. A maximum of 20 parameters can be modified in a single
        /// request.
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for the application method): <code>immediate | pending-reboot</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>immediate</code> value with dynamic parameters only. You can
        /// use the <code>pending-reboot</code> value for both dynamic and static parameters.
        /// </para>
        ///  
        /// <para>
        /// When the application method is <code>immediate</code>, changes to dynamic parameters
        /// are applied immediately to the DB instances associated with the parameter group.
        /// </para>
        ///  
        /// <para>
        /// When the application method is <code>pending-reboot</code>, changes to dynamic and
        /// static parameters are applied after a reboot without failover to the DB instances
        /// associated with the parameter group.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't use <code>pending-reboot</code> with dynamic parameters on RDS for SQL Server
        /// DB instances. Use <code>immediate</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on modifying DB parameters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithParamGroups.html">Working
        /// with DB parameter groups</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

    }
}