# Chorizite plugin msbuild tasks

By default this will:
  - Update the following build properties based on data read from `ChoriziteManifestFile`:
    - Version (version)
    - PackageVersion (version)
    - AssemblyVersion (<major version>.0.0)
    - Description (description)
    - Title (name)
    - Product (name)
    - PackageId (name)
    - Authors (author)
    - Company (author)
 - Copy the plugin after build to the chorizite plugins directory

## Build task properties:
```xml
<PropertyGroup>
    <!-- Copy plugin to Chorizite install directory after building. -->
    <ChoriziteCopyPluginOnBuild>True</ChoriziteCopyPluginOnBuild>
    
    <!-- Absolute path to plugin manifest file. -->
    <ChoriziteManifestFile>$(MSBuildProjectDirectory)\manifest.json</ChoriziteManifestFile>
    
    <!-- Path to chorizite installation directory. -->
    <ChoriziteInstallDir>$(registry:HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Thrungus\Chorizite)</ChoriziteInstallDir>
    
    <!-- Set to true to set the Version property from manifest.json -->
    <ChoriziteSetVersion>True</ChoriziteSetVersion>
    
    <!-- Set to true to set the AssemblyVersion property from manifest.json -->
    <ChoriziteSetAssemblyVersion>True</ChoriziteSetAssemblyVersion>
    
    <!-- Set to true to set the PackageVersion property from manifest.json -->
    <ChoriziteSetPackageVersion>True</ChoriziteSetPackageVersion>
    
    <!-- Set to true to set the nuget package meta properties from manifest.json -->
    <ChoriziteSetPackageMeta>True</ChoriziteSetPackageMeta>
</PropertyGroup>
```