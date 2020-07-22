﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.7.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Licenses_Generator_DBFirst.HelperClasses;
using Licenses_Generator_DBFirst.FactoryClasses;
using Licenses_Generator_DBFirst.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Licenses_Generator_DBFirst.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'dboDocument'.<br/><br/></summary>
	[Serializable]
	public partial class dboDocumentEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static dboDocumentEntityStaticMetaData _staticMetaData = new dboDocumentEntityStaticMetaData();
		private static dboDocumentRelations _relationsFactory = new dboDocumentRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class dboDocumentEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public dboDocumentEntityStaticMetaData()
			{
				SetEntityCoreInfo("dboDocumentEntity", InheritanceHierarchyType.None, false, (int)Licenses_Generator_DBFirst.EntityType.dboDocumentEntity, typeof(dboDocumentEntity), typeof(dboDocumentEntityFactory), false);
			}
		}

		/// <summary>Static ctor</summary>
		static dboDocumentEntity()
		{
		}

		/// <summary> CTor</summary>
		public dboDocumentEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public dboDocumentEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this dboDocumentEntity</param>
		public dboDocumentEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for dboDocument which data should be fetched into this dboDocument object</param>
		public dboDocumentEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for dboDocument which data should be fetched into this dboDocument object</param>
		/// <param name="validator">The custom validator object for this dboDocumentEntity</param>
		public dboDocumentEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected dboDocumentEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this dboDocumentEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static dboDocumentRelations Relations { get { return _relationsFactory; } }

		/// <summary>The ClientId property of the Entity dboDocument<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Documents"."ClientId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ClientId
		{
			get { return (System.Int32)GetValue((int)dboDocumentFieldIndex.ClientId, true); }
			set	{ SetValue((int)dboDocumentFieldIndex.ClientId, value); }
		}

		/// <summary>The Comments property of the Entity dboDocument<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Documents"."comments".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Comments
		{
			get { return (System.String)GetValue((int)dboDocumentFieldIndex.Comments, true); }
			set	{ SetValue((int)dboDocumentFieldIndex.Comments, value); }
		}

		/// <summary>The Id property of the Entity dboDocument<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Documents"."id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)dboDocumentFieldIndex.Id, true); }
			set { SetValue((int)dboDocumentFieldIndex.Id, value); }		}

		/// <summary>The Link property of the Entity dboDocument<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Documents"."link".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Link
		{
			get { return (System.String)GetValue((int)dboDocumentFieldIndex.Link, true); }
			set	{ SetValue((int)dboDocumentFieldIndex.Link, value); }
		}

		/// <summary>The RequestId property of the Entity dboDocument<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Documents"."RequestId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RequestId
		{
			get { return (System.Int32)GetValue((int)dboDocumentFieldIndex.RequestId, true); }
			set	{ SetValue((int)dboDocumentFieldIndex.RequestId, value); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace Licenses_Generator_DBFirst
{
	public enum dboDocumentFieldIndex
	{
		///<summary>ClientId. </summary>
		ClientId,
		///<summary>Comments. </summary>
		Comments,
		///<summary>Id. </summary>
		Id,
		///<summary>Link. </summary>
		Link,
		///<summary>RequestId. </summary>
		RequestId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Licenses_Generator_DBFirst.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: dboDocument. </summary>
	public partial class dboDocumentRelations: RelationFactory
	{

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticdboDocumentRelations
	{

		/// <summary>CTor</summary>
		static StaticdboDocumentRelations() { }
	}
}