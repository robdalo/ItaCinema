param(
	[string] $action,
	[string] $subAction,
	[string] $environment
)

if ($action -eq "azure" -and $subAction -eq "deploy") {
	$resourceGroupName = "ItaCinema" + $environment
	$location = "centralus"
	$templateFile = "azure\" + $environment.ToLower() + "\resources.json"

	New-AzResourceGroup -Name $resourceGroupName -Location $location -Force
	New-AzResourceGroupDeployment -ResourceGroupName $resourceGroupName -TemplateFile $templateFile
}

elseif ($action -eq "azure" -and $subAction -eq "destroy") {
	$resourceGroupName = "ItaCinema" + $environment
	Remove-AzResourceGroup -Name $resourceGroupName -Force
}
