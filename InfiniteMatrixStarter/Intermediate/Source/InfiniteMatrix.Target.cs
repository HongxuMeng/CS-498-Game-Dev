using UnrealBuildTool;

public class InfiniteMatrixTarget : TargetRules
{
	public InfiniteMatrixTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("InfiniteMatrix");
	}
}
