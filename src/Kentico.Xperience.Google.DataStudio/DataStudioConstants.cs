﻿using CMS.Activities;
using CMS.Automation;
using CMS.ContactManagement;
using CMS.DataEngine;
using CMS.DataProtection;
using CMS.Globalization;
using CMS.Membership;
using CMS.SiteProvider;
using CMS.WorkflowEngine;

using Kentico.Xperience.Google.DataStudio.Models;

namespace Kentico.Xperience.Google.DataStudio
{
    public class DataStudioConstants
    {
        public const string REPORT_PATH = "\\App_Data\\CMSModules\\Kentico.Xperience.Google.DataStudio\\datastudio.json";


        public static FieldSet activityFieldSet = new FieldSet
        {
            ObjectType = ActivityInfo.OBJECT_TYPE,
            DateFilterField = nameof(ActivityInfo.ActivityCreated),
            Fields = new FieldDefinition[] {
                new FieldDefinition
                {
                    Name = nameof(ActivityInfo.ActivityID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition
                {
                    Name = nameof(ActivityInfo.ActivityTitle),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition
                {
                    Name = nameof(ActivityInfo.ActivityURL),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition
                {
                    Name = nameof(ActivityInfo.ActivityCampaign),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition
                {
                    Name = nameof(ActivityInfo.ActivityUTMSource),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition
                {
                    Name = nameof(ActivityInfo.ActivityUTMContent),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition
                {
                    Name = nameof(ActivityInfo.ActivityContactID),
                    DataType = FieldDataType.Integer,
                    IsMetric = true
                },
                new FieldDefinition
                {
                    Name = nameof(ActivityInfo.ActivityCreated),
                    DataType = FieldDataType.DateTime
                },
                new FieldDefinition
                {
                    Name = nameof(ActivityInfo.ActivityType),
                    DataType = FieldDataType.Text
                }
            }
        };


        public static FieldSet automationStateFieldSet = new FieldSet
        {
            ObjectType = "cms.automationstate",
            DateFilterField = nameof(AutomationStateInfo.StateCreated),
            Fields = new FieldDefinition[]
            {
                new FieldDefinition {
                    Name = nameof(AutomationStateInfo.StateCreated),
                    DataType = FieldDataType.DateTime
                },
                new FieldDefinition {
                    Name = nameof(AutomationStateInfo.StateID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition {
                    Name = nameof(AutomationStateInfo.StateStepID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition {
                    Name = nameof(AutomationStateInfo.StateObjectID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition {
                    Name = nameof(AutomationStateInfo.StateObjectType),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition {
                    Name = nameof(AutomationStateInfo.StateWorkflowID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition {
                    Name = nameof(AutomationStateInfo.StateStatus),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition {
                    Name = nameof(AutomationStateInfo.StateSiteID),
                    DataType = FieldDataType.Integer
                }
            }
        };


        public static FieldSet consentAgreementFieldSet = new FieldSet
        {
            ObjectType = ConsentAgreementInfo.OBJECT_TYPE,
            DateFilterField = nameof(ConsentAgreementInfo.ConsentAgreementTime),
            Fields = new FieldDefinition[]
            {
                new FieldDefinition {
                    Name = nameof(ConsentAgreementInfo.ConsentAgreementTime),
                    DataType = FieldDataType.DateTime
                },
                new FieldDefinition {
                    Name = nameof(ConsentAgreementInfo.ConsentAgreementRevoked),
                    DataType = FieldDataType.Boolean
                },
                new FieldDefinition {
                    Name = nameof(ConsentAgreementInfo.ConsentAgreementContactID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition {
                    Name = nameof(ConsentAgreementInfo.ConsentAgreementConsentID),
                    DataType = FieldDataType.Integer
                }
            }
        };


        public static FieldSet consentFieldSet = new FieldSet
        {
            ObjectType = ConsentInfo.OBJECT_TYPE,
            Fields = new FieldDefinition[]
            {
                new FieldDefinition {
                    Name = nameof(ConsentInfo.ConsentID),
                    DataType = FieldDataType.Integer,
                },
                new FieldDefinition {
                    Name = nameof(ConsentInfo.ConsentLastModified),
                    DataType = FieldDataType.DateTime
                },
                new FieldDefinition {
                    Name = nameof(ConsentInfo.ConsentDisplayName),
                    DataType = FieldDataType.Text
                }
            }
        };


        public static FieldSet contactFieldSet = new FieldSet
        {
            ObjectType = ContactInfo.OBJECT_TYPE,
            DateFilterField = nameof(ContactInfo.ContactCreated),
            Fields = new FieldDefinition[]
            {
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactID),
                    DataType = FieldDataType.Integer,
                    IsMetric = true
                },
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactFirstName),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactMiddleName),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactLastName),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactJobTitle),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactCompanyName),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactAddress1),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactCity),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactZIP),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactCountryID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactStateID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactEmail),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition {
                    Name = nameof(ContactInfo.ContactCreated),
                    DataType = FieldDataType.DateTime
                }
            }
        };


        public static FieldSet contactGroupFieldSet = new FieldSet
        {
            ObjectType = ContactGroupInfo.OBJECT_TYPE,
            DateFilterField = nameof(ContactGroupInfo.ContactGroupLastModified),
            Fields = new FieldDefinition[]
            {
                new FieldDefinition {
                    Name = nameof(ContactGroupInfo.ContactGroupLastModified),
                    DataType = FieldDataType.DateTime
                },
                new FieldDefinition {
                    Name = nameof(ContactGroupInfo.ContactGroupDisplayName),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition {
                    Name = nameof(ContactGroupInfo.ContactGroupID),
                    DataType = FieldDataType.Integer
                }
            }
        };


        public static FieldSet contactGroupMemberFieldSet = new FieldSet
        {
            ObjectType = "om.contactgroupmember",
            Fields = new FieldDefinition[]
            {
                new FieldDefinition
                {
                    Name = nameof(ContactGroupMemberInfo.ContactGroupMemberContactGroupID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition
                {
                    Name = nameof(ContactGroupMemberInfo.ContactGroupMemberRelatedID),
                    DataType = FieldDataType.Integer
                }
            }
        };


        public static FieldSet countryFieldSet = new FieldSet
        {
            ObjectType = CountryInfo.OBJECT_TYPE,
            Fields = new FieldDefinition[]
            {
                new FieldDefinition
                {
                    Name = nameof(CountryInfo.CountryID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition
                {
                    Name = nameof(CountryInfo.CountryDisplayName),
                    DataType = FieldDataType.Text
                }
            }
        };


        public static FieldSet siteFieldSet = new FieldSet
        {
            ObjectType = SiteInfo.OBJECT_TYPE,
            Fields = new FieldDefinition[]
            {
                new FieldDefinition
                {
                    Name = nameof(SiteInfo.SiteID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition
                {
                    Name = nameof(SiteInfo.SiteName),
                    DataType = FieldDataType.Text
                }
            }
        };


        public static FieldSet stateFieldSet = new FieldSet
        {
            ObjectType = StateInfo.OBJECT_TYPE,
            Fields = new FieldDefinition[]
            {
                new FieldDefinition
                {
                    Name = nameof(StateInfo.StateID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition
                {
                    Name = nameof(StateInfo.StateDisplayName),
                    DataType = FieldDataType.Text
                }
            }
        };


        public static FieldSet userFieldSet = new FieldSet
        {
            ObjectType = UserInfo.OBJECT_TYPE,
            DateFilterField = nameof(UserInfo.UserCreated),
            Fields = new FieldDefinition[]
            {
                new FieldDefinition
                {
                    Name = nameof(UserInfo.UserID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition
                {
                    Name = nameof(UserInfo.UserName),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition
                {
                    Name = nameof(UserInfo.FullName),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition
                {
                    Name = nameof(UserInfo.Email),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition
                {
                    Name = nameof(UserInfo.UserCreated),
                    DataType = FieldDataType.DateTime
                }
            }
        };


        public static FieldSet workflowFieldSet = new FieldSet
        {
            ObjectType = WorkflowInfo.OBJECT_TYPE,
            Fields = new FieldDefinition[]
            {
                new FieldDefinition
                {
                    Name = nameof(WorkflowInfo.WorkflowID),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition
                {
                    Name = nameof(WorkflowInfo.WorkflowDisplayName),
                    DataType = FieldDataType.Text
                },
                new FieldDefinition
                {
                    Name = nameof(WorkflowInfo.WorkflowType),
                    DataType = FieldDataType.Integer
                },
                new FieldDefinition
                {
                    Name = nameof(WorkflowInfo.WorkflowEnabled),
                    DataType = FieldDataType.Boolean
                }
            }
        };
    }
}
