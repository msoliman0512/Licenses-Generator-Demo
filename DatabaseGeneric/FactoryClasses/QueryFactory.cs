﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.7.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using Licenses_Generator_DBFirst.EntityClasses;
using Licenses_Generator_DBFirst.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.AdapterSpecific;
using SD.LLBLGen.Pro.QuerySpec;

namespace Licenses_Generator_DBFirst.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory : QueryFactoryBase2
	{
		/// <summary>Creates and returns a new EntityQuery for the Action entity</summary>
		public EntityQuery<ActionEntity> Action { get { return Create<ActionEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Address entity</summary>
		public EntityQuery<AddressEntity> Address { get { return Create<AddressEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the City entity</summary>
		public EntityQuery<CityEntity> City { get { return Create<CityEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Client entity</summary>
		public EntityQuery<ClientEntity> Client { get { return Create<ClientEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the dboAction entity</summary>
		public EntityQuery<dboActionEntity> dboAction { get { return Create<dboActionEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the dboAddress entity</summary>
		public EntityQuery<dboAddressEntity> dboAddress { get { return Create<dboAddressEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the dboCity entity</summary>
		public EntityQuery<dboCityEntity> dboCity { get { return Create<dboCityEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the dboClient entity</summary>
		public EntityQuery<dboClientEntity> dboClient { get { return Create<dboClientEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the dboDocument entity</summary>
		public EntityQuery<dboDocumentEntity> dboDocument { get { return Create<dboDocumentEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the dboGovernorate entity</summary>
		public EntityQuery<dboGovernorateEntity> dboGovernorate { get { return Create<dboGovernorateEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the dboLicense entity</summary>
		public EntityQuery<dboLicenseEntity> dboLicense { get { return Create<dboLicenseEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the dboLicenseRequest entity</summary>
		public EntityQuery<dboLicenseRequestEntity> dboLicenseRequest { get { return Create<dboLicenseRequestEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the dboLicenseType entity</summary>
		public EntityQuery<dboLicenseTypeEntity> dboLicenseType { get { return Create<dboLicenseTypeEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the dboUser entity</summary>
		public EntityQuery<dboUserEntity> dboUser { get { return Create<dboUserEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the dboVersionInfo entity</summary>
		public EntityQuery<dboVersionInfoEntity> dboVersionInfo { get { return Create<dboVersionInfoEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Document entity</summary>
		public EntityQuery<DocumentEntity> Document { get { return Create<DocumentEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Governorate entity</summary>
		public EntityQuery<GovernorateEntity> Governorate { get { return Create<GovernorateEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the License entity</summary>
		public EntityQuery<LicenseEntity> License { get { return Create<LicenseEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the LicenseRequest entity</summary>
		public EntityQuery<LicenseRequestEntity> LicenseRequest { get { return Create<LicenseRequestEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the LicenseType entity</summary>
		public EntityQuery<LicenseTypeEntity> LicenseType { get { return Create<LicenseTypeEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the User entity</summary>
		public EntityQuery<UserEntity> User { get { return Create<UserEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the VersionInfo entity</summary>
		public EntityQuery<VersionInfoEntity> VersionInfo { get { return Create<VersionInfoEntity>(); } }

		/// <inheritdoc/>
		protected override IElementCreatorCore CreateElementCreator() { return new ElementCreator(); }
 
	}
}