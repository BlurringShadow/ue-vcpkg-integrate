// Fill out your copyright notice in the Description page of Project Settings.

using System.Diagnostics.CodeAnalysis;
using System.IO;
using UnrealBuildTool;

[SuppressMessage("ReSharper", "PossibleNullReferenceException"),
 SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
public class UnrealEngine : ModuleRules
{
    public UnrealEngine(ReadOnlyTargetRules target) : base(target)
    {
        PublicDependencyModuleNames.AddRange(new[] { "Core", "CoreUObject", "Engine", "InputCore", "VcpkgIntegrate" });

        PCHUsage = PCHUsageMode.NoSharedPCHs;
        PrivatePCHHeaderFile = "UnrealEngine.h";
        PublicSystemIncludePaths.Add(Path.Combine(ModuleDirectory, "header"));
        CppStandard = CppStandardVersion.Cpp17;
        bUseUnity = false;
        MinFilesUsingPrecompiledHeaderOverride = 1;
        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}