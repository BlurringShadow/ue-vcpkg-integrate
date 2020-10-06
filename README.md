# ue-vcpkg-integrate
## Overview
A simple unreal engine project template to support C++17 standard and [vcpkg](https://github.com/microsoft/vcpkg). The outside UE project contains the usage
## Structure
- [VcpkgIntegrate](https://github.com/BlurringShadow/ue-vcpkg-integrate/tree/master/Plugins/VcpkgIntegrate) A plugin to support vcpkg lib using in project.
  - Search vcpkg path from your environment varibles. (see [FindVcpkgPathFromEv](https://github.com/BlurringShadow/ue-vcpkg-integrate/blob/add10be5d0709cb6655a0c2f2ceebcad9a043f2c/Plugins/VcpkgIntegrate/Source/VcpkgIntegrate/VcpkgIntegrate.Build.cs#L13)) 
  - Contain two headers, [](https://github.com/BlurringShadow/ue-vcpkg-integrate/blob/master/Plugins/VcpkgIntegrate/Source/VcpkgIntegrate/Public/third_include_end.h) and [third_include_start](https://github.com/BlurringShadow/ue-vcpkg-integrate/blob/master/Plugins/VcpkgIntegrate/Source/VcpkgIntegrate/Public/third_include_end.h), to prevent macro conflict.
- [MacroHeaderGenerator](https://github.com/BlurringShadow/ue-vcpkg-integrate/tree/master/Plugins/VcpkgIntegrate/MacroHeaderGenerator) A .NET Core (Ver 3.1) console project to generate the two headers mentioned above. Get the Unreal Engine install path from command line arguments, then search all headers recursively to get macros. Finally generate the headers for those macros.
    - If you want to generate your own headers
        - Build the project and use command line to run the exe and input the Unreal Engine install path as argument.
        - Open the project then add path to the project properties->debug->application variables.
        - Modified the source to hard coding path.