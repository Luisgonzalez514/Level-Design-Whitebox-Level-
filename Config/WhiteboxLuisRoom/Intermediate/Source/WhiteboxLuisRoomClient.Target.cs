using UnrealBuildTool;

public class WhiteboxLuisRoomClientTarget : TargetRules
{
	public WhiteboxLuisRoomClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("WhiteboxLuisRoom");
	}
}
