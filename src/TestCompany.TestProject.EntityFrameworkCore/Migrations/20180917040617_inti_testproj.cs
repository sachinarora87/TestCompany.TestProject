using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestCompany.TestProject.Migrations
{
    public partial class inti_testproj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpEntityChanges_AbpEntityChangeSets_EntityChangeSetId",
                table: "AbpEntityChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpFeatures_AbpEditions_EditionId",
                table: "AbpFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpPermissions_AbpRoles_RoleId",
                table: "AbpPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpPermissions_AbpUsers_UserId",
                table: "AbpPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_CreatorUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_DeleterUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_LastModifierUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpSettings_AbpUsers_UserId",
                table: "AbpSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_CreatorUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_DeleterUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpEditions_EditionId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_LastModifierUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserClaims_AbpUsers_UserId",
                table: "AbpUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserLogins_AbpUsers_UserId",
                table: "AbpUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserRoles_AbpUsers_UserId",
                table: "AbpUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_CreatorUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_DeleterUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_LastModifierUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserTokens",
                table: "AbpUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUsers",
                table: "AbpUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserRoles",
                table: "AbpUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserOrganizationUnits",
                table: "AbpUserOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserNotifications",
                table: "AbpUserNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserLogins",
                table: "AbpUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserLoginAttempts",
                table: "AbpUserLoginAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserClaims",
                table: "AbpUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserAccounts",
                table: "AbpUserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTenants",
                table: "AbpTenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTenantNotifications",
                table: "AbpTenantNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpSettings",
                table: "AbpSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoleClaims",
                table: "AbpRoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpPermissions",
                table: "AbpPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpNotificationSubscriptions",
                table: "AbpNotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpNotifications",
                table: "AbpNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpLanguageTexts",
                table: "AbpLanguageTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpLanguages",
                table: "AbpLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpFeatures",
                table: "AbpFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityPropertyChanges",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityChangeSets",
                table: "AbpEntityChangeSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityChanges",
                table: "AbpEntityChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEditions",
                table: "AbpEditions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpBackgroundJobs",
                table: "AbpBackgroundJobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpAuditLogs",
                table: "AbpAuditLogs");

            migrationBuilder.EnsureSchema(
                name: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpUserTokens",
                newName: "UserTokens",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpUsers",
                newName: "Users",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpUserRoles",
                newName: "UserRoles",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpUserOrganizationUnits",
                newName: "UserOrganizationUnits",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpUserNotifications",
                newName: "UserNotifications",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpUserLogins",
                newName: "UserLogins",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpUserLoginAttempts",
                newName: "UserLoginAttempts",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpUserClaims",
                newName: "UserClaims",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpUserAccounts",
                newName: "UserAccounts",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpTenants",
                newName: "Tenants",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpTenantNotifications",
                newName: "TenantNotifications",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpSettings",
                newName: "Settings",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpRoles",
                newName: "Roles",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpRoleClaims",
                newName: "RoleClaims",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpPermissions",
                newName: "Permissions",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnits",
                newName: "OrganizationUnits",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpNotificationSubscriptions",
                newName: "NotificationSubscriptions",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpNotifications",
                newName: "Notifications",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpLanguageTexts",
                newName: "LanguageTexts",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpLanguages",
                newName: "Languages",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpFeatures",
                newName: "Features",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpEntityPropertyChanges",
                newName: "EntityPropertyChanges",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpEntityChangeSets",
                newName: "EntityChangeSets",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpEntityChanges",
                newName: "EntityChanges",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpEditions",
                newName: "Editions",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpBackgroundJobs",
                newName: "BackgroundJobs",
                newSchema: "Abp");

            migrationBuilder.RenameTable(
                name: "AbpAuditLogs",
                newName: "AuditLogs",
                newSchema: "Abp");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserTokens_TenantId_UserId",
                schema: "Abp",
                table: "UserTokens",
                newName: "IX_UserTokens_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserTokens_UserId",
                schema: "Abp",
                table: "UserTokens",
                newName: "IX_UserTokens_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_TenantId_NormalizedUserName",
                schema: "Abp",
                table: "Users",
                newName: "IX_Users_TenantId_NormalizedUserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_TenantId_NormalizedEmailAddress",
                schema: "Abp",
                table: "Users",
                newName: "IX_Users_TenantId_NormalizedEmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_LastModifierUserId",
                schema: "Abp",
                table: "Users",
                newName: "IX_Users_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_DeleterUserId",
                schema: "Abp",
                table: "Users",
                newName: "IX_Users_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_CreatorUserId",
                schema: "Abp",
                table: "Users",
                newName: "IX_Users_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_TenantId_UserId",
                schema: "Abp",
                table: "UserRoles",
                newName: "IX_UserRoles_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_TenantId_RoleId",
                schema: "Abp",
                table: "UserRoles",
                newName: "IX_UserRoles_TenantId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_UserId",
                schema: "Abp",
                table: "UserRoles",
                newName: "IX_UserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_UserId",
                schema: "Abp",
                table: "UserOrganizationUnits",
                newName: "IX_UserOrganizationUnits_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId",
                schema: "Abp",
                table: "UserOrganizationUnits",
                newName: "IX_UserOrganizationUnits_TenantId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserNotifications_UserId_State_CreationTime",
                schema: "Abp",
                table: "UserNotifications",
                newName: "IX_UserNotifications_UserId_State_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey",
                schema: "Abp",
                table: "UserLogins",
                newName: "IX_UserLogins_TenantId_LoginProvider_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_TenantId_UserId",
                schema: "Abp",
                table: "UserLogins",
                newName: "IX_UserLogins_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_UserId",
                schema: "Abp",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                schema: "Abp",
                table: "UserLoginAttempts",
                newName: "IX_UserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLoginAttempts_UserId_TenantId",
                schema: "Abp",
                table: "UserLoginAttempts",
                newName: "IX_UserLoginAttempts_UserId_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserClaims_TenantId_ClaimType",
                schema: "Abp",
                table: "UserClaims",
                newName: "IX_UserClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserClaims_UserId",
                schema: "Abp",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_TenantId_UserName",
                schema: "Abp",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TenantId_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_TenantId_UserId",
                schema: "Abp",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_TenantId_EmailAddress",
                schema: "Abp",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TenantId_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_UserName",
                schema: "Abp",
                table: "UserAccounts",
                newName: "IX_UserAccounts_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_EmailAddress",
                schema: "Abp",
                table: "UserAccounts",
                newName: "IX_UserAccounts_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_TenancyName",
                schema: "Abp",
                table: "Tenants",
                newName: "IX_Tenants_TenancyName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_LastModifierUserId",
                schema: "Abp",
                table: "Tenants",
                newName: "IX_Tenants_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_EditionId",
                schema: "Abp",
                table: "Tenants",
                newName: "IX_Tenants_EditionId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_DeleterUserId",
                schema: "Abp",
                table: "Tenants",
                newName: "IX_Tenants_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_CreatorUserId",
                schema: "Abp",
                table: "Tenants",
                newName: "IX_Tenants_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenantNotifications_TenantId",
                schema: "Abp",
                table: "TenantNotifications",
                newName: "IX_TenantNotifications_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSettings_TenantId_Name",
                schema: "Abp",
                table: "Settings",
                newName: "IX_Settings_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSettings_UserId",
                schema: "Abp",
                table: "Settings",
                newName: "IX_Settings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_TenantId_NormalizedName",
                schema: "Abp",
                table: "Roles",
                newName: "IX_Roles_TenantId_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_LastModifierUserId",
                schema: "Abp",
                table: "Roles",
                newName: "IX_Roles_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_DeleterUserId",
                schema: "Abp",
                table: "Roles",
                newName: "IX_Roles_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_CreatorUserId",
                schema: "Abp",
                table: "Roles",
                newName: "IX_Roles_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoleClaims_TenantId_ClaimType",
                schema: "Abp",
                table: "RoleClaims",
                newName: "IX_RoleClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoleClaims_RoleId",
                schema: "Abp",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_UserId",
                schema: "Abp",
                table: "Permissions",
                newName: "IX_Permissions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_RoleId",
                schema: "Abp",
                table: "Permissions",
                newName: "IX_Permissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_TenantId_Name",
                schema: "Abp",
                table: "Permissions",
                newName: "IX_Permissions_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_TenantId_Code",
                schema: "Abp",
                table: "OrganizationUnits",
                newName: "IX_OrganizationUnits_TenantId_Code");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_ParentId",
                schema: "Abp",
                table: "OrganizationUnits",
                newName: "IX_OrganizationUnits_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                schema: "Abp",
                table: "NotificationSubscriptions",
                newName: "IX_NotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                schema: "Abp",
                table: "NotificationSubscriptions",
                newName: "IX_NotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key",
                schema: "Abp",
                table: "LanguageTexts",
                newName: "IX_LanguageTexts_TenantId_Source_LanguageName_Key");

            migrationBuilder.RenameIndex(
                name: "IX_AbpLanguages_TenantId_Name",
                schema: "Abp",
                table: "Languages",
                newName: "IX_Languages_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpFeatures_TenantId_Name",
                schema: "Abp",
                table: "Features",
                newName: "IX_Features_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpFeatures_EditionId_Name",
                schema: "Abp",
                table: "Features",
                newName: "IX_Features_EditionId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityPropertyChanges_EntityChangeId",
                schema: "Abp",
                table: "EntityPropertyChanges",
                newName: "IX_EntityPropertyChanges_EntityChangeId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChangeSets_TenantId_UserId",
                schema: "Abp",
                table: "EntityChangeSets",
                newName: "IX_EntityChangeSets_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChangeSets_TenantId_Reason",
                schema: "Abp",
                table: "EntityChangeSets",
                newName: "IX_EntityChangeSets_TenantId_Reason");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChangeSets_TenantId_CreationTime",
                schema: "Abp",
                table: "EntityChangeSets",
                newName: "IX_EntityChangeSets_TenantId_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChanges_EntityTypeFullName_EntityId",
                schema: "Abp",
                table: "EntityChanges",
                newName: "IX_EntityChanges_EntityTypeFullName_EntityId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChanges_EntityChangeSetId",
                schema: "Abp",
                table: "EntityChanges",
                newName: "IX_EntityChanges_EntityChangeSetId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime",
                schema: "Abp",
                table: "BackgroundJobs",
                newName: "IX_BackgroundJobs_IsAbandoned_NextTryTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_UserId",
                schema: "Abp",
                table: "AuditLogs",
                newName: "IX_AuditLogs_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
                schema: "Abp",
                table: "AuditLogs",
                newName: "IX_AuditLogs_TenantId_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionDuration",
                schema: "Abp",
                table: "AuditLogs",
                newName: "IX_AuditLogs_TenantId_ExecutionDuration");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                schema: "Abp",
                table: "UserTokens",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                schema: "Abp",
                table: "UserTokens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "Abp",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                schema: "Abp",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrganizationUnits",
                schema: "Abp",
                table: "UserOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserNotifications",
                schema: "Abp",
                table: "UserNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                schema: "Abp",
                table: "UserLogins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLoginAttempts",
                schema: "Abp",
                table: "UserLoginAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                schema: "Abp",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAccounts",
                schema: "Abp",
                table: "UserAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tenants",
                schema: "Abp",
                table: "Tenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TenantNotifications",
                schema: "Abp",
                table: "TenantNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settings",
                schema: "Abp",
                table: "Settings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                schema: "Abp",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                schema: "Abp",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                schema: "Abp",
                table: "Permissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganizationUnits",
                schema: "Abp",
                table: "OrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotificationSubscriptions",
                schema: "Abp",
                table: "NotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                schema: "Abp",
                table: "Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageTexts",
                schema: "Abp",
                table: "LanguageTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                schema: "Abp",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Features",
                schema: "Abp",
                table: "Features",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityPropertyChanges",
                schema: "Abp",
                table: "EntityPropertyChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityChangeSets",
                schema: "Abp",
                table: "EntityChangeSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityChanges",
                schema: "Abp",
                table: "EntityChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Editions",
                schema: "Abp",
                table: "Editions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BackgroundJobs",
                schema: "Abp",
                table: "BackgroundJobs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditLogs",
                schema: "Abp",
                table: "AuditLogs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderNumber = table.Column<int>(nullable: false),
                    InvoiceNumber = table.Column<int>(nullable: false),
                    PalletId = table.Column<long>(nullable: false),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalSchema: "Abp",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Users_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalSchema: "Abp",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceLines",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    ArticleNumber = table.Column<string>(nullable: true),
                    ArticleDescription = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    PackSize = table.Column<int>(nullable: false),
                    CartonNumber = table.Column<int>(nullable: false),
                    CartonWeight = table.Column<decimal>(nullable: false),
                    ChargeWeight = table.Column<decimal>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: false),
                    InvoiceId = table.Column<long>(nullable: false),
                    TenantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceLines_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalSchema: "Abp",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceLines_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceLines_Users_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalSchema: "Abp",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceLines_CartonNumber",
                table: "InvoiceLines",
                column: "CartonNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceLines_CreatorUserId",
                table: "InvoiceLines",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceLines_InvoiceId",
                table: "InvoiceLines",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceLines_LastModifierUserId",
                table: "InvoiceLines",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CreatorUserId",
                table: "Invoices",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_LastModifierUserId",
                table: "Invoices",
                column: "LastModifierUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityChanges_EntityChangeSets_EntityChangeSetId",
                schema: "Abp",
                table: "EntityChanges",
                column: "EntityChangeSetId",
                principalSchema: "Abp",
                principalTable: "EntityChangeSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityPropertyChanges_EntityChanges_EntityChangeId",
                schema: "Abp",
                table: "EntityPropertyChanges",
                column: "EntityChangeId",
                principalSchema: "Abp",
                principalTable: "EntityChanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Editions_EditionId",
                schema: "Abp",
                table: "Features",
                column: "EditionId",
                principalSchema: "Abp",
                principalTable: "Editions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationUnits_OrganizationUnits_ParentId",
                schema: "Abp",
                table: "OrganizationUnits",
                column: "ParentId",
                principalSchema: "Abp",
                principalTable: "OrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                schema: "Abp",
                table: "Permissions",
                column: "RoleId",
                principalSchema: "Abp",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Users_UserId",
                schema: "Abp",
                table: "Permissions",
                column: "UserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "Abp",
                table: "RoleClaims",
                column: "RoleId",
                principalSchema: "Abp",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_CreatorUserId",
                schema: "Abp",
                table: "Roles",
                column: "CreatorUserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_DeleterUserId",
                schema: "Abp",
                table: "Roles",
                column: "DeleterUserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_LastModifierUserId",
                schema: "Abp",
                table: "Roles",
                column: "LastModifierUserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Settings_Users_UserId",
                schema: "Abp",
                table: "Settings",
                column: "UserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_CreatorUserId",
                schema: "Abp",
                table: "Tenants",
                column: "CreatorUserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_DeleterUserId",
                schema: "Abp",
                table: "Tenants",
                column: "DeleterUserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Editions_EditionId",
                schema: "Abp",
                table: "Tenants",
                column: "EditionId",
                principalSchema: "Abp",
                principalTable: "Editions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_LastModifierUserId",
                schema: "Abp",
                table: "Tenants",
                column: "LastModifierUserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_UserId",
                schema: "Abp",
                table: "UserClaims",
                column: "UserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Users_UserId",
                schema: "Abp",
                table: "UserLogins",
                column: "UserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "Abp",
                table: "UserRoles",
                column: "UserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_CreatorUserId",
                schema: "Abp",
                table: "Users",
                column: "CreatorUserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_DeleterUserId",
                schema: "Abp",
                table: "Users",
                column: "DeleterUserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_LastModifierUserId",
                schema: "Abp",
                table: "Users",
                column: "LastModifierUserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_Users_UserId",
                schema: "Abp",
                table: "UserTokens",
                column: "UserId",
                principalSchema: "Abp",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityChanges_EntityChangeSets_EntityChangeSetId",
                schema: "Abp",
                table: "EntityChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityPropertyChanges_EntityChanges_EntityChangeId",
                schema: "Abp",
                table: "EntityPropertyChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Editions_EditionId",
                schema: "Abp",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationUnits_OrganizationUnits_ParentId",
                schema: "Abp",
                table: "OrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                schema: "Abp",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Users_UserId",
                schema: "Abp",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "Abp",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_CreatorUserId",
                schema: "Abp",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_DeleterUserId",
                schema: "Abp",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_LastModifierUserId",
                schema: "Abp",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Settings_Users_UserId",
                schema: "Abp",
                table: "Settings");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_CreatorUserId",
                schema: "Abp",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_DeleterUserId",
                schema: "Abp",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Editions_EditionId",
                schema: "Abp",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_LastModifierUserId",
                schema: "Abp",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_UserId",
                schema: "Abp",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Users_UserId",
                schema: "Abp",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "Abp",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_CreatorUserId",
                schema: "Abp",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_DeleterUserId",
                schema: "Abp",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_LastModifierUserId",
                schema: "Abp",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_Users_UserId",
                schema: "Abp",
                table: "UserTokens");

            migrationBuilder.DropTable(
                name: "InvoiceLines");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                schema: "Abp",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "Abp",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                schema: "Abp",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrganizationUnits",
                schema: "Abp",
                table: "UserOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserNotifications",
                schema: "Abp",
                table: "UserNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                schema: "Abp",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLoginAttempts",
                schema: "Abp",
                table: "UserLoginAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                schema: "Abp",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAccounts",
                schema: "Abp",
                table: "UserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tenants",
                schema: "Abp",
                table: "Tenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TenantNotifications",
                schema: "Abp",
                table: "TenantNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Settings",
                schema: "Abp",
                table: "Settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                schema: "Abp",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                schema: "Abp",
                table: "RoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                schema: "Abp",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganizationUnits",
                schema: "Abp",
                table: "OrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotificationSubscriptions",
                schema: "Abp",
                table: "NotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                schema: "Abp",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageTexts",
                schema: "Abp",
                table: "LanguageTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                schema: "Abp",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Features",
                schema: "Abp",
                table: "Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityPropertyChanges",
                schema: "Abp",
                table: "EntityPropertyChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityChangeSets",
                schema: "Abp",
                table: "EntityChangeSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityChanges",
                schema: "Abp",
                table: "EntityChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Editions",
                schema: "Abp",
                table: "Editions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BackgroundJobs",
                schema: "Abp",
                table: "BackgroundJobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditLogs",
                schema: "Abp",
                table: "AuditLogs");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                schema: "Abp",
                table: "UserTokens");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "Abp",
                newName: "AbpUserTokens");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "Abp",
                newName: "AbpUsers");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "Abp",
                newName: "AbpUserRoles");

            migrationBuilder.RenameTable(
                name: "UserOrganizationUnits",
                schema: "Abp",
                newName: "AbpUserOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "UserNotifications",
                schema: "Abp",
                newName: "AbpUserNotifications");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "Abp",
                newName: "AbpUserLogins");

            migrationBuilder.RenameTable(
                name: "UserLoginAttempts",
                schema: "Abp",
                newName: "AbpUserLoginAttempts");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "Abp",
                newName: "AbpUserClaims");

            migrationBuilder.RenameTable(
                name: "UserAccounts",
                schema: "Abp",
                newName: "AbpUserAccounts");

            migrationBuilder.RenameTable(
                name: "Tenants",
                schema: "Abp",
                newName: "AbpTenants");

            migrationBuilder.RenameTable(
                name: "TenantNotifications",
                schema: "Abp",
                newName: "AbpTenantNotifications");

            migrationBuilder.RenameTable(
                name: "Settings",
                schema: "Abp",
                newName: "AbpSettings");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "Abp",
                newName: "AbpRoles");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "Abp",
                newName: "AbpRoleClaims");

            migrationBuilder.RenameTable(
                name: "Permissions",
                schema: "Abp",
                newName: "AbpPermissions");

            migrationBuilder.RenameTable(
                name: "OrganizationUnits",
                schema: "Abp",
                newName: "AbpOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "NotificationSubscriptions",
                schema: "Abp",
                newName: "AbpNotificationSubscriptions");

            migrationBuilder.RenameTable(
                name: "Notifications",
                schema: "Abp",
                newName: "AbpNotifications");

            migrationBuilder.RenameTable(
                name: "LanguageTexts",
                schema: "Abp",
                newName: "AbpLanguageTexts");

            migrationBuilder.RenameTable(
                name: "Languages",
                schema: "Abp",
                newName: "AbpLanguages");

            migrationBuilder.RenameTable(
                name: "Features",
                schema: "Abp",
                newName: "AbpFeatures");

            migrationBuilder.RenameTable(
                name: "EntityPropertyChanges",
                schema: "Abp",
                newName: "AbpEntityPropertyChanges");

            migrationBuilder.RenameTable(
                name: "EntityChangeSets",
                schema: "Abp",
                newName: "AbpEntityChangeSets");

            migrationBuilder.RenameTable(
                name: "EntityChanges",
                schema: "Abp",
                newName: "AbpEntityChanges");

            migrationBuilder.RenameTable(
                name: "Editions",
                schema: "Abp",
                newName: "AbpEditions");

            migrationBuilder.RenameTable(
                name: "BackgroundJobs",
                schema: "Abp",
                newName: "AbpBackgroundJobs");

            migrationBuilder.RenameTable(
                name: "AuditLogs",
                schema: "Abp",
                newName: "AbpAuditLogs");

            migrationBuilder.RenameIndex(
                name: "IX_UserTokens_TenantId_UserId",
                table: "AbpUserTokens",
                newName: "IX_AbpUserTokens_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTokens_UserId",
                table: "AbpUserTokens",
                newName: "IX_AbpUserTokens_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TenantId_NormalizedUserName",
                table: "AbpUsers",
                newName: "IX_AbpUsers_TenantId_NormalizedUserName");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TenantId_NormalizedEmailAddress",
                table: "AbpUsers",
                newName: "IX_AbpUsers_TenantId_NormalizedEmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Users_LastModifierUserId",
                table: "AbpUsers",
                newName: "IX_AbpUsers_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_DeleterUserId",
                table: "AbpUsers",
                newName: "IX_AbpUsers_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CreatorUserId",
                table: "AbpUsers",
                newName: "IX_AbpUsers_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_TenantId_UserId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_TenantId_RoleId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_TenantId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganizationUnits_TenantId_UserId",
                table: "AbpUserOrganizationUnits",
                newName: "IX_AbpUserOrganizationUnits_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganizationUnits_TenantId_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                newName: "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_UserNotifications_UserId_State_CreationTime",
                table: "AbpUserNotifications",
                newName: "IX_AbpUserNotifications_UserId_State_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_TenantId_LoginProvider_ProviderKey",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_TenantId_UserId",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                table: "AbpUserLoginAttempts",
                newName: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result");

            migrationBuilder.RenameIndex(
                name: "IX_UserLoginAttempts_UserId_TenantId",
                table: "AbpUserLoginAttempts",
                newName: "IX_AbpUserLoginAttempts_UserId_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_TenantId_ClaimType",
                table: "AbpUserClaims",
                newName: "IX_AbpUserClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                table: "AbpUserClaims",
                newName: "IX_AbpUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TenantId_UserName",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_TenantId_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TenantId_UserId",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TenantId_EmailAddress",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_TenantId_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_UserName",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_EmailAddress",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_TenancyName",
                table: "AbpTenants",
                newName: "IX_AbpTenants_TenancyName");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_LastModifierUserId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_EditionId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_EditionId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_DeleterUserId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_CreatorUserId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_TenantNotifications_TenantId",
                table: "AbpTenantNotifications",
                newName: "IX_AbpTenantNotifications_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_Settings_TenantId_Name",
                table: "AbpSettings",
                newName: "IX_AbpSettings_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Settings_UserId",
                table: "AbpSettings",
                newName: "IX_AbpSettings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_TenantId_NormalizedName",
                table: "AbpRoles",
                newName: "IX_AbpRoles_TenantId_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_LastModifierUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_DeleterUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_CreatorUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_TenantId_ClaimType",
                table: "AbpRoleClaims",
                newName: "IX_AbpRoleClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "AbpRoleClaims",
                newName: "IX_AbpRoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_UserId",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_RoleId",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_TenantId_Name",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationUnits_TenantId_Code",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_TenantId_Code");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_LanguageTexts_TenantId_Source_LanguageName_Key",
                table: "AbpLanguageTexts",
                newName: "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key");

            migrationBuilder.RenameIndex(
                name: "IX_Languages_TenantId_Name",
                table: "AbpLanguages",
                newName: "IX_AbpLanguages_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Features_TenantId_Name",
                table: "AbpFeatures",
                newName: "IX_AbpFeatures_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Features_EditionId_Name",
                table: "AbpFeatures",
                newName: "IX_AbpFeatures_EditionId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_EntityPropertyChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                newName: "IX_AbpEntityPropertyChanges_EntityChangeId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChangeSets_TenantId_UserId",
                table: "AbpEntityChangeSets",
                newName: "IX_AbpEntityChangeSets_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChangeSets_TenantId_Reason",
                table: "AbpEntityChangeSets",
                newName: "IX_AbpEntityChangeSets_TenantId_Reason");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChangeSets_TenantId_CreationTime",
                table: "AbpEntityChangeSets",
                newName: "IX_AbpEntityChangeSets_TenantId_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChanges_EntityTypeFullName_EntityId",
                table: "AbpEntityChanges",
                newName: "IX_AbpEntityChanges_EntityTypeFullName_EntityId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChanges_EntityChangeSetId",
                table: "AbpEntityChanges",
                newName: "IX_AbpEntityChanges_EntityChangeSetId");

            migrationBuilder.RenameIndex(
                name: "IX_BackgroundJobs_IsAbandoned_NextTryTime",
                table: "AbpBackgroundJobs",
                newName: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime");

            migrationBuilder.RenameIndex(
                name: "IX_AuditLogs_TenantId_UserId",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AuditLogs_TenantId_ExecutionTime",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_AuditLogs_TenantId_ExecutionDuration",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_ExecutionDuration");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserTokens",
                table: "AbpUserTokens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUsers",
                table: "AbpUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserRoles",
                table: "AbpUserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserOrganizationUnits",
                table: "AbpUserOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserNotifications",
                table: "AbpUserNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserLogins",
                table: "AbpUserLogins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserLoginAttempts",
                table: "AbpUserLoginAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserClaims",
                table: "AbpUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserAccounts",
                table: "AbpUserAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTenants",
                table: "AbpTenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTenantNotifications",
                table: "AbpTenantNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpSettings",
                table: "AbpSettings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoleClaims",
                table: "AbpRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpPermissions",
                table: "AbpPermissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpNotificationSubscriptions",
                table: "AbpNotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpNotifications",
                table: "AbpNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpLanguageTexts",
                table: "AbpLanguageTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpLanguages",
                table: "AbpLanguages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpFeatures",
                table: "AbpFeatures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityPropertyChanges",
                table: "AbpEntityPropertyChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityChangeSets",
                table: "AbpEntityChangeSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityChanges",
                table: "AbpEntityChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEditions",
                table: "AbpEditions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpBackgroundJobs",
                table: "AbpBackgroundJobs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpAuditLogs",
                table: "AbpAuditLogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpEntityChanges_AbpEntityChangeSets_EntityChangeSetId",
                table: "AbpEntityChanges",
                column: "EntityChangeSetId",
                principalTable: "AbpEntityChangeSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                column: "EntityChangeId",
                principalTable: "AbpEntityChanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpFeatures_AbpEditions_EditionId",
                table: "AbpFeatures",
                column: "EditionId",
                principalTable: "AbpEditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                column: "ParentId",
                principalTable: "AbpOrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpPermissions_AbpRoles_RoleId",
                table: "AbpPermissions",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpPermissions_AbpUsers_UserId",
                table: "AbpPermissions",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_CreatorUserId",
                table: "AbpRoles",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_DeleterUserId",
                table: "AbpRoles",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_LastModifierUserId",
                table: "AbpRoles",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpSettings_AbpUsers_UserId",
                table: "AbpSettings",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_CreatorUserId",
                table: "AbpTenants",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_DeleterUserId",
                table: "AbpTenants",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpEditions_EditionId",
                table: "AbpTenants",
                column: "EditionId",
                principalTable: "AbpEditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_LastModifierUserId",
                table: "AbpTenants",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserClaims_AbpUsers_UserId",
                table: "AbpUserClaims",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserLogins_AbpUsers_UserId",
                table: "AbpUserLogins",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserRoles_AbpUsers_UserId",
                table: "AbpUserRoles",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_CreatorUserId",
                table: "AbpUsers",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_DeleterUserId",
                table: "AbpUsers",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_LastModifierUserId",
                table: "AbpUsers",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
