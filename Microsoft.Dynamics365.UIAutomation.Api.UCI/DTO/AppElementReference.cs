﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System.Collections.Generic;

namespace Microsoft.Dynamics365.UIAutomation.Api.UCI
{
    public static class AppReference
    {
        public static class Application
        {
            public static string Shell = "App_Shell";
        }
        public static class Navigation
        {
            public static string AreaButton = "Nav_AreaButton";
            public static string AreaMenu = "Nav_AreaMenu";
            public static string SubAreaContainer = "Nav_SubAreaContainer";
            public static string SubAreaItem = "Nav_SubAreaItem";
            public static string AppMenuButton = "Nav_AppMenuButton";
            public static string SiteMapLauncherButton = "Nav_SiteMapLauncherButton";
            public static string AppMenuContainer = "Nav_AppMenuContainer";
            public static string SettingsLauncherBar = "Nav_SettingsLauncherBar";
            public static string SettingsLauncher = "Nav_SettingsLauncher";
            public static string GuidedHelp = "Nav_GuidedHelp";
            public static string AdminPortal = "Nav_AdminPortal";
            public static string AdminPortalButton = "Nav_AdminPortalButton";
            public static string SearchButton = "Nav_SearchButton";
            public static string Search = "Nav_Search";
            public static string QuickLaunchMenu = "Nav_QuickLaunchMenu";
            public static string QuickLaunchButton = "Nav_QuickLaunchButton";
			public static string QuickCreateButton = "Nav_QuickCreateButton";
            public static string QuickCreateMenuList = "Nav_QuickCreateMenuList";
            public static string QuickCreateMenuItems = "Nav_QuickCreateMenuItems";
        }

        public static class Grid
        {
            public static string Container = "Grid_Container";
            public static string QuickFind = "Grid_QuickFind";
            public static string FirstPage = "Grid_FirstPage";
            public static string NextPage = "Grid_NextPage";
            public static string PreviousPage = "Grid_PreviousPage";
            public static string SelectAll = "Grid_SelectAll";
            public static string ShowChart = "Grid_ShowChart";
            public static string HideChart = "Grid_HideChart";
            public static string JumpBar = "Grid_JumpBar";
            public static string FilterByAll = "Grid_FilterByAll";
            public static string RowsContainer = "Grid_RowsContainer";
            public static string Rows = "Grid_Rows";
            public static string ChartSelector = "Grid_ChartSelector";
            public static string ChartViewList = "Grid_ChartViewList";
            public static string GridSortColumn = "Grid_SortColumn";
            public static string CellContainer = "Grid_CellContainer";
            public static string ViewSelector = "Grid_ViewSelector";
            public static string ViewContainer = "Grid_ViewContainer";
            public static string SubArea = "Grid_SubArea";
        }

        public static class EditableGrid
        {
            public static string Container = "EditabelGrid_Container";
            public static string CellContainer = "EditableGrid_CellContainer";
        }

