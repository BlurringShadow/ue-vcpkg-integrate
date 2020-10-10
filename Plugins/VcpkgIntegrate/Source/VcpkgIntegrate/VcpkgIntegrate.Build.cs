// Copyright Epic Games, Inc. All Rights Reserved.

using System;
using System.IO;
using System.Linq;
using UnrealBuildTool;

public class VcpkgIntegrate : ModuleRules
{
    public VcpkgIntegrate(ReadOnlyTargetRules target) : base(target)
    {
        PublicDependencyModuleNames.Add("Core");
        OptimizeCode = CodeOptimization.Always;
        Type = ModuleType.CPlusPlus;
        PrecompileForTargets = PrecompileTargetsType.Game;
        PCHUsage = PCHUsageMode.NoPCHs;
        bUseUnity = false;
        CppStandard = CppStandardVersion.Cpp17;
        PublicSystemIncludePaths.Add(ModuleDirectory);

        var platform = target.Platform;
        if (platform == UnrealTargetPlatform.Win64)
        {
            var sourcePath = Path.Combine(ModuleDirectory, "Win64");
            var binariesPaths = Directory.GetFiles(Path.Combine(sourcePath, "bin"), "*.dll");
            var outputPath = Path.Combine(PluginDirectory, "Binaries", "Win64");

            PublicAdditionalLibraries.AddRange(Directory.GetFiles(Path.Combine(sourcePath, "lib"), "*.lib"));
            Directory.CreateDirectory(outputPath);
            foreach (var path in binariesPaths)
            {
                var targetPath = Path.Combine(outputPath, Path.GetFileName(path));
                try { File.Copy(path, targetPath, true); }
                catch (Exception e) { Console.WriteLine(e); }

                RuntimeDependencies.Add(targetPath);
            }
        }

    }
}