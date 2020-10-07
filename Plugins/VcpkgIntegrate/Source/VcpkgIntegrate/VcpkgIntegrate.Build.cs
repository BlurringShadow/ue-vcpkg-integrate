// Copyright Epic Games, Inc. All Rights Reserved.

using System;
using System.IO;
using UnrealBuildTool;

public class VcpkgIntegrate : ModuleRules
{
    public static readonly string VcpkgInstallPath = Path.Combine(FindVcpkgPathFromEv(), "installed", "x64-windows");
    public static readonly string VcpkgIncludePath = Path.Combine(VcpkgInstallPath, "include");
    public static readonly string VcpkgStaticLibraryPath = Path.Combine(VcpkgInstallPath, "lib");

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
        PCHUsage = PCHUsageMode.NoSharedPCHs;
        PrivatePCHHeaderFile = "VcpkgIntegrate.h";
        bUseUnity = true;

        PublicSystemIncludePaths.AddRange(new[] { ModuleDirectory, VcpkgIncludePath });
        PublicAdditionalLibraries.AddRange(
            Directory.GetFiles(VcpkgStaticLibraryPath, "*.lib", SearchOption.AllDirectories)
        );
        CppStandard = CppStandardVersion.Cpp17;
    }
}