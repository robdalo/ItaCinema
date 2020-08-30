param(
	[string] $action,
	[string] $subAction
)

if ($action -eq "azure" -and $subAction -eq "deploy") {
	$resourceGroupName = "ItaCinema"
	$location = "centralus"
	$templateFile = "azure\resources.json"

	New-AzResourceGroup -Name $resourceGroupName -Location $location -Force
	New-AzResourceGroupDeployment -ResourceGroupName $resourceGroupName -TemplateFile $templateFile
}

elseif ($action -eq "azure" -and $subAction -eq "destroy") {
	$resourceGroupName = "ItaCinema"
	Remove-AzResourceGroup -Name $resourceGroupName -Force
}