            public static class Entity
        {
            public static string Form = "Entity_FormContainer";
            public static string Save = "Entity_Save";
            public static string TextFieldContainer = "Entity_TextFieldContainer";
            public static string TextFieldContainerLabel = "Entity_TextFieldContainerLabel";
            public static string TextFieldContainerCheckBox = "Entity_TextFieldContainerCheckBox";
            public static string TextFieldValue = "Entity_TextFieldValue";
            public static string TextFieldLookup = "Entity_TextFieldLookup";
            public static string TextFieldLookupMenu = "Entity_TextFieldLookupMenu";
            public static string LookupFieldDeleteExistingValue = "Entity_LookupFieldDeleteExistingValue";
            public static string LookupFieldHoverExistingValue = "Entity_LookupFieldHoverExistingValue";
            public static string LookupResultsDropdown = "Entity_LookupResultsDropdown";
            public static string LookupResultsDropdownQuickCreate = "Entity_LookupResultsDropdownQuickCreate";
            public static string TextFieldLookupFieldContainer = "Entity_TextFieldLookupFieldContainer";
            public static string RecordSetNavigator = "Entity_RecordSetNavigator";
            public static string RecordSetNavigatorOpen = "Entity_RecordSetNavigatorOpen";
            public static string RecordSetNavList = "Entity_RecordSetNavList";
            public static string RecordSetNavCollapseIcon = "Entity_RecordSetNavCollapseIcon";
            public static string RecordSetNavCollapseIconParent = "Entity_RecordSetNavCollapseIconParent";
            public static string FieldControlDateTimeInput = "Entity_FieldControlDateTimeInput";
            public static string FieldControlDateTimeInputUCI = "Entity_FieldControlDateTimeInputUCI";
            public static string Delete = "Entity_Delete";
            public static string Assign = "Entity_Assign";
            public static string SwitchProcess = "Entity_SwitchProcess";
            public static string CloseOpportunityWin = "Entity_CloseOpportunityWin";
            public static string CloseOpportunityLoss = "Entity_CloseOpportunityLoss";
            public static string ProcessButton = "Entity_Process";
            public static string SwitchProcessDialog = "Entity_SwitchProcessDialog";
            public static string TabList = "Entity_TabList";
            public static string MoreTabList = "Entity_TabListMore";
            public static string Tab = "Entity_Tab";
            public static string TabDropDown = "Entity_TabDropDown";
            public static string SubTab = "Entity_SubTab";
            public static string TextFieldNotificationAlert = "Entity_TextFieldNotificationAlert";
            public static string TextFieldLocked = "Entity_TextFieldLocked";
            public static string HeaderTitle = "Entity_HeaderTitle";
            public static string HeaderTextFieldContainer = "Entity_HeaderTextFieldContainer";
            public static string HeaderOptionFlyout = "Entity_HeaderOptionSetFlyout";
            public static string TextFieldLabel = "Entity_TextFieldLabel";
        }

        public static class CommandBar
        {
            public static string Container = "Cmd_Container";
            public static string ContainerRelated = "Cmd_ContainerRelated";
            public static string ContainerSubrid = "Cmd_ContainerSubgrid";
            public static string ContainerGrid = "Cmd_ContainerGrid";
            public static string MoreCommandsMenu = "Cmd_MoreCommandsMenu";
        }

        public static class Timeline
        {
            public static string SaveAndClose = "Timeline_SaveAndClose";
        }

        public static class Dashboard
        {
            public static string DashboardSelector = "Dashboard_Selector";
            public static string DashboardItem = "Dashboard_Item";
            public static string DashboardItemUCI = "Dashboard_Item_UCI";
        }

        public static class MultiSelect
        {
            public static string DivContainer = "MultiSelect_DivContainer";
            public static string DivContainer1 = "MultiSelect_DivContainer1";
            public static string InputSearch = "MultiSelect_InputSearch";
            public static string InputSearch1 = "MultiSelect_InputSearch1";
            public static string SelectedRecord = "MultiSelect_SelectedRecord";
            public static string SelectedRecordButton = "MultiSelect_SelectedRecord_Button";
            public static string SelectedRecordLabel = "MultiSelect_SelectedRecord_Label";
            public static string FlyoutList = "MultiSelect_FlyoutList";
            public static string FlyoutList1 = "MultiSelect_FlyoutList1";
            public static string ExpandCollapseButton = "MultiSelect_ExpandCollapseButton";
        }
        
        public static class GlobalSearch
        {
            public static string Button = "Search_Button";
            public static string Text = "Search_Text";
            public static string Filter = "Search_Filter";
            public static string Results = "Search_Result";
            public static string Container = "Search_Container";
            public static string EntityContainer = "Search_EntityContainer";
            public static string Records = "Search_Records";
        }

