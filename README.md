# Chorizite plugin msbuild tasks

By default this will:
  - Update the following build properties based on data read from `ChoriziteManifestFile` json:
    - Version (`manifest.version`) when `ChoriziteSetVersion` is True
    - PackageVersion (`manifest.version`) when `ChoriziteSetPackageVersion` is True
    - AssemblyVersion (`manifest.version.major`.0.0) when `ChoriziteSetAssemblyVersion` is True
    - Description (`manifest.description`) when `ChoriziteSetPackageMeta` is True
    - Title (`manifest.name`) when `ChoriziteSetPackageMeta` is True
    - Product (`manifest.name`) when `ChoriziteSetPackageMeta` is True
    - PackageId (`manifest.name`) when `ChoriziteSetPackageMeta` is True
    - Authors (`manifest.author`) when `ChoriziteSetPackageMeta` is True
    - Company (`manifest.author`) when `ChoriziteSetPackageMeta` is True
 - When building with Visual Studio:
    - Copy the plugin after build to the chorizite plugins directory when `ChoriziteCopyPluginOnBuild` is True
    - Create a manifest.dev.json that points to your project directory for hot-reloading rml assets when `ChoriziteGenerateDevManifest` and `ChoriziteCopyPluginOnBuild` are both True

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
    
    <!-- Set to true to generate manifest.dev.json with hot-reload path set to this projects source directory.
        This is only valid when `ChoriziteCopyPluginOnBuild` is set to True -->
    <ChoriziteGenerateDevManifest>True</ChoriziteGenerateDevManifest>
```