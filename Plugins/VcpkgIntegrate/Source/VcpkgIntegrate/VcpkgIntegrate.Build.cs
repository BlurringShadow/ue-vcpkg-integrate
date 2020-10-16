using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnrealBuildTool;

public class BaseModuleRules : ModuleRules
{
    public BaseModuleRules(ReadOnlyTargetRules target, bool isModulePublic = true, params string[] dependencyModuleNames) : base(target)
    {
        PublicDependencyModuleNames.AddRange(dependencyModuleNames);
        if (isModulePublic) PublicSystemIncludePaths.Add(ModuleDirectory);
        bUseUnity = false;
        PCHUsage = PCHUsageMode.NoPCHs;
    }
}


public class VcpkgIntegrate : BaseModuleRules
{
    public VcpkgIntegrate(ReadOnlyTargetRules target) : base(target, true, "Core")
    {
        OptimizeCode = CodeOptimization.Always;
        Type = ModuleType.CPlusPlus;
        PrecompileForTargets = PrecompileTargetsType.Game;

        SetDependency(target.Platform);
    }

    void SetDependency(UnrealTargetPlatform platform)
    {
        var sourcePath = "";
        var libExtension = "";
        var binExtension = "";
        if (platform == UnrealTargetPlatform.Win64)
        {
            sourcePath = Path.Combine(ModuleDirectory, "Win64");
            libExtension = "lib";
            binExtension = "dll";
        }
        else if (platform == UnrealTargetPlatform.Linux)
        {
            sourcePath = Path.Combine(ModuleDirectory, "Linux");
            libExtension = "a";
            binExtension = "so";
        }

        PublicAdditionalLibraries.AddRange(GetPathsByExtension(Path.Combine(sourcePath, "lib"), libExtension));
        foreach (var path in GetPathsByExtension(Path.Combine(sourcePath, "bin"), binExtension))
            RuntimeDependencies.Add(Path.Combine("$(BinaryOutputDir)", Path.GetFileName(path)), path);
    }

    static IEnumerable<string> GetPathsByExtension(string libPath, string extension)
    {
        return Directory.GetFiles(libPath, "*." + extension);
    }
}