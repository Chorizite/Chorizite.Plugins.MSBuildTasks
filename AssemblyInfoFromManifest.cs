using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.IO;

namespace Chorizite.Plugins.MSBuildTasks
{
    public class AssemblyInfoFromManifest : Task
    {
        public override bool Execute()
        {
            var projectDir = Path.GetDirectoryName(BuildEngine.ProjectFileOfTaskNode);
            var manifestFile = Path.Combine(projectDir, "manifest.json");
            if (!File.Exists(manifestFile))
            {
                Log.LogError($"{manifestFile} not found");
                return false;
            }
            Log.LogMessage(MessageImportance.High, $"Aloha 123: {manifestFile}");
            /*
            if (!PluginManifest.TryLoadManifest<PluginManifest>(manifestFile, out var manifest, out var errorString)) {
                Log.LogError($"Failed to load manifest ({manifestFile}): {errorString}");
                return false;
            }

            Log.LogMessage(MessageImportance.High, $"Aloha 123:");
            Log.LogMessage(MessageImportance.High, $"\t {manifest.Name} {manifest.Version}");
            Log.LogMessage(MessageImportance.High, $"\t {manifest.Description}");
            */
            return true;
        }
    }
}
