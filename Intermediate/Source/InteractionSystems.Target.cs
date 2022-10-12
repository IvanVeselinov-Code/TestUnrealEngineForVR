using UnrealBuildTool;

public class InteractionSystemsTarget : TargetRules
{
	public InteractionSystemsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("InteractionSystems");
	}
}
