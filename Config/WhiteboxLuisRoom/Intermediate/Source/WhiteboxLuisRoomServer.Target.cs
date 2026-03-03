using UnrealBuildTool;

public class WhiteboxLuisRoomServerTarget : TargetRules
{
	public WhiteboxLuisRoomServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("WhiteboxLuisRoom");
	}
}