        public static class BusinessProcessFlow
        {
            public static string NextStage_UCI = "BPF_NextStage_UCI";
            public static string Flyout_UCI = "BPF_Flyout_UCI";
            public static string NextStageButton = "BPF_NextStageButton_UCI";
            public static string BusinessProcessFlowFieldName = "BPF_FieldName_UCI";
        }
        public static class Dialogs
        {
            public static class CloseOpportunity
            {
                public static string Ok = "CloseOpportunityDialog_OKButton";
                public static string Cancel = "CloseOpportunityDialog_CancelButton";
                public static string ActualRevenueId = "Dialog_ActualRevenue";
                public static string CloseDateId = "Dialog_CloseDate";
                public static string DescriptionId = "Dialog_Description";
            }
            public static string AssignDialogUserTeamLookupResults = "AssignDialog_UserTeamLookupResults";
            public static string AssignDialogOKButton = "AssignDialog_OKButton";
            public static string AssignDialogToggle = "AssignDialog_ToggleField";
            public static string ConfirmButton = "Dialog_ConfirmButton";
            public static string SwitchProcessDialog = "Entity_SwitchProcessDialog";
            public static string SwitchProcessDialogOK = "Entity_SwitchProcessDialogOK";
            public static string ActiveProcessGridControlContainer = "Entity_ActiveProcessGridControlContainer";
            public static string CancelButton = "Dialog_CancelButton";
            public static string SwitchProcessContainer = "Dialog_SwitchProcessContainer";
        }
		public static class QuickCreate
        {
            public static string SaveButton = "QuickCreate_SaveButton";
        }
    }

    public static class AppElements
    {
        public static Dictionary<string, string> Xpath = new Dictionary<string, string>()
        {
            //Application 
            { "App_Shell"    , "//*[@id=\"ApplicationShell\"]"},

            //Navigation
            //{ "Nav_AreaButton"       , "//button[contains(@aria-label,'All Areas')]"},
            { "Nav_AreaButton"       , "//button[@id=\"areaSwitcherId\"]"},
            { "Nav_AreaMenu"       , "//*[@data-lp-id=\"sitemap-area-switcher-flyout\"]"},
            //{ "Nav_AreaMenu"       , "//*[@id=\"__flyoutRootNode\"]"},
            { "Nav_SubAreaContainer"       , "//*[@aria-label=\"Navigate Dynamics 365\"]" },///div[1]/div[2]/div/div/div[2]/div[3]/ul"},
            //{ "Nav_SubAreaContainer"       , "//*[@id=\"ApplicationShell\"]/div[1]/div[2]/div/div/div[2]/div[3]/ul"},
            {"Nav_SubAreaItem","//li[contains(@data-lp-id,'sitemap-entity-NewSubArea')]" },
            { "Nav_AppMenuButton"       , "//*[@id=\"TabArrowDivider\"]/a"},
            { "Nav_SiteMapLauncherButton", "//button[@data-lp-id=\"sitemap-launcher\"]" },
            { "Nav_AppMenuContainer"       , "//*[@id=\"taskpane-scroll-container\"]"},
            { "Nav_SettingsLauncherBar"       , "//*[@id=\"[NAME]Launcher_buttonaction-bar\"]"},
            { "Nav_SettingsLauncher"       , "//*[@id=\"[NAME]Launcher\"]"},
            { "Nav_GuidedHelp"       , "//*[@id=\"helpLauncher\"]/button"},
            //{ "Nav_AdminPortal"       , "//*[@id=(\"id-5\")]"},
            { "Nav_AdminPortal"       , "//*[contains(@data-id,'officewaffle')]"},
            { "Nav_AdminPortalButton" , "//*[@id=(\"O365_AppTile_Admin\")]"},
            { "Nav_SearchButton" , "//*[@id=\"searchLauncher\"]/button"},
            { "Nav_Search",                "//*[@id=\"categorizedSearchInputAndButton\"]"},
            { "Nav_QuickLaunchMenu",                "//div[contains(@data-id,'quick-launch-bar')]"},
            { "Nav_QuickLaunchButton",                "//li[contains(@title, '[NAME]')]"},
			{ "Nav_QuickCreateButton", "//button[contains(@data-id,'quickCreateLauncher')]" },
            { "Nav_QuickCreateMenuList", "//ul[contains(@id,'MenuSectionItemsquickCreate')]" },
            { "Nav_QuickCreateMenuItems", "//li[@role='menuitem']" },

            
            //Grid
            { "Grid_Container"       , "//*[@id=\"_outer\"]/div/div[3][@data-type=\"Grid\"]"},
            { "Grid_QuickFind"       , "//*[contains(@id, \'quickFind_text\')]"},
            { "Grid_NextPage"       , "//button[contains(@data-id,'moveToNextPage')]"},
            { "Grid_PreviousPage"       , "//button[contains(@data-id,'moveToPreviousPage')]"},
            { "Grid_FirstPage"       , "//button[contains(@data-id,'loadFirstPage')]"},
            { "Grid_SelectAll"       , "//button[contains(@title,'Select All')]"},
            { "Grid_ShowChart"       , "//button[contains(@aria-label,'Show Chart')]"},
            { "Grid_JumpBar"       , "//*[@id=\"JumpBarItemsList\"]"},
            { "Grid_FilterByAll"       , "//*[@id=\"All_link\"]"},
            { "Grid_RowsContainer"       , "//div[contains(@role,'grid')]"},
            { "Grid_Rows"           , "//div[contains(@role,'row')]"},
            { "Grid_ChartSelector"           , "//span[contains(@id,'ChartSelector')]"},
            { "Grid_ChartViewList"           , "//ul[contains(@role,'listbox')]"},
            { "Grid_SortColumn",            "//div[@id='btnheaderselectcolumn']/parent::*//div[text()='[COLNAME]']"},
            { "Grid_CellContainer"    ,"//div[@role='grid'][@data-id='grid-cell-container']"},
            { "Grid_ViewSelector"   , "//span[contains(@id,'ViewSelector')]" },
            { "Grid_ViewContainer"   , "//ul[contains(@id,'ViewSelector')]" },
            { "Grid_SubArea"   , "//*[contains(@data-id,'[NAME]')]"},
            
            //Editable Grid
            { "EditabelGrid_Container"       , "//div[@aria-label='Editable Grid'][contains(@data-lp-id,'[NAME]')]"},
            { "EditableGrid_CellContainer"    ,"//div[@role='row'][@aria-label='Data']"},

            //Entity
            { "Entity_Assign"       , "//button[contains(@data-id,'Assign')]"},
            { "Entity_CloseOpportunityWin"       , "//button[contains(@data-id,'MarkAsWon')]"},
            { "Entity_CloseOpportunityLoss"       , "//button[contains(@data-id,'MarkAsLost')]"},
            { "Entity_Delete"       , "//button[contains(@data-id,'Delete')]"},
            { "Entity_FormContainer"       , "//*[@id=\"tab-section\"]"},
            { "Entity_Process"       , "//button[contains(@data-id,'MBPF.ConvertTo')]"},
            //{ "Entity_Save"       , "//*[@id=\"footerWrapper\"]/div/div[4]/button"},
            { "Entity_Save"       , "//*[@id=\"footerWrapper\"]//button[@data-id=\"edit-form-save-btn\"]"},
            { "Entity_SwitchProcess"       , "//button[contains(@data-id,'SwitchProcess')]"},
            { "Entity_TextFieldContainer", "//*[contains(@id, \'[NAME]-FieldSectionItemContainer\')]" },
            {"Entity_TextFieldContainerLabel","//*[contains(@for, \'[NAME].fieldControl-text-box-text\')]" },
            {"Entity_TextFieldContainerCheckBox", "//*[contains(@id, \'[NAME].fieldControl-checkbox-toggle\')]" },
            { "Entity_TextFieldValue", "//input[contains(@data-id, \'[NAME].fieldControl\')]" },
            { "Entity_TextFieldLookup", "//*[contains(@id, \'systemuserview_id.fieldControl-LookupResultsDropdown')]" },
            { "Entity_TextFieldLookupMenu", "//*[contains(@id, \'[NAME].fieldControl|__flyoutRootNode_SimpleLookupControlFlyout')]" },
            { "Entity_LookupFieldDeleteExistingValue", "//*[contains(@data-id, \'[NAME].fieldControl-LookupResultsDropdown_[NAME]_selected_tag_delete')]" },
            { "Entity_LookupFieldHoverExistingValue", "//*[contains(@data-id, \'[NAME].fieldControl-LookupResultsDropdown_[NAME]_SelectedRecordList')]" },
            { "Entity_TextFieldLookupFieldContainer", "//*[contains(@id, '[NAME].fieldControl-LookupResultsDropdown')]" },
            { "Entity_RecordSetNavigatorOpen", "//button[contains(@data-lp-id, 'recordset-navigator')]" },
            { "Entity_RecordSetNavigator", "//button[contains(@data-lp-id, 'recordset-navigator')]" },
            { "Entity_RecordSetNavList", "//ul[contains(@data-id, 'recordSetNaveList')]" },
            { "Entity_RecordSetNavCollapseIcon", "//*[contains(@data-id, 'recordSetNavCollapseIcon')]" },
            { "Entity_RecordSetNavCollapseIconParent", "//*[contains(@data-id, 'recordSetNavCollapseIcon')]" },
            { "Entity_TabList", "//ul[@id=\"tablist\"]" },
            {"Entity_TabListMore","//ul[@id=\"tablist\"]//li[@data-id=\"tab_more\"]" },
            { "Entity_Tab", "//li[@title=\"{0}\"]" },
            { "Entity_TabDropDown", "//div[@id=\"__flyoutRootNode\"]//li[text()=\"{0}\"]" },
            { "Entity_SubTab", "//div[@id=\"__flyoutRootNode\"]//span[text()=\"{0}\"]" },
            { "Entity_FieldControlDateTimeInput","//input[contains(@id,'[FIELD].fieldControl-date-time-input')]" },
            { "Entity_FieldControlDateTimeInputUCI","//input[contains(@data-id,'[FIELD].fieldControl-date-time-input')]" },
            { "Entity_LookupResultsDropdown", "//*[contains(@data-id, \'[NAME].fieldControl-LookupResultsDropdown_[NAME]_tab')]" },
            { "Entity_LookupResultsDropdownQuickCreate", "//ul[contains(@data-id, \'[NAME].fieldControl-LookupResultsDropdown_[NAME]_tab')]" },
            //{ "Entity_TextFieldNotificationAlert", "//*[contains(@data-id, \'[NAME]-error-message\')]" },
            { "Entity_TextFieldNotificationAlert", "//*[contains(@data-id, \'[NAME]-required-icon\')]" },
            {"Entity_TextFieldLocked","//*[contains(@data-id, \'[NAME]-locked-icon\')]" },
            {"Entity_HeaderTitle","//div[@data-lp-id=\"form-header-title\"]//h1[@data-id=\"header_title\"]" },
            {"Entity_HeaderTextFieldContainer","//*[contains(@data-id, \'header_[NAME].fieldControl\')]" },
            {"Entity_HeaderOptionSetFlyout","//div[@data-id=\"header_[NAME].fieldControl|__flyoutRootNode\"]//li[@data-text=\"[Value]\"]" },
            {"Entity_TextFieldLabel","//label[contains(@id,\'[NAME]-field-label\')]" },
                        
            //CommandBar
            { "Cmd_Container"       , "//ul[contains(@data-lp-id,\"commandbar-Form\")]"},
            { "Cmd_ContainerRelated"       , "//ul[contains(@data-lp-id,\"commandbar-SubGridAssociated\")]"},
            { "Cmd_ContainerSubgrid"       , "//ul[contains(@data-lp-id,\"SubGridStandard:\")]"},
            { "Cmd_ContainerGrid"       , "//ul[contains(@data-lp-id,\"commandbar-HomePageGrid\")]"},
            { "Cmd_MoreCommandsMenu"       , "//*[@id=\"__flyoutRootNode\"]"},

            //GlobalSearch
            { "Search_Button"       , "//div[@id=\"categorizedSearchHeader\"]//button[@aria-label=\"Search\"]" },
            { "Search_Text"       , "//input[@aria-label=\"Search box\"]" },
            { "Search_Filter"       , "//select[@aria-label=\"Filter with\"]"},
            { "Search_Container"    , "//div[@id=\"searchResultList\"]"},
            { "Search_EntityContainer"    , "//div[@id=\"View[NAME]\"]"},
            { "Search_Records"    , "//li[@role=\"row\"]" },

            //Timeline
            { "Timeline_SaveAndClose", "//button[contains(@data-id,\"[NAME].SaveAndClose\")]" },

            //MultiSelect
            { "MultiSelect_DivContainer",     "//div[contains(@data-id,\"[NAME]-FieldSectionItemContainer\")]/div/div/div" },
            { "MultiSelect_DivContainer1",     "//div[contains(@data-id,\"[NAME]-FieldSectionItemContainer\")]/div" },
            { "MultiSelect_InputSearch",     "//div[contains(@data-id,\"[NAME].fieldControl-LookupResultsDropdown_[NAME]_InputSearch\")]" },
            { "MultiSelect_InputSearch1",     "//div[contains(@data-id,\"[NAME].fieldControl_container\")]" },
            { "MultiSelect_SelectedRecord",  "//ul[contains(@data-id,\"[NAME].fieldControl-LookupResultsDropdown_[NAME]_SelectedRecordList\")]//li" },
            { "MultiSelect_SelectedRecord_Button",  "//ul[contains(@data-id,\"[NAME].fieldControl-LookupResultsDropdown_[NAME]_SelectedRecordList\")]//li[descendant::label[text()=\"{0}\"]]/descendant::button" },
            { "MultiSelect_SelectedRecord_Label",  "//ul[contains(@data-id,\"[NAME].fieldControl-LookupResultsDropdown_[NAME]_SelectedRecordList\")]/descendant::label" },
            { "MultiSelect_FlyoutList",      "//div[contains(@id,\"[NAME].fieldControl|__flyoutRootNode_SimpleLookupControlFlyout\")]//li[descendant::label[text()=\"{0}\"]]" },
            { "MultiSelect_FlyoutList1",      "//div[contains(@data-id,\"[NAME].fieldControl_container\")]//label[contains(@title,\"{0}\")]" },
            { "MultiSelect_ExpandCollapseButton", "//button[contains(@data-id,\"[NAME].fieldControl-LookupResultsDropdown_[NAME]_expandCollapse\")]/descendant::label[not(text()=\"+0\")]" },

            //Dashboard
            { "Dashboard_Selector"       , "//span[contains(@id, 'Dashboard_Selector')]"},
            { "Dashboard_Item"       , "//li[contains(@title, '[NAME]')]"},
            { "Dashboard_Item_UCI"       , "//li[contains(@data-text, '[NAME]')]"},

            //Business Process Flow
            { "BPF_NextStage_UCI"     , "//li[contains(@id,'processHeaderStage')]" },
            { "BPF_Flyout_UCI"     , "//div[contains(@id,'businessProcessFlowFlyoutHeaderContainer')]" },
            { "BPF_NextStageButton_UCI"     , "//button[contains(@data-id,'nextButtonContainer')]" },
            { "BPF_FieldName_UCI"     , "//input[contains(@id,'[NAME]')]" },


            //Dialogs
            { "AssignDialog_ToggleField" , "//label[contains(@data-id,'rdoMe_id.fieldControl-checkbox-inner-first')]" },
            { "AssignDialog_UserTeamLookupResults" , "//ul[contains(@data-id,'systemuserview_id.fieldControl-LookupResultsDropdown_systemuserview_id_tab')]" },
            { "AssignDialog_OKButton" , "//button[contains(@data-id, 'ok_id')]" },
            { "CloseOpportunityDialog_OKButton" , "//button[contains(@data-id, 'ok_id')]" },
            { "CloseOpportunityDialog_CancelButton" , "//button[contains(@data-id, 'cancel_id')]" },
            { "Dialog_ActualRevenue", "//input[contains(@data-id,'actualrevenue_id')]" },
            { "Dialog_CloseDate", "//input[contains(@data-id,'closedate_id')]" },
            { "Dialog_DescriptionId", "//input[contains(@data-id,'description_id')]" },
            { "Dialog_ConfirmButton" , "//*[@id=\"confirmButton\"]" },
            { "Dialog_CancelButton" , "//*[@id=\"cancelButton\"]" },
            { "Dialog_SwitchProcessContainer" , "//div[contains(@id,'switchProcess_id-FieldSectionItemContainer')]" },
            { "Entity_ActiveProcessGridControlContainer"       , "//div[contains(@data-lp-id,'activeProcessGridControlContainer')]"},
            { "Entity_SwitchProcessDialogOK"       , "//button[contains(@data-id,'ok_id')]"},
            { "SwitchProcess_Container" , "//section[contains(@id, 'popupContainer')]" },
            //QuickCreate 
            //{ "QuickCreate_SaveButton" , "//button[contains(@id,'quickCreateSaveBtn')]" }
            {"QuickCreate_SaveButton","//button[contains(@id,'quickCreateSaveAndCloseBtn')]" }
        };
    }

    public enum LoginResult
    {
        Success,
        Failure,
        Redirect
    }
}



