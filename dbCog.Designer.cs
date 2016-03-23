﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace CogNetworks
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class dbCognitiveEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new dbCognitiveEntities object using the connection string found in the 'dbCognitiveEntities' section of the application configuration file.
        /// </summary>
        public dbCognitiveEntities() : base("name=dbCognitiveEntities", "dbCognitiveEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new dbCognitiveEntities object.
        /// </summary>
        public dbCognitiveEntities(string connectionString) : base(connectionString, "dbCognitiveEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new dbCognitiveEntities object.
        /// </summary>
        public dbCognitiveEntities(EntityConnection connection) : base(connection, "dbCognitiveEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tblLink> tblLinks
        {
            get
            {
                if ((_tblLinks == null))
                {
                    _tblLinks = base.CreateObjectSet<tblLink>("tblLinks");
                }
                return _tblLinks;
            }
        }
        private ObjectSet<tblLink> _tblLinks;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tblNode> tblNodes
        {
            get
            {
                if ((_tblNodes == null))
                {
                    _tblNodes = base.CreateObjectSet<tblNode>("tblNodes");
                }
                return _tblNodes;
            }
        }
        private ObjectSet<tblNode> _tblNodes;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tblLinks EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotblLinks(tblLink tblLink)
        {
            base.AddObject("tblLinks", tblLink);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tblNodes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotblNodes(tblNode tblNode)
        {
            base.AddObject("tblNodes", tblNode);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="dbCognitiveModel", Name="tblLink")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tblLink : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tblLink object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        public static tblLink CreatetblLink(global::System.Int32 id)
        {
            tblLink tblLink = new tblLink();
            tblLink.id = id;
            return tblLink;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> network
        {
            get
            {
                return _network;
            }
            set
            {
                OnnetworkChanging(value);
                ReportPropertyChanging("network");
                _network = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("network");
                OnnetworkChanged();
            }
        }
        private Nullable<global::System.Int32> _network;
        partial void OnnetworkChanging(Nullable<global::System.Int32> value);
        partial void OnnetworkChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> startNode
        {
            get
            {
                return _startNode;
            }
            set
            {
                OnstartNodeChanging(value);
                ReportPropertyChanging("startNode");
                _startNode = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("startNode");
                OnstartNodeChanged();
            }
        }
        private Nullable<global::System.Int32> _startNode;
        partial void OnstartNodeChanging(Nullable<global::System.Int32> value);
        partial void OnstartNodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> endNode
        {
            get
            {
                return _endNode;
            }
            set
            {
                OnendNodeChanging(value);
                ReportPropertyChanging("endNode");
                _endNode = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("endNode");
                OnendNodeChanged();
            }
        }
        private Nullable<global::System.Int32> _endNode;
        partial void OnendNodeChanging(Nullable<global::System.Int32> value);
        partial void OnendNodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> linkWeight
        {
            get
            {
                return _linkWeight;
            }
            set
            {
                OnlinkWeightChanging(value);
                ReportPropertyChanging("linkWeight");
                _linkWeight = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("linkWeight");
                OnlinkWeightChanged();
            }
        }
        private Nullable<global::System.Int32> _linkWeight;
        partial void OnlinkWeightChanging(Nullable<global::System.Int32> value);
        partial void OnlinkWeightChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="dbCognitiveModel", Name="tblNode")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tblNode : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tblNode object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        public static tblNode CreatetblNode(global::System.Int32 id)
        {
            tblNode tblNode = new tblNode();
            tblNode.id = id;
            return tblNode;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> network
        {
            get
            {
                return _network;
            }
            set
            {
                OnnetworkChanging(value);
                ReportPropertyChanging("network");
                _network = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("network");
                OnnetworkChanged();
            }
        }
        private Nullable<global::System.Int32> _network;
        partial void OnnetworkChanging(Nullable<global::System.Int32> value);
        partial void OnnetworkChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> node
        {
            get
            {
                return _node;
            }
            set
            {
                OnnodeChanging(value);
                ReportPropertyChanging("node");
                _node = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("node");
                OnnodeChanged();
            }
        }
        private Nullable<global::System.Int32> _node;
        partial void OnnodeChanging(Nullable<global::System.Int32> value);
        partial void OnnodeChanged();

        #endregion

    
    }

    #endregion

    
}