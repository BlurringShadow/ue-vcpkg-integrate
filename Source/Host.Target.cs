// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using UnrealBuildTool;
using System.Collections.Generic;

public abstract class TargetBase : TargetRules
{
    public const string ProjectModuleName = "Host";

    protected TargetBase(TargetInfo target, UnrealBuildTool.TargetType type, IList<string> extraModuleNames = null) :
        base(target)
    {
        Type = type;
        DefaultBuildSettings = BuildSettingsVersion.V2;

        // ReSharper disable once PossibleNullReferenceException
        ExtraModuleNames.Add(ProjectModuleName);
        if (extraModuleNames != null) ExtraModuleNames.AddRange(extraModuleNames);
    }
}

public class HostTarget : TargetBase
{
    public HostTarget(TargetInfo target) : base(target, TargetType.Game)
    {
    }
}