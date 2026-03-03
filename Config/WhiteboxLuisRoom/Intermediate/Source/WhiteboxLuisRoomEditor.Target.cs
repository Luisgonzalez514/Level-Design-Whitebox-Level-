using UnrealBuildTool;

public class WhiteboxLuisRoomEditorTarget : TargetRules
{
	public WhiteboxLuisRoomEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("WhiteboxLuisRoom");
	}
}
