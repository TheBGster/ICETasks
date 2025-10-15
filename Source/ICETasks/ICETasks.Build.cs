// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ICETasks : ModuleRules
{
	public ICETasks(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ICETasks",
			"ICETasks/Variant_Platforming",
			"ICETasks/Variant_Platforming/Animation",
			"ICETasks/Variant_Combat",
			"ICETasks/Variant_Combat/AI",
			"ICETasks/Variant_Combat/Animation",
			"ICETasks/Variant_Combat/Gameplay",
			"ICETasks/Variant_Combat/Interfaces",
			"ICETasks/Variant_Combat/UI",
			"ICETasks/Variant_SideScrolling",
			"ICETasks/Variant_SideScrolling/AI",
			"ICETasks/Variant_SideScrolling/Gameplay",
			"ICETasks/Variant_SideScrolling/Interfaces",
			"ICETasks/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
