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

	/// <summary>Entity class which represents the entity 'dboCity'.<br/><br/></summary>
	[Serializable]
	public partial class dboCityEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static dboCityEntityStaticMetaData _staticMetaData = new dboCityEntityStaticMetaData();
		private static dboCityRelations _relationsFactory = new dboCityRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class dboCityEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public dboCityEntityStaticMetaData()
			{
				SetEntityCoreInfo("dboCityEntity", InheritanceHierarchyType.None, false, (int)Licenses_Generator_DBFirst.EntityType.dboCityEntity, typeof(dboCityEntity), typeof(dboCityEntityFactory), false);
			}
		}

		/// <summary>Static ctor</summary>
		static dboCityEntity()
		{
		}

		/// <summary> CTor</summary>
		public dboCityEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public dboCityEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this dboCityEntity</param>
		public dboCityEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for dboCity which data should be fetched into this dboCity object</param>
		public dboCityEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for dboCity which data should be fetched into this dboCity object</param>
		/// <param name="validator">The custom validator object for this dboCityEntity</param>
		public dboCityEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected dboCityEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
		/// <param name="validator">The validator object for this dboCityEntity</param>
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
		public static dboCityRelations Relations { get { return _relationsFactory; } }

		/// <summary>The GovernorateId property of the Entity dboCity<br/><br/></summary>
		/// <remarks>Mapped on  table field: "City"."GovernorateId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 GovernorateId
		{
			get { return (System.Int32)GetValue((int)dboCityFieldIndex.GovernorateId, true); }
			set	{ SetValue((int)dboCityFieldIndex.GovernorateId, value); }
		}

		/// <summary>The Id property of the Entity dboCity<br/><br/></summary>
		/// <remarks>Mapped on  table field: "City"."id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)dboCityFieldIndex.Id, true); }
			set { SetValue((int)dboCityFieldIndex.Id, value); }		}

		/// <summary>The Name property of the Entity dboCity<br/><br/></summary>
		/// <remarks>Mapped on  table field: "City"."name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)dboCityFieldIndex.Name, true); }
			set	{ SetValue((int)dboCityFieldIndex.Name, value); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace Licenses_Generator_DBFirst
{
	public enum dboCityFieldIndex
	{
		///<summary>GovernorateId. </summary>
		GovernorateId,
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Licenses_Generator_DBFirst.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: dboCity. </summary>
	public partial class dboCityRelations: RelationFactory
	{

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticdboCityRelations
	{

		/// <summary>CTor</summary>
		static StaticdboCityRelations() { }
	}
}