using Chorizite.Plugins.MSBuildTasks.Lib;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Nodes;

namespace Chorizite.Plugins.MSBuildTasks
{
    public class AssemblyInfoFromManifest : Task
    {
        [Required]
        public string ManifestFile { get; set; }

        [Output]
        public string ManifestVersion { get; set; }

        [Output]
        public string ManifestAssemblyVersion { get; set; }

        [Output]
        public string ManifestName { get; set; }

        [Output]
        public string ManifestDescription { get; set; }

        [Output]
        public string ManifestAuthor { get; set; }

        public AssemblyInfoFromManifest() {
            AssemblyResolver.Enable();
        }

        public override bool Execute()
        {
            var projectDir = Path.GetDirectoryName(BuildEngine.ProjectFileOfTaskNode);
            if (!File.Exists(ManifestFile))
            {
                Log.LogError($"{ManifestFile} not found");
                return false;
            }

            var manifest = JsonNode.Parse(File.ReadAllText(ManifestFile)).AsObject();

            ManifestVersion = manifest["version"].ToString();
            ManifestName = manifest["name"].ToString();
            ManifestDescription = manifest["description"].ToString();
            ManifestAssemblyVersion = ManifestVersion.Split('.')[0] + ".0.0";
            ManifestAuthor = manifest["author"].ToString();

            return true;
        }
    }
}
