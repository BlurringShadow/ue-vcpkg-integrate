// Copyright Epic Games, Inc. All Rights Reserved.

using System;
using System.IO;
using System.Linq;
using UnrealBuildTool;

public class VcpkgIntegrate : ModuleRules
{
    public static readonly string VcpkgInstallPath = Path.Combine(FindVcpkgPathFromEv(), "installed", "x64-windows");
    public static readonly string VcpkgIncludePath = Path.Combine(VcpkgInstallPath, "include");
    public static readonly string VcpkgStaticLibraryPath = Path.Combine(VcpkgInstallPath, "lib");
    public static readonly string VcpkgDynamicLibraryPath = Path.Combine(VcpkgInstallPath, "bin");

    public static string FindVcpkgPathFromEv(string name = "vcpkg")
    {
        var paths = Environment.GetEnvironmentVariable("Path");
        var index = paths.IndexOf(name, StringComparison.OrdinalIgnoreCase);
        var endIndex = paths.IndexOf(';', index);
        for (; paths[index] != ';'; --index) ;
        return paths.Substring(index + 1, endIndex - index - 1);
    }

    public VcpkgIntegrate(ReadOnlyTargetRules target) : base(target)
    {
        PublicDependencyModuleNames.Add("Core");
        OptimizeCode = CodeOptimization.Always;
        Type = ModuleType.CPlusPlus;
        PrecompileForTargets = PrecompileTargetsType.Game;
        PCHUsage = PCHUsageMode.NoPCHs;
        bRequiresImplementModule = true;
        bUseUnity = true;

        var exceptLibs = new[]
        {
            "zlib",
            "libcrypto",
            "libssl",
            "libpng",
        };

        PublicSystemIncludePaths.AddRange(new[] { ModuleDirectory, VcpkgIncludePath });

        var paths = Directory.GetFiles(VcpkgStaticLibraryPath, "*.lib").ToList();
        paths.RemoveAll(
            path =>
            {
                foreach (var exceptLib in exceptLibs)
                    if (path.Contains(exceptLib))
                        return true;
                return false;
            }
        );
        PublicAdditionalLibraries.AddRange(Directory.GetFiles(VcpkgStaticLibraryPath, "*.lib"));

        paths = Directory.GetFiles(VcpkgDynamicLibraryPath, "*.dll").ToList();
        paths.RemoveAll(
            path =>
            {
                foreach (var exceptLib in exceptLibs)
                    if (path.Contains(exceptLib))
                        return true;
                return false;
            }
        );
        PublicDelayLoadDLLs.AddRange(paths);
        foreach (var path in paths) RuntimeDependencies.Add(path);

        CppStandard = CppStandardVersion.Cpp17;
    }
}