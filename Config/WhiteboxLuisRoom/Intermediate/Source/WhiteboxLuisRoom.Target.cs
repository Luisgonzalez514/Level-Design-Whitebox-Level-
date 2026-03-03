using UnrealBuildTool;

public class WhiteboxLuisRoomTarget : TargetRules
{
	public WhiteboxLuisRoomTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("WhiteboxLuisRoom");
	}
}
