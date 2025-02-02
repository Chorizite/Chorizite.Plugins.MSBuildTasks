# Chorizite plugin msbuild tasks

By default this will set assembly version from manifest.json, as well as nuspec attributes like author/description.
It will also copy your plugin to your chorizite install directory after building.

## Build task properties:
```xml
<PropertyGroup>
    <!-- Copy plugin to Chorizite install directory after building. -->
    <ChoriziteCopyPluginOnBuild>True</ChoriziteCopyPluginOnBuild>
    
    <!-- Absolute path to plugin manifest file. -->
    <ChoriziteManifestFile>$(MSBuildProjectDirectory)\manifest.json</ChoriziteManifestFile>
    
    <!-- Path to chorizite installation directory. -->
    <ChoriziteInstallDir>$(registry:HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Thrungus\Chorizite)</ChoriziteInstallDir>
</PropertyGroup>
```