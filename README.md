# Chorizite plugin msbuild tasks

Overridable build task properties:
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