﻿define("Contacts_FormPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "TimelineTile_SysFile",
				"values": {
					"linkedColumn": "QualifiedContact"
				}
			},
			{
				"operation": "merge",
				"name": "SubmittedFormExpansionPanel",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					}
				}
			},
			{
				"operation": "insert",
				"name": "TimelineTile_Opportunity",
				"values": {
					"type": "crt.TimelineTile",
					"classes": [
						"view-element"
					],
					"linkedColumn": "Contact",
					"sortedByColumn": "CreatedOn",
					"ownerColumn": "Owner",
					"data": {
						"columns": [
							{
								"columnName": "CreatedOn",
								"columnLayout": null
							},
							{
								"columnName": "Title",
								"columnLayout": null
							},
							{
								"columnName": "Account",
								"columnLayout": {
									"column": 1,
									"row": 1,
									"colSpan": 3,
									"rowSpan": 1
								}
							},
							{
								"columnName": "Contact",
								"columnLayout": {
									"column": 4,
									"row": 1,
									"colSpan": 3,
									"rowSpan": 1
								}
							},
							{
								"columnName": "Amount",
								"columnLayout": {
									"column": 1,
									"row": 2,
									"colSpan": 3,
									"rowSpan": 1
								}
							},
							{
								"columnName": "DueDate",
								"columnLayout": {
									"column": 4,
									"row": 2,
									"colSpan": 3,
									"rowSpan": 1
								}
							}
						],
						"schemaName": "Opportunity",
						"isDefault": false
					},
					"iconPosition": "only-icon",
					"icon": "star-tab-icon",
					"visible": true
				},
				"parentName": "Timeline",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "insert",
				"name": "TimelineTile_Lead",
				"values": {
					"type": "crt.TimelineTile",
					"classes": [
						"view-element"
					],
					"linkedColumn": "QualifiedContact",
					"sortedByColumn": "CreatedOn",
					"ownerColumn": "Owner",
					"iconId": null,
					"data": {
						"columns": [
							{
								"columnName": "CreatedOn",
								"columnLayout": null
							},
							{
								"columnName": "LeadName",
								"columnLayout": null
							},
							{
								"columnName": "QualifiedAccount",
								"columnLayout": "{\"column\": 1,\"row\": 1,\"colSpan\": 3,\"rowSpan\": 1}"
							},
							{
								"columnName": "QualifiedContact",
								"columnLayout": "{\"column\": 4,\"row\": 1,\"colSpan\": 3,\"rowSpan\": 1}"
							},
							{
								"columnName": "QualifyStatus",
								"columnLayout": "{\"column\": 1,\"row\": 2,\"colSpan\": 3,\"rowSpan\": 1}"
							}
						],
						"schemaName": "Lead",
						"isDefault": false
					},
					"iconPosition": "only-icon",
					"icon": "star-tab-icon",
					"visible": true
				},
				"parentName": "Timeline",
				"propertyName": "items",
				"index": 7
			},
			{
				"operation": "insert",
				"name": "LeadExpansionPanel",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(LeadExpansionPanel_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": false,
					"titleWidth": 20,
					"visible": true,
					"padding": {
						"top": "small",
						"bottom": "small",
						"left": "none",
						"right": "none"
					},
					"alignItems": "stretch"
				},
				"parentName": "SalesTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadToolsContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"alignItems": "stretch"
				},
				"parentName": "LeadExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadToolsFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"gap": "none",
					"alignItems": "center",
					"items": [],
					"layoutConfig": {
						"colSpan": 1,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					}
				},
				"parentName": "LeadToolsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadAddButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(LeadAddButton_caption)#",
					"icon": "add-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.CreateRecordRequest",
						"params": {
							"entityName": "Lead",
							"defaultValues": [
								{
									"attributeName": "QualifiedContact",
									"value": "$Id"
								}
							]
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "LeadToolsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadRefreshButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(LeadRefreshButton_caption)#",
					"icon": "reload-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.LoadDataRequest",
						"params": {
							"config": {
								"loadType": "reload",
								"useLastLoadParameters": true
							},
							"dataSourceName": "LeadListDS"
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "LeadToolsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LeadSettingsButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(LeadSettingsButton_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": [],
					"visible": true
				},
				"parentName": "LeadToolsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "LeadExportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(LeadExportDataButton_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "LeadList"
						}
					},
					"visible": true
				},
				"parentName": "LeadSettingsButton",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadImportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(LeadImportDataButton_caption)#",
					"icon": "import-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ImportDataRequest",
						"params": {
							"entitySchemaName": "Lead"
						}
					},
					"visible": true
				},
				"parentName": "LeadSettingsButton",
				"propertyName": "menuItems",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LeadSearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(LeadSearchFilter_placeholder)#",
					"targetAttributes": [
						"LeadList"
					],
					"iconOnly": true
				},
				"parentName": "LeadToolsFlexContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "LeadListContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax( 32px, 32px)",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": 0
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": []
				},
				"parentName": "LeadExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadList",
				"values": {
					"type": "crt.DataGrid",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 6
					},
					"visible": true,
					"items": "$LeadList",
					"primaryColumnName": "LeadListDS_Id",
					"columns": [
						{
							"id": "f28fb487-6a00-b0c0-f4ec-ad10d225db5c",
							"code": "LeadListDS_LeadName",
							"path": "LeadName",
							"caption": "#ResourceString(LeadListDS_LeadName)#",
							"dataValueType": 30
						},
						{
							"id": "4060707f-2970-4638-a74d-71478f5ba2f1",
							"code": "LeadListDS_LeadType",
							"path": "LeadType",
							"caption": "#ResourceString(LeadListDS_LeadType)#",
							"dataValueType": 10,
							"referenceSchemaName": "LeadType"
						},
						{
							"id": "09796d1e-6181-cd55-cde3-a22714a53768",
							"code": "LeadListDS_QualifyStatus",
							"path": "QualifyStatus",
							"caption": "#ResourceString(LeadListDS_QualifyStatus)#",
							"dataValueType": 10,
							"referenceSchemaName": "QualifyStatus"
						},
						{
							"id": "779c7db9-ff00-9ba4-de81-caca9b9c75e2",
							"code": "LeadListDS_Owner",
							"path": "Owner",
							"caption": "#ResourceString(LeadListDS_Owner)#",
							"dataValueType": 10,
							"referenceSchemaName": "Contact"
						},
						{
							"id": "1362dee9-3c36-0b10-8c5d-4a82a988a05e",
							"code": "LeadListDS_CreatedOn",
							"path": "CreatedOn",
							"caption": "#ResourceString(LeadListDS_CreatedOn)#",
							"dataValueType": 7
						}
					],
					"features": {
						"editable": {
							"enable": true,
							"itemsCreation": false
						}
					},
					"fitContent": true
				},
				"parentName": "LeadListContainer",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"LeadList": {
						"isCollection": true,
						"modelConfig": {
							"path": "LeadListDS",
							"filterAttributes": [
								{
									"name": "LeadList_PredefinedFilter",
									"loadOnChange": true
								}
							]
						},
						"viewModelConfig": {
							"attributes": {
								"LeadListDS_LeadName": {
									"modelConfig": {
										"path": "LeadListDS.LeadName"
									}
								},
								"LeadListDS_LeadType": {
									"modelConfig": {
										"path": "LeadListDS.LeadType"
									}
								},
								"LeadListDS_QualifyStatus": {
									"modelConfig": {
										"path": "LeadListDS.QualifyStatus"
									}
								},
								"LeadListDS_Owner": {
									"modelConfig": {
										"path": "LeadListDS.Owner"
									}
								},
								"LeadListDS_CreatedOn": {
									"modelConfig": {
										"path": "LeadListDS.CreatedOn"
									}
								},
								"LeadListDS_Id": {
									"modelConfig": {
										"path": "LeadListDS.Id"
									}
								}
							}
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"dataSources"
				],
				"values": {
					"LeadListDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "Lead",
							"attributes": {
								"LeadName": {
									"path": "LeadName"
								},
								"LeadType": {
									"path": "LeadType"
								},
								"QualifyStatus": {
									"path": "QualifyStatus"
								},
								"Owner": {
									"path": "Owner"
								},
								"CreatedOn": {
									"path": "CreatedOn"
								}
							}
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"dependencies"
				],
				"values": {
					"LeadListDS": [
						{
							"attributePath": "QualifiedContact",
							"relationPath": "PDS.Id"
						}
					]
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});