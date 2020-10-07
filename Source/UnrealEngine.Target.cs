// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public abstract class TargetBase : TargetRules
{
    public const string ProjectModuleName = "UnrealEngine";

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

public class UnrealEngineTarget : TargetBase
{
    public UnrealEngineTarget(TargetInfo target) : base(target, TargetType.Game)
    {
    }
}