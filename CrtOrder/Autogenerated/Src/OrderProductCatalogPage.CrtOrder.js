define("OrderProductCatalogPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "PageTitle",
				"values": {
					"caption": "#MacrosTemplateString(#ResourceString(PageTitle_caption)#)#",
					"visible": true
				}
			},
			{
				"operation": "merge",
				"name": "EntityHierarchyFilter",
				"values": {
					"nodesConfig": [
						{
							"columnName": "Category",
							"children": [
								{
									"columnName": "Type"
								}
							]
						}
					],
					"schemaName": "Product"
				}
			},
			{
				"operation": "merge",
				"name": "CatalogTagFilter",
				"values": {
					"config": {
						"caption": "#ResourceString(CatalogTagFilter_config_caption)#",
						"hint": "",
						"icon": "tag-icon",
						"iconPosition": "left-icon",
						"defaultValue": [],
						"entitySchemaName": "Tag_Virtual_Schema",
						"recordsFilter": null
					},
					"_filterOptions": {
						"expose": [
							{
								"attribute": "CatalogTagFilter_DataGrid_fqyjxvm",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "DataGrid_fqyjxvm",
													"filterColumn": "Tag_Virtual_Column"
												},
												"quickFilterType": "lookup"
											}
										]
									}
								]
							}
						],
						"from": "CatalogTagFilter_Value"
					}
				}
			},
			{
				"operation": "merge",
				"name": "EntityCatalogDataGrid",
				"values": {
					"features": {
						"rows": {
							"selection": {
								"enable": true,
								"multiple": true,
								"selectAll": false
							},
							"numeration": true
						},
						"editable": {
							"enable": false,
							"itemsCreation": false
						}
					},
					"visible": true,
					"fitContent": true,
					"columns": [
						{
							"id": "0345ab5b-c429-b7bf-4e58-e60a27eaf491",
							"code": "EntityCatalogDataGridDS_Code",
							"path": "Code",
							"caption": "#ResourceString(EntityCatalogDataGridDS_Code)#",
							"dataValueType": 27,
							"width": 140.9943084716797
						},
						{
							"id": "038f4c76-064a-6803-5066-dadf1f03fc18",
							"code": "EntityCatalogDataGridDS_Name",
							"caption": "#ResourceString(EntityCatalogDataGridDS_Name)#",
							"dataValueType": 28,
							"width": 209.99998474121094
						},
						{
							"id": "919a859d-46d7-11f0-f0ef-5e7da9a7f82d",
							"code": "EntityCatalogDataGridDS_Price",
							"path": "Price",
							"caption": "#ResourceString(EntityCatalogDataGridDS_Price)#",
							"dataValueType": 6
						},
						{
							"id": "60a2aad5-b47e-d205-2dab-a4082925c8ae",
							"code": "EntityCatalogDataGridDS_Unit",
							"path": "Unit",
							"caption": "#ResourceString(EntityCatalogDataGridDS_Unit)#",
							"dataValueType": 10,
							"referenceSchemaName": "Unit",
							"width": 165.99998474121094
						}
					],
					"placeholder": false,
					"bulkActions": []
				}
			},
			{
				"operation": "insert",
				"name": "AddToCartButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(AddToCartButton_caption)#",
					"color": "accent",
					"disabled": "$DataGrid_fqyjxvm_SelectionState | crt.IsAnySelected | crt.InvertBooleanValue",
					"size": "large",
					"iconPosition": "left-icon",
					"visible": true,
					"clicked": {
						"request": "crt.MoveSelectedItemsRequest",
						"params": {
							"sourceAttribute": "DataGrid_fqyjxvm",
							"selectionStateAttribute": "DataGrid_fqyjxvm_SelectionState",
							"defaultValues": [
								{
									"attributeName": "OrderProductDS_Product",
									"type": "item",
									"value": {
										"value": "EntityCatalogDataGridDS_Id",
										"displayValue": "EntityCatalogDataGridDS_Name"
									}
								},
								{
									"attributeName": "OrderProductDS_Order",
									"type": "root",
									"value": "PageParameters_Order"
								},
								{
									"attributeName": "OrderProductDS_Price",
									"type": "item",
									"value": "EntityCatalogDataGridDS_Price"
								},
								{
									"attributeName": "OrderProductDS_Unit",
									"type": "item",
									"value": "EntityCatalogDataGridDS_Unit"
								},
								{
									"attributeName": "OrderProductDS_Currency",
									"type": "item",
									"value": "EntityCatalogDataGridDS_Currency"
								},
								{
									"attributeName": "OrderProductDS_Tax",
									"type": "item",
									"value": "EntityCatalogDataGridDS_Tax"
								},
								{
									"attributeName": "OrderProductDS_Quantity",
									"type": "const",
									"value": 1
								}
							],
							"targetAttribute": "DataGrid_7qywxjz"
						}
					},
					"clickMode": "default",
					"icon": "trolley-icon"
				},
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "MoveSelectedItemsMenuItem",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(MoveSelectedItemsMenuItem_caption)#",
					"visible": true,
					"clicked": {
						"request": "crt.MoveSelectedItemsRequest",
						"params": {
							"sourceAttribute": "DataGrid_fqyjxvm",
							"selectionStateAttribute": "DataGrid_fqyjxvm_SelectionState",
							"defaultValues": [
								{
									"attributeName": "OrderProductDS_Product",
									"type": "item",
									"value": {
										"value": "EntityCatalogDataGridDS_Id",
										"displayValue": "EntityCatalogDataGridDS_Name"
									}
								},
								{
									"attributeName": "OrderProductDS_Order",
									"type": "root",
									"value": "PageParameters_Order"
								},
								{
									"attributeName": "OrderProductDS_Price",
									"type": "item",
									"value": "EntityCatalogDataGridDS_Price"
								},
								{
									"attributeName": "OrderProductDS_Unit",
									"type": "item",
									"value": "EntityCatalogDataGridDS_Unit"
								},
								{
									"attributeName": "OrderProductDS_Currency",
									"type": "item",
									"value": "EntityCatalogDataGridDS_Currency"
								},
								{
									"attributeName": "OrderProductDS_Tax",
									"type": "item",
									"value": "EntityCatalogDataGridDS_Tax"
								},
								{
									"attributeName": "OrderProductDS_Quantity",
									"type": "const",
									"value": 1
								}
							],
							"targetAttribute": "DataGrid_7qywxjz"
						}
					},
					"icon": "trolley-icon"
				},
				"parentName": "EntityCatalogDataGrid",
				"propertyName": "bulkActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CartTabContainer",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "#ResourceString(CartTabContainer_caption)#",
					"iconPosition": "left-icon",
					"visible": true,
					"stretch": true,
					"icon": "trolley-tab-icon"
				},
				"parentName": "CatalogToggleTabPanel",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "CartContentFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "column",
					"gap": "none",
					"color": "primary",
					"stretch": true
				},
				"parentName": "CartTabContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CartMainFilterContainer",
				"values": {
					"type": "crt.GridContainer",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"rows": "minmax(max-content, 32px)",
					"gap": {
						"columnGap": "none",
						"rowGap": "none"
					},
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "primary",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "large"
					},
					"alignItems": "stretch"
				},
				"parentName": "CartContentFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CartFilterFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "primary",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"alignItems": "center",
					"justifyContent": "start",
					"gap": "medium",
					"wrap": "nowrap",
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 2,
						"rowSpan": 1
					}
				},
				"parentName": "CartMainFilterContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OrderInProductTagFilter",
				"values": {
					"type": "crt.QuickFilter",
					"config": {
						"caption": "#ResourceString(OrderInProductTagFilter_config_caption)#",
						"hint": "",
						"icon": "tag-icon",
						"iconPosition": "left-icon",
						"defaultValue": [],
						"entitySchemaName": "Tag_Virtual_Schema",
						"recordsFilter": null
					},
					"filterType": "lookup",
					"_filterOptions": {
						"expose": [
							{
								"attribute": "OrderInProductTagFilter_DataGrid_7qywxjz",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "DataGrid_7qywxjz",
													"filterColumn": "Tag_Virtual_Column"
												},
												"quickFilterType": "lookup"
											}
										]
									}
								]
							}
						],
						"from": "OrderInProductTagFilter_Value"
					}
				},
				"parentName": "CartFilterFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OrderInProductSearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(OrderInProductSearchFilter_placeholder)#",
					"targetAttributes": [
						"DataGrid_7qywxjz"
					]
				},
				"parentName": "CartFilterFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "CartDataGrid",
				"values": {
					"type": "crt.DataGrid",
					"features": {
						"rows": {
							"selection": {
								"enable": true,
								"multiple": true
							}
						},
						"editable": {
							"enable": true,
							"itemsCreation": false
						}
					},
					"items": "$DataGrid_7qywxjz",
					"activeRow": "$DataGrid_7qywxjz_ActiveRow",
					"selectionState": "$DataGrid_7qywxjz_SelectionState",
					"_selectionOptions": {
						"attribute": "DataGrid_7qywxjz_SelectionState"
					},
					"visible": true,
					"fitContent": true,
					"stretch": true,
					"primaryColumnName": "OrderProductDS_Id",
					"columns": [
						{
							"id": "23a9defb-bdfd-0c1b-8ad6-5e74bab80905",
							"code": "OrderProductDS_ProductCode",
							"path": "Product.Code",
							"caption": "#ResourceString(OrderProductDS_ProductCode)#",
							"dataValueType": 27,
							"width": 204
						},
						{
							"id": "bd911bba-9687-8b50-095b-307d9ef1cbfa",
							"code": "OrderProductDS_Product",
							"path": "Product",
							"caption": "#ResourceString(OrderProductDS_Product)#",
							"dataValueType": 10,
							"referenceSchemaName": "Product"
						},
						{
							"id": "2f2525f3-56ee-6abc-928a-1a560396d132",
							"code": "OrderProductDS_Price",
							"path": "Price",
							"caption": "#ResourceString(OrderProductDS_Price)#",
							"dataValueType": 6
						},
						{
							"id": "62fb82fc-f2fc-c43a-f7fa-44ec4a8cfd72",
							"code": "OrderProductDS_Quantity",
							"path": "Quantity",
							"caption": "#ResourceString(OrderProductDS_Quantity)#",
							"dataValueType": 33
						},
						{
							"id": "73bed78d-1763-f7fd-d2be-8bdb7ebbbb13",
							"code": "OrderProductDS_Unit",
							"path": "Unit",
							"caption": "#ResourceString(OrderProductDS_Unit)#",
							"dataValueType": 10,
							"referenceSchemaName": "Unit"
						}
					],
					"placeholder": false,
					"bulkActions": []
				},
				"parentName": "CartContentFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "CartDataGrid_AddTagsBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(CartDataGrid_AddTagsBulkAction_caption)#",
					"icon": "tag-icon",
					"clicked": {
						"request": "crt.AddTagsInRecordsRequest",
						"params": {
							"dataSourceName": "OrderProductDS",
							"filters": "$DataGrid_7qywxjz | crt.ToCollectionFilters : 'DataGrid_7qywxjz' : $DataGrid_7qywxjz_SelectionState | crt.SkipIfSelectionEmpty : $DataGrid_7qywxjz_SelectionState"
						}
					},
					"items": [],
					"visible": true
				},
				"parentName": "CartDataGrid",
				"propertyName": "bulkActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CartDataGrid_RemoveTagsBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(CartDataGrid_RemoveTagsBulkAction_caption)#",
					"icon": "delete-button-icon",
					"clicked": {
						"request": "crt.RemoveTagsInRecordsRequest",
						"params": {
							"dataSourceName": "OrderProductDS",
							"filters": "$DataGrid_7qywxjz | crt.ToCollectionFilters : 'DataGrid_7qywxjz' : $DataGrid_7qywxjz_SelectionState | crt.SkipIfSelectionEmpty : $DataGrid_7qywxjz_SelectionState"
						}
					},
					"visible": true
				},
				"parentName": "CartDataGrid_AddTagsBulkAction",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CartDataGrid_ExportToExcelBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(CartDataGrid_ExportToExcelBulkAction_caption)#",
					"icon": "export-button-icon",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "CartDataGrid",
							"filters": "$DataGrid_7qywxjz | crt.ToCollectionFilters : 'DataGrid_7qywxjz' : $DataGrid_7qywxjz_SelectionState | crt.SkipIfSelectionEmpty : $DataGrid_7qywxjz_SelectionState"
						}
					},
					"visible": true
				},
				"parentName": "CartDataGrid",
				"propertyName": "bulkActions",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "CartDataGrid_DeleteBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(CartDataGrid_DeleteBulkAction_caption)#",
					"icon": "delete-button-icon",
					"clicked": {
						"request": "crt.DeleteRecordsRequest",
						"params": {
							"dataSourceName": "OrderProductDS",
							"filters": "$DataGrid_7qywxjz | crt.ToCollectionFilters : 'DataGrid_7qywxjz' : $DataGrid_7qywxjz_SelectionState | crt.SkipIfSelectionEmpty : $DataGrid_7qywxjz_SelectionState"
						}
					},
					"visible": true
				},
				"parentName": "CartDataGrid",
				"propertyName": "bulkActions",
				"index": 2
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"OrderProductOrderIdFilter": {
						"from": [
							"PageParameters_Order",
						],
						"converter": "crt.ToInFilter: 'Order'"
					},
					"DataGrid_fqyjxvm": {
						"viewModelConfig": {
							"attributes": {
								"EntityCatalogDataGridDS_Code": {
									"modelConfig": {
										"path": "EntityCatalogDataGridDS.Code"
									}
								},
								"EntityCatalogDataGridDS_Name": {
									"modelConfig": {
										"path": "EntityCatalogDataGridDS.Name"
									}
								},
								"EntityCatalogDataGridDS_Price": {
									"modelConfig": {
										"path": "EntityCatalogDataGridDS.Price"
									}
								},
								"EntityCatalogDataGridDS_Unit": {
									"modelConfig": {
										"path": "EntityCatalogDataGridDS.Unit"
									}
								},
							}
						}
					},
					"DataGrid_7qywxjz": {
						"isCollection": true,
						"modelConfig": {
							"path": "OrderProductDS",
							"filterAttributes": [
								{
									"name": "OrderInProductTagFilter_DataGrid_7qywxjz",
									"loadOnChange": true
								},
								{
									"name": "OrderProductOrderIdFilter",
									"loadOnChange": true
								}
							],
							"sortingConfig": {
								"default": [
									{
										"direction": "desc",
										"columnName": "ProductCode"
									}
								]
							}
						},
						"viewModelConfig": {
							"attributes": {
								"OrderProductDS_ProductCode": {
									"modelConfig": {
										"path": "OrderProductDS.ProductCode"
									}
								},
								"OrderProductDS_Product": {
									"modelConfig": {
										"path": "OrderProductDS.Product"
									}
								},
								"OrderProductDS_Price": {
									"modelConfig": {
										"path": "OrderProductDS.Price"
									}
								},
								"OrderProductDS_Quantity": {
									"modelConfig": {
										"path": "OrderProductDS.Quantity"
									}
								},
								"OrderProductDS_Unit": {
									"modelConfig": {
										"path": "OrderProductDS.Unit"
									}
								},
								"OrderProductDS_Id": {
									"modelConfig": {
										"path": "OrderProductDS.Id"
									}
								}
							}
						}
					},
					"PageParameters_Order": {
						"modelConfig": {
							"path": "PageParameters.Order"
						}
					},
					"DataGrid_fqyjxvm_PredefinedFilter": {
						"value": {
							"items": {
								"76cec3ec-ce56-457b-9c4c-911f11e66696": {
									"filterType": 1,
									"comparisonType": 3,
									"isEnabled": true,
									"trimDateTimeParameterToDate": false,
									"leftExpression": {
										"expressionType": 0,
										"columnPath": "IsArchive"
									},
									"isAggregative": false,
									"dataValueType": 12,
									"rightExpression": {
										"expressionType": 2,
										"parameter": {
											"dataValueType": 12,
											"value": false
										}
									}
								}
							},
							"logicalOperation": 0,
							"isEnabled": true,
							"filterType": 6,
							"rootSchemaName": "Product"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [],
				"values": {
					"dataSources": {
						"EntityCatalogDataGridDS": {
							"type": "crt.EntityDataSource",
							"scope": "viewElement",
							"config": {
								"entitySchemaName": "Product",
								"attributes": {
									"Code": {
										"path": "Code"
									},
									"Name": {
										"path": "Name"
									},
									"Price": {
										"path": "Price"
									},
									"Unit": {
										"path": "Unit"
									}
								}
							}
						},
						"OrderProductDS": {
							"type": "crt.EntityDataSource",
							"scope": "viewElement",
							"config": {
								"entitySchemaName": "OrderProduct",
								"attributes": {
									"ProductCode": {
										"type": "ForwardReference",
										"path": "Product.Code"
									},
									"Product": {
										"path": "Product"
									},
									"Price": {
										"path": "Price"
									},
									"Quantity": {
										"path": "Quantity"
									},
									"Unit": {
										"path": "Unit"
									}
								}
							}
						}
					}
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});
