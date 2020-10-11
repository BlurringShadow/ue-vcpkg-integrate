# ue-vcpkg-integrate
## Overview
A simple unreal engine project template to support C++17 standard and [vcpkg](https://github.com/microsoft/vcpkg) exports.
## Usage
1. Use export command in your vcpkg to export the package you want.
2. Copy the necessary files
    - headers: 
      [your_export]/installed/[platform]/include -> 
      [this_project]/Plugin/VcpkgIntegrate/Source/VcpkgIntegrate/Public
    - runtime dependencies: 
      [your_export]/installed/[platform]/bin -> 
      [this_project]/Plugin/VcpkgIntegrate/Source/VcpkgIntegrate/[platform]/bin
    - lib: 
      [your_export]/installed/[platform]/lib -> 
      [this_project]/Plugin/VcpkgIntegrate/Source/VcpkgIntegrate/[platform]/lib
3. Let unreal engine to regenerate your project flies.

## Structure
- [VcpkgIntegrate](https://github.com/BlurringShadow/ue-vcpkg-integrate/tree/master/Plugins/VcpkgIntegrate) A plugin to support vcpkg lib using in project.
  - Search lib export for different platform(currently only support Win64). Add libs and binaries to corresponding paths. Copy the binaries to ue build output directories.
  - Contain two headers, [third_include_end](https://github.com/BlurringShadow/ue-vcpkg-integrate/blob/master/Plugins/VcpkgIntegrate/Source/VcpkgIntegrate/Public/third_include_end.h) and [third_include_start](https://github.com/BlurringShadow/ue-vcpkg-integrate/blob/master/Plugins/VcpkgIntegrate/Source/VcpkgIntegrate/Public/third_include_end.h), to prevent macro conflict.
  - Current Added external libaries
    - [fmt](https://github.com/fmtlib/fmt):x64-windows 6.2.1
    - [boost](https://github.com/boostorg/boost):x64-windows 1.73.0
- [MacroHeaderGenerator](https://github.com/BlurringShadow/ue-vcpkg-integrate/tree/master/Plugins/VcpkgIntegrate/MacroHeaderGenerator) A .NET Core (Ver 3.1) console project to generate the two headers mentioned above. Get the Unreal Engine install path from command line arguments, then search all headers recursively to get macros. Finally generate the headers for those macros.
    - If you want to generate your own headers
        - Build the project and use command line to run the exe and input the Unreal Engine install path as argument.
        - Open the project then add path to the project properties->debug->application variables.
        - Modified the source to hard coding path.
