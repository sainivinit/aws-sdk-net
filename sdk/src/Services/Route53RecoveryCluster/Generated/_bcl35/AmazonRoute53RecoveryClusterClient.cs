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
 * Do not modify this file. This file is generated from the route53-recovery-cluster-2019-12-02.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Route53RecoveryCluster.Model;
using Amazon.Route53RecoveryCluster.Model.Internal.MarshallTransformations;
using Amazon.Route53RecoveryCluster.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53RecoveryCluster
{
    /// <summary>
    /// Implementation for accessing Route53RecoveryCluster
    ///
    /// Welcome to the Routing Control (Recovery Cluster) API Reference Guide for Amazon Route
    /// 53 Application Recovery Controller.
    /// 
    ///  
    /// <para>
    /// With Amazon Route 53 Application Recovery Controller, you can use routing control
    /// with extreme reliability to recover applications by rerouting traffic across Availability
    /// Zones or AWS Regions. Routing controls are simple on/off switches hosted on a highly
    /// available cluster in Application Recovery Controller. A cluster provides a set of
    /// five redundant Regional endpoints against which you can run API calls to get or update
    /// the state of routing controls. To implement failover, you set one routing control
    /// on and another one off, to reroute traffic from one Availability Zone or Amazon Web
    /// Services Region to another. 
    /// </para>
    ///  
    /// <para>
    ///  <i>Be aware that you must specify the Regional endpoints for a cluster when you work
    /// with API cluster operations to get or update routing control states in Application
    /// Recovery Controller.</i> In addition, you must specify the US West (Oregon) Region
    /// for Application Recovery Controller API calls. For example, use the parameter <code>region
    /// us-west-2</code> with AWS CLI commands. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.api.html">
    /// Get and update routing control states using the API</a> in the Amazon Route 53 Application
    /// Recovery Controller Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// This API guide includes information about the API operations for how to get and update
    /// routing control states in Application Recovery Controller. You also must set up the
    /// structures to support routing controls: clusters and control panels.
    /// </para>
    ///  
    /// <para>
    /// For more information about working with routing control in Application Recovery Controller,
    /// see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To create clusters, routing controls, and control panels by using the control plane
    /// API for routing control, see the <a href="https://docs.aws.amazon.com/recovery-cluster/latest/api/">Recovery
    /// Control Configuration API Reference Guide for Amazon Route 53 Application Recovery
    /// Controller</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Learn about the components in recovery control configuration, including clusters,
    /// routing controls, and control panels. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/introduction-components.html#introduction-components-routing">
    /// Recovery control components</a> in the Amazon Route 53 Application Recovery Controller
    /// Developer Guide.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Application Recovery Controller also provides readiness checks that run continually
    /// to help make sure that your applications are scaled and ready to handle failover traffic.
    /// For more information about the related API actions, see the <a href="https://docs.aws.amazon.com/recovery-readiness/latest/api/">Recovery
    /// Readiness API Reference Guide for Amazon Route 53 Application Recovery Controller</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For more information about creating resilient applications and preparing for recovery
    /// readiness with Application Recovery Controller, see the <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/">Amazon
    /// Route 53 Application Recovery Controller Developer Guide</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonRoute53RecoveryClusterClient : AmazonServiceClient, IAmazonRoute53RecoveryCluster
    {
        private static IServiceMetadata serviceMetadata = new AmazonRoute53RecoveryClusterMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53RecoveryClusterClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRoute53RecoveryClusterClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53RecoveryClusterConfig()) { }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryClusterClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53RecoveryClusterClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53RecoveryClusterConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryClusterClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRoute53RecoveryClusterClient Configuration Object</param>
        public AmazonRoute53RecoveryClusterClient(AmazonRoute53RecoveryClusterConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryClusterClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53RecoveryClusterClient(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53RecoveryClusterConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryClusterClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53RecoveryClusterClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53RecoveryClusterConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryClusterClient with AWS Credentials and an
        /// AmazonRoute53RecoveryClusterClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53RecoveryClusterClient Configuration Object</param>
        public AmazonRoute53RecoveryClusterClient(AWSCredentials credentials, AmazonRoute53RecoveryClusterConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryClusterClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53RecoveryClusterClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53RecoveryClusterConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryClusterClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53RecoveryClusterClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53RecoveryClusterConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryClusterClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53RecoveryClusterClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53RecoveryClusterClient Configuration Object</param>
        public AmazonRoute53RecoveryClusterClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53RecoveryClusterConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryClusterClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53RecoveryClusterClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53RecoveryClusterConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryClusterClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53RecoveryClusterClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53RecoveryClusterConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryClusterClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53RecoveryClusterClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53RecoveryClusterClient Configuration Object</param>
        public AmazonRoute53RecoveryClusterClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53RecoveryClusterConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  GetRoutingControlState

        /// <summary>
        /// Get the state for a routing control. A routing control is a simple on/off switch that
        /// you can use to route traffic to cells. When the state is On, traffic flows to a cell.
        /// When it's Off, traffic does not flow. 
        /// 
        ///  
        /// <para>
        /// Before you can create a routing control, you must first create a cluster to host the
        /// control in a control panel. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.create.html">
        /// Create routing control structures</a> in the Amazon Route 53 Application Recovery
        /// Controller Developer Guide. Then you access one of the endpoints for the cluster to
        /// get or update the routing control state to redirect traffic. 
        /// </para>
        ///  
        /// <para>
        ///  <i>You must specify Regional endpoints when you work with API cluster operations
        /// to get or update routing control states in Application Recovery Controller.</i> 
        /// </para>
        ///  
        /// <para>
        /// To see a code example for getting a routing control state, including accessing Regional
        /// cluster endpoints in sequence, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/service_code_examples_actions.html">API
        /// examples</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// Learn more about working with routing controls in the following topics in the Amazon
        /// Route 53 Application Recovery Controller Developer Guide:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
        /// Viewing and updating routing control states</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
        /// with routing controls overall</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutingControlState service method.</param>
        /// 
        /// <returns>The response from the GetRoutingControlState service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to query the routing control state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.EndpointTemporarilyUnavailableException">
        /// The cluster endpoint isn't available. Try another cluster endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.InternalServerException">
        /// There was an unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ResourceNotFoundException">
        /// The request references a routing control that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/GetRoutingControlState">REST API Reference for GetRoutingControlState Operation</seealso>
        public virtual GetRoutingControlStateResponse GetRoutingControlState(GetRoutingControlStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoutingControlStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutingControlStateResponseUnmarshaller.Instance;

            return Invoke<GetRoutingControlStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoutingControlState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoutingControlState operation on AmazonRoute53RecoveryClusterClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoutingControlState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/GetRoutingControlState">REST API Reference for GetRoutingControlState Operation</seealso>
        public virtual IAsyncResult BeginGetRoutingControlState(GetRoutingControlStateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoutingControlStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutingControlStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoutingControlState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoutingControlState.</param>
        /// 
        /// <returns>Returns a  GetRoutingControlStateResult from Route53RecoveryCluster.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/GetRoutingControlState">REST API Reference for GetRoutingControlState Operation</seealso>
        public virtual GetRoutingControlStateResponse EndGetRoutingControlState(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRoutingControlStateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRoutingControlState

        /// <summary>
        /// Set the state of the routing control to reroute traffic. You can set the value to
        /// be On or Off. When the state is On, traffic flows to a cell. When it's Off, traffic
        /// does not flow.
        /// 
        ///  
        /// <para>
        /// With Application Recovery Controller, you can add safety rules for routing controls,
        /// which are safeguards for routing control state updates that help prevent unexpected
        /// outcomes, like fail open traffic routing. However, there are scenarios when you might
        /// want to bypass the routing control safeguards that are enforced with safety rules
        /// that you've configured. For example, you might want to fail over quickly for disaster
        /// recovery, and one or more safety rules might be unexpectedly preventing you from updating
        /// a routing control state to reroute traffic. In a "break glass" scenario like this,
        /// you can override one or more safety rules to change a routing control state and fail
        /// over your application.
        /// </para>
        ///  
        /// <para>
        /// The <code>SafetyRulesToOverride</code> property enables you override one or more safety
        /// rules and update routing control states. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.override-safety-rule.html">
        /// Override safety rules to reroute traffic</a> in the Amazon Route 53 Application Recovery
        /// Controller Developer Guide.
        /// </para>
        ///  
        /// <para>
        ///  <i>You must specify Regional endpoints when you work with API cluster operations
        /// to get or update routing control states in Application Recovery Controller.</i> 
        /// </para>
        ///  
        /// <para>
        /// To see a code example for getting a routing control state, including accessing Regional
        /// cluster endpoints in sequence, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/service_code_examples_actions.html">API
        /// examples</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
        /// Viewing and updating routing control states</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
        /// with routing controls overall</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControlState service method.</param>
        /// 
        /// <returns>The response from the UpdateRoutingControlState service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to query the routing control state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ConflictException">
        /// There was a conflict with this request. Try again.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.EndpointTemporarilyUnavailableException">
        /// The cluster endpoint isn't available. Try another cluster endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.InternalServerException">
        /// There was an unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ResourceNotFoundException">
        /// The request references a routing control that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/UpdateRoutingControlState">REST API Reference for UpdateRoutingControlState Operation</seealso>
        public virtual UpdateRoutingControlStateResponse UpdateRoutingControlState(UpdateRoutingControlStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingControlStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingControlStateResponseUnmarshaller.Instance;

            return Invoke<UpdateRoutingControlStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoutingControlState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControlState operation on AmazonRoute53RecoveryClusterClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoutingControlState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/UpdateRoutingControlState">REST API Reference for UpdateRoutingControlState Operation</seealso>
        public virtual IAsyncResult BeginUpdateRoutingControlState(UpdateRoutingControlStateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingControlStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingControlStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoutingControlState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoutingControlState.</param>
        /// 
        /// <returns>Returns a  UpdateRoutingControlStateResult from Route53RecoveryCluster.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/UpdateRoutingControlState">REST API Reference for UpdateRoutingControlState Operation</seealso>
        public virtual UpdateRoutingControlStateResponse EndUpdateRoutingControlState(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRoutingControlStateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRoutingControlStates

        /// <summary>
        /// Set multiple routing control states. You can set the value for each state to be On
        /// or Off. When the state is On, traffic flows to a cell. When it's Off, traffic does
        /// not flow.
        /// 
        ///  
        /// <para>
        /// With Application Recovery Controller, you can add safety rules for routing controls,
        /// which are safeguards for routing control state updates that help prevent unexpected
        /// outcomes, like fail open traffic routing. However, there are scenarios when you might
        /// want to bypass the routing control safeguards that are enforced with safety rules
        /// that you've configured. For example, you might want to fail over quickly for disaster
        /// recovery, and one or more safety rules might be unexpectedly preventing you from updating
        /// a routing control state to reroute traffic. In a "break glass" scenario like this,
        /// you can override one or more safety rules to change a routing control state and fail
        /// over your application.
        /// </para>
        ///  
        /// <para>
        /// The <code>SafetyRulesToOverride</code> property enables you override one or more safety
        /// rules and update routing control states. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.override-safety-rule.html">
        /// Override safety rules to reroute traffic</a> in the Amazon Route 53 Application Recovery
        /// Controller Developer Guide.
        /// </para>
        ///  
        /// <para>
        ///  <i>You must specify Regional endpoints when you work with API cluster operations
        /// to get or update routing control states in Application Recovery Controller.</i> 
        /// </para>
        ///  
        /// <para>
        /// To see a code example for getting a routing control state, including accessing Regional
        /// cluster endpoints in sequence, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/service_code_examples_actions.html">API
        /// examples</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
        /// Viewing and updating routing control states</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
        /// with routing controls overall</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControlStates service method.</param>
        /// 
        /// <returns>The response from the UpdateRoutingControlStates service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to query the routing control state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ConflictException">
        /// There was a conflict with this request. Try again.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.EndpointTemporarilyUnavailableException">
        /// The cluster endpoint isn't available. Try another cluster endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.InternalServerException">
        /// There was an unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ResourceNotFoundException">
        /// The request references a routing control that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/UpdateRoutingControlStates">REST API Reference for UpdateRoutingControlStates Operation</seealso>
        public virtual UpdateRoutingControlStatesResponse UpdateRoutingControlStates(UpdateRoutingControlStatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingControlStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingControlStatesResponseUnmarshaller.Instance;

            return Invoke<UpdateRoutingControlStatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoutingControlStates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControlStates operation on AmazonRoute53RecoveryClusterClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoutingControlStates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/UpdateRoutingControlStates">REST API Reference for UpdateRoutingControlStates Operation</seealso>
        public virtual IAsyncResult BeginUpdateRoutingControlStates(UpdateRoutingControlStatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingControlStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingControlStatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoutingControlStates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoutingControlStates.</param>
        /// 
        /// <returns>Returns a  UpdateRoutingControlStatesResult from Route53RecoveryCluster.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/UpdateRoutingControlStates">REST API Reference for UpdateRoutingControlStates Operation</seealso>
        public virtual UpdateRoutingControlStatesResponse EndUpdateRoutingControlStates(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRoutingControlStatesResponse>(asyncResult);
        }

        #endregion
        
    }
}