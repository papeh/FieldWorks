﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

//
// This source code was auto-generated by xsd, Version=2.0.50727.42.
//


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[Serializable()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.ComponentModel.ToolboxItem(true)]
[System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
[System.Xml.Serialization.XmlRootAttribute("EncConverterPlugins")]
[System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
public partial class EncConverterPlugins : System.Data.DataSet {

	private ECPluginDetailsDataTable tableECPluginDetails;

	private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	public EncConverterPlugins() {
		this.BeginInit();
		this.InitClass();
		System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
		base.Tables.CollectionChanged += schemaChangedHandler;
		base.Relations.CollectionChanged += schemaChangedHandler;
		this.EndInit();
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	protected EncConverterPlugins(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) :
			base(info, context, false) {
		if ((this.IsBinarySerialized(info, context) == true)) {
			this.InitVars(false);
			System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
			this.Tables.CollectionChanged += schemaChangedHandler1;
			this.Relations.CollectionChanged += schemaChangedHandler1;
			return;
		}
		string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
		if ((this.DetermineSchemaSerializationMode(info, context) == System.Data.SchemaSerializationMode.IncludeSchema)) {
			System.Data.DataSet ds = new System.Data.DataSet();
			ds.ReadXmlSchema(new System.Xml.XmlTextReader(new System.IO.StringReader(strSchema)));
			if ((ds.Tables["ECPluginDetails"] != null)) {
				base.Tables.Add(new ECPluginDetailsDataTable(ds.Tables["ECPluginDetails"]));
			}
			this.DataSetName = ds.DataSetName;
			this.Prefix = ds.Prefix;
			this.Namespace = ds.Namespace;
			this.Locale = ds.Locale;
			this.CaseSensitive = ds.CaseSensitive;
			this.EnforceConstraints = ds.EnforceConstraints;
			this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
			this.InitVars();
		}
		else {
			this.ReadXmlSchema(new System.Xml.XmlTextReader(new System.IO.StringReader(strSchema)));
		}
		this.GetSerializationData(info, context);
		System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
		base.Tables.CollectionChanged += schemaChangedHandler;
		this.Relations.CollectionChanged += schemaChangedHandler;
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	[System.ComponentModel.Browsable(false)]
	[System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
	public ECPluginDetailsDataTable ECPluginDetails {
		get {
			return this.tableECPluginDetails;
		}
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	[System.ComponentModel.BrowsableAttribute(true)]
	[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)]
	public override System.Data.SchemaSerializationMode SchemaSerializationMode {
		get {
			return this._schemaSerializationMode;
		}
		set {
			this._schemaSerializationMode = value;
		}
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
	public new System.Data.DataTableCollection Tables {
		get {
			return base.Tables;
		}
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
	public new System.Data.DataRelationCollection Relations {
		get {
			return base.Relations;
		}
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	protected override void InitializeDerivedDataSet() {
		this.BeginInit();
		this.InitClass();
		this.EndInit();
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	public override System.Data.DataSet Clone() {
		EncConverterPlugins cln = ((EncConverterPlugins)(base.Clone()));
		cln.InitVars();
		cln.SchemaSerializationMode = this.SchemaSerializationMode;
		return cln;
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	protected override bool ShouldSerializeTables() {
		return false;
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	protected override bool ShouldSerializeRelations() {
		return false;
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	protected override void ReadXmlSerializable(System.Xml.XmlReader reader) {
		if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) {
			this.Reset();
			System.Data.DataSet ds = new System.Data.DataSet();
			ds.ReadXml(reader);
			if ((ds.Tables["ECPluginDetails"] != null)) {
				base.Tables.Add(new ECPluginDetailsDataTable(ds.Tables["ECPluginDetails"]));
			}
			this.DataSetName = ds.DataSetName;
			this.Prefix = ds.Prefix;
			this.Namespace = ds.Namespace;
			this.Locale = ds.Locale;
			this.CaseSensitive = ds.CaseSensitive;
			this.EnforceConstraints = ds.EnforceConstraints;
			this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
			this.InitVars();
		}
		else {
			this.ReadXml(reader);
			this.InitVars();
		}
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
		System.IO.MemoryStream stream = new System.IO.MemoryStream();
		this.WriteXmlSchema(new System.Xml.XmlTextWriter(stream, null));
		stream.Position = 0;
		return System.Xml.Schema.XmlSchema.Read(new System.Xml.XmlTextReader(stream), null);
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	internal void InitVars() {
		this.InitVars(true);
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	internal void InitVars(bool initTable) {
		this.tableECPluginDetails = ((ECPluginDetailsDataTable)(base.Tables["ECPluginDetails"]));
		if ((initTable == true)) {
			if ((this.tableECPluginDetails != null)) {
				this.tableECPluginDetails.InitVars();
			}
		}
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	private void InitClass() {
		this.DataSetName = "EncConverterPlugins";
		this.Prefix = "";
		this.Namespace = "http://www.sil.org/computing/schemas/ECPlugins.xsd";
		this.EnforceConstraints = true;
		this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.tableECPluginDetails = new ECPluginDetailsDataTable();
		base.Tables.Add(this.tableECPluginDetails);
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	private bool ShouldSerializeECPluginDetails() {
		return false;
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
		if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
			this.InitVars();
		}
	}

	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	public static System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(System.Xml.Schema.XmlSchemaSet xs) {
		EncConverterPlugins ds = new EncConverterPlugins();
		System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
		System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
		xs.Add(ds.GetSchemaSerializable());
		System.Xml.Schema.XmlSchemaAny any = new System.Xml.Schema.XmlSchemaAny();
		any.Namespace = ds.Namespace;
		sequence.Items.Add(any);
		type.Particle = sequence;
		return type;
	}

	public delegate void ECPluginDetailsRowChangeEventHandler(object sender, ECPluginDetailsRowChangeEvent e);

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[System.Serializable()]
	[System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
	public partial class ECPluginDetailsDataTable : System.Data.DataTable, System.Collections.IEnumerable {

		private System.Data.DataColumn columnImplementationName;

		private System.Data.DataColumn columnImplementationProgId;

		private System.Data.DataColumn columnPriority;

		private System.Data.DataColumn columnDisplayName;

		private System.Data.DataColumn columnConfiguratorProgId;

		private System.Data.DataColumn columnDefiningExtension;

		private System.Data.DataColumn columnDefiningProcessType;

		private System.Data.DataColumn columnAssemblyReference;

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public ECPluginDetailsDataTable() {
			this.TableName = "ECPluginDetails";
			this.BeginInit();
			this.InitClass();
			this.EndInit();
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		internal ECPluginDetailsDataTable(System.Data.DataTable table) {
			this.TableName = table.TableName;
			if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
				this.CaseSensitive = table.CaseSensitive;
			}
			if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
				this.Locale = table.Locale;
			}
			if ((table.Namespace != table.DataSet.Namespace)) {
				this.Namespace = table.Namespace;
			}
			this.Prefix = table.Prefix;
			this.MinimumCapacity = table.MinimumCapacity;
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		protected ECPluginDetailsDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) :
				base(info, context) {
			this.InitVars();
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public System.Data.DataColumn ImplementationNameColumn {
			get {
				return this.columnImplementationName;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public System.Data.DataColumn ImplementationProgIdColumn {
			get {
				return this.columnImplementationProgId;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public System.Data.DataColumn PriorityColumn {
			get {
				return this.columnPriority;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public System.Data.DataColumn DisplayNameColumn {
			get {
				return this.columnDisplayName;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public System.Data.DataColumn ConfiguratorProgIdColumn {
			get {
				return this.columnConfiguratorProgId;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public System.Data.DataColumn DefiningExtensionColumn {
			get {
				return this.columnDefiningExtension;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public System.Data.DataColumn DefiningProcessTypeColumn {
			get {
				return this.columnDefiningProcessType;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public System.Data.DataColumn AssemblyReferenceColumn {
			get {
				return this.columnAssemblyReference;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[System.ComponentModel.Browsable(false)]
		public int Count {
			get {
				return this.Rows.Count;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public ECPluginDetailsRow this[int index] {
			get {
				return ((ECPluginDetailsRow)(this.Rows[index]));
			}
		}

		public event ECPluginDetailsRowChangeEventHandler ECPluginDetailsRowChanging;

		public event ECPluginDetailsRowChangeEventHandler ECPluginDetailsRowChanged;

		public event ECPluginDetailsRowChangeEventHandler ECPluginDetailsRowDeleting;

		public event ECPluginDetailsRowChangeEventHandler ECPluginDetailsRowDeleted;

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public void AddECPluginDetailsRow(ECPluginDetailsRow row) {
			this.Rows.Add(row);
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public ECPluginDetailsRow AddECPluginDetailsRow(string ImplementationName, string ImplementationProgId, int Priority, string DisplayName, string ConfiguratorProgId, string DefiningExtension, int DefiningProcessType, string AssemblyReference) {
			ECPluginDetailsRow rowECPluginDetailsRow = ((ECPluginDetailsRow)(this.NewRow()));
			rowECPluginDetailsRow.ItemArray = new object[] {
					ImplementationName,
					ImplementationProgId,
					Priority,
					DisplayName,
					ConfiguratorProgId,
					DefiningExtension,
					DefiningProcessType,
					AssemblyReference};
			this.Rows.Add(rowECPluginDetailsRow);
			return rowECPluginDetailsRow;
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public virtual System.Collections.IEnumerator GetEnumerator() {
			return this.Rows.GetEnumerator();
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public override System.Data.DataTable Clone() {
			ECPluginDetailsDataTable cln = ((ECPluginDetailsDataTable)(base.Clone()));
			cln.InitVars();
			return cln;
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		protected override System.Data.DataTable CreateInstance() {
			return new ECPluginDetailsDataTable();
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		internal void InitVars() {
			this.columnImplementationName = base.Columns["ImplementationName"];
			this.columnImplementationProgId = base.Columns["ImplementationProgId"];
			this.columnPriority = base.Columns["Priority"];
			this.columnDisplayName = base.Columns["DisplayName"];
			this.columnConfiguratorProgId = base.Columns["ConfiguratorProgId"];
			this.columnDefiningExtension = base.Columns["DefiningExtension"];
			this.columnDefiningProcessType = base.Columns["DefiningProcessType"];
			this.columnAssemblyReference = base.Columns["AssemblyReference"];
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private void InitClass() {
			this.columnImplementationName = new System.Data.DataColumn("ImplementationName", typeof(string), null, System.Data.MappingType.Attribute);
			base.Columns.Add(this.columnImplementationName);
			this.columnImplementationProgId = new System.Data.DataColumn("ImplementationProgId", typeof(string), null, System.Data.MappingType.Attribute);
			base.Columns.Add(this.columnImplementationProgId);
			this.columnPriority = new System.Data.DataColumn("Priority", typeof(int), null, System.Data.MappingType.Attribute);
			base.Columns.Add(this.columnPriority);
			this.columnDisplayName = new System.Data.DataColumn("DisplayName", typeof(string), null, System.Data.MappingType.Attribute);
			base.Columns.Add(this.columnDisplayName);
			this.columnConfiguratorProgId = new System.Data.DataColumn("ConfiguratorProgId", typeof(string), null, System.Data.MappingType.Attribute);
			base.Columns.Add(this.columnConfiguratorProgId);
			this.columnDefiningExtension = new System.Data.DataColumn("DefiningExtension", typeof(string), null, System.Data.MappingType.Attribute);
			base.Columns.Add(this.columnDefiningExtension);
			this.columnDefiningProcessType = new System.Data.DataColumn("DefiningProcessType", typeof(int), null, System.Data.MappingType.Attribute);
			base.Columns.Add(this.columnDefiningProcessType);
			this.columnAssemblyReference = new System.Data.DataColumn("AssemblyReference", typeof(string), null, System.Data.MappingType.Attribute);
			base.Columns.Add(this.columnAssemblyReference);
			this.Constraints.Add(new System.Data.UniqueConstraint("PluginKey", new System.Data.DataColumn[] {
							this.columnImplementationName}, false));
			this.columnImplementationName.AllowDBNull = false;
			this.columnImplementationName.Unique = true;
			this.columnImplementationName.Namespace = "";
			this.columnImplementationProgId.AllowDBNull = false;
			this.columnImplementationProgId.Namespace = "";
			this.columnPriority.AllowDBNull = false;
			this.columnPriority.Namespace = "";
			this.columnDisplayName.Namespace = "";
			this.columnConfiguratorProgId.Namespace = "";
			this.columnDefiningExtension.Namespace = "";
			this.columnDefiningProcessType.Namespace = "";
			this.columnAssemblyReference.Namespace = "";
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public ECPluginDetailsRow NewECPluginDetailsRow() {
			return ((ECPluginDetailsRow)(this.NewRow()));
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
			return new ECPluginDetailsRow(builder);
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		protected override System.Type GetRowType() {
			return typeof(ECPluginDetailsRow);
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		protected override void OnRowChanged(System.Data.DataRowChangeEventArgs e) {
			base.OnRowChanged(e);
			if ((this.ECPluginDetailsRowChanged != null)) {
				this.ECPluginDetailsRowChanged(this, new ECPluginDetailsRowChangeEvent(((ECPluginDetailsRow)(e.Row)), e.Action));
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		protected override void OnRowChanging(System.Data.DataRowChangeEventArgs e) {
			base.OnRowChanging(e);
			if ((this.ECPluginDetailsRowChanging != null)) {
				this.ECPluginDetailsRowChanging(this, new ECPluginDetailsRowChangeEvent(((ECPluginDetailsRow)(e.Row)), e.Action));
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		protected override void OnRowDeleted(System.Data.DataRowChangeEventArgs e) {
			base.OnRowDeleted(e);
			if ((this.ECPluginDetailsRowDeleted != null)) {
				this.ECPluginDetailsRowDeleted(this, new ECPluginDetailsRowChangeEvent(((ECPluginDetailsRow)(e.Row)), e.Action));
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		protected override void OnRowDeleting(System.Data.DataRowChangeEventArgs e) {
			base.OnRowDeleting(e);
			if ((this.ECPluginDetailsRowDeleting != null)) {
				this.ECPluginDetailsRowDeleting(this, new ECPluginDetailsRowChangeEvent(((ECPluginDetailsRow)(e.Row)), e.Action));
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public void RemoveECPluginDetailsRow(ECPluginDetailsRow row) {
			this.Rows.Remove(row);
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
			System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
			System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
			EncConverterPlugins ds = new EncConverterPlugins();
			xs.Add(ds.GetSchemaSerializable());
			System.Xml.Schema.XmlSchemaAny any1 = new System.Xml.Schema.XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = new decimal(0);
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			System.Xml.Schema.XmlSchemaAny any2 = new System.Xml.Schema.XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = new decimal(1);
			any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			System.Xml.Schema.XmlSchemaAttribute attribute1 = new System.Xml.Schema.XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			System.Xml.Schema.XmlSchemaAttribute attribute2 = new System.Xml.Schema.XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "ECPluginDetailsDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			return type;
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public partial class ECPluginDetailsRow : System.Data.DataRow {

		private ECPluginDetailsDataTable tableECPluginDetails;

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		internal ECPluginDetailsRow(System.Data.DataRowBuilder rb) :
				base(rb) {
			this.tableECPluginDetails = ((ECPluginDetailsDataTable)(this.Table));
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public string ImplementationName {
			get {
				return ((string)(this[this.tableECPluginDetails.ImplementationNameColumn]));
			}
			set {
				this[this.tableECPluginDetails.ImplementationNameColumn] = value;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public string ImplementationProgId {
			get {
				return ((string)(this[this.tableECPluginDetails.ImplementationProgIdColumn]));
			}
			set {
				this[this.tableECPluginDetails.ImplementationProgIdColumn] = value;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public int Priority {
			get {
				return ((int)(this[this.tableECPluginDetails.PriorityColumn]));
			}
			set {
				this[this.tableECPluginDetails.PriorityColumn] = value;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public string DisplayName {
			get {
				try {
					return ((string)(this[this.tableECPluginDetails.DisplayNameColumn]));
				}
				catch (System.InvalidCastException e) {
					throw new System.Data.StrongTypingException("The value for column \'DisplayName\' in table \'ECPluginDetails\' is DBNull.", e);
				}
			}
			set {
				this[this.tableECPluginDetails.DisplayNameColumn] = value;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public string ConfiguratorProgId {
			get {
				try {
					return ((string)(this[this.tableECPluginDetails.ConfiguratorProgIdColumn]));
				}
				catch (System.InvalidCastException e) {
					throw new System.Data.StrongTypingException("The value for column \'ConfiguratorProgId\' in table \'ECPluginDetails\' is DBNull.", e);
				}
			}
			set {
				this[this.tableECPluginDetails.ConfiguratorProgIdColumn] = value;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public string DefiningExtension {
			get {
				try {
					return ((string)(this[this.tableECPluginDetails.DefiningExtensionColumn]));
				}
				catch (System.InvalidCastException e) {
					throw new System.Data.StrongTypingException("The value for column \'DefiningExtension\' in table \'ECPluginDetails\' is DBNull.", e);
				}
			}
			set {
				this[this.tableECPluginDetails.DefiningExtensionColumn] = value;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public int DefiningProcessType {
			get {
				try {
					return ((int)(this[this.tableECPluginDetails.DefiningProcessTypeColumn]));
				}
				catch (System.InvalidCastException e) {
					throw new System.Data.StrongTypingException("The value for column \'DefiningProcessType\' in table \'ECPluginDetails\' is DBNull.", e);
				}
			}
			set {
				this[this.tableECPluginDetails.DefiningProcessTypeColumn] = value;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public string AssemblyReference {
			get {
				try {
					return ((string)(this[this.tableECPluginDetails.AssemblyReferenceColumn]));
				}
				catch (System.InvalidCastException e) {
					throw new System.Data.StrongTypingException("The value for column \'AssemblyReference\' in table \'ECPluginDetails\' is DBNull.", e);
				}
			}
			set {
				this[this.tableECPluginDetails.AssemblyReferenceColumn] = value;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public bool IsDisplayNameNull() {
			return this.IsNull(this.tableECPluginDetails.DisplayNameColumn);
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public void SetDisplayNameNull() {
			this[this.tableECPluginDetails.DisplayNameColumn] = System.Convert.DBNull;
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public bool IsConfiguratorProgIdNull() {
			return this.IsNull(this.tableECPluginDetails.ConfiguratorProgIdColumn);
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public void SetConfiguratorProgIdNull() {
			this[this.tableECPluginDetails.ConfiguratorProgIdColumn] = System.Convert.DBNull;
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public bool IsDefiningExtensionNull() {
			return this.IsNull(this.tableECPluginDetails.DefiningExtensionColumn);
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public void SetDefiningExtensionNull() {
			this[this.tableECPluginDetails.DefiningExtensionColumn] = System.Convert.DBNull;
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public bool IsDefiningProcessTypeNull() {
			return this.IsNull(this.tableECPluginDetails.DefiningProcessTypeColumn);
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public void SetDefiningProcessTypeNull() {
			this[this.tableECPluginDetails.DefiningProcessTypeColumn] = System.Convert.DBNull;
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public bool IsAssemblyReferenceNull() {
			return this.IsNull(this.tableECPluginDetails.AssemblyReferenceColumn);
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public void SetAssemblyReferenceNull() {
			this[this.tableECPluginDetails.AssemblyReferenceColumn] = System.Convert.DBNull;
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class ECPluginDetailsRowChangeEvent : System.EventArgs {

		private ECPluginDetailsRow eventRow;

		private System.Data.DataRowAction eventAction;

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public ECPluginDetailsRowChangeEvent(ECPluginDetailsRow row, System.Data.DataRowAction action) {
			this.eventRow = row;
			this.eventAction = action;
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public ECPluginDetailsRow Row {
			get {
				return this.eventRow;
			}
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public System.Data.DataRowAction Action {
			get {
				return this.eventAction;
			}
		}
	}
}
