using UnrealBuildTool;

public class WhiteboxLuisRoom : ModuleRules
{
	public WhiteboxLuisRoom(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
