using RTCV.CorruptCore;
using RTCV.NetCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHIMERA_MAKER
{
    public class CustomStateDump
    {
        public Dictionary<string, byte[]> MemoryDumps = new Dictionary<string, byte[]>();
        public string StateId = null;
    }

    public static class ChimeraMakerCache
    {
        public static string chimeraMakerCacheDir = Path.Combine(RtcCore.PluginDir, "CHIMERAMAKER");

        public static Dictionary<string, CustomStateDump> RamCache = new Dictionary<string, CustomStateDump>();
        public static bool useRamCache = true;
        public static void ResetCache()
        {
            //clear dictonary
            RamCache.Clear();


            if (!Directory.Exists(chimeraMakerCacheDir))
                Directory.CreateDirectory(chimeraMakerCacheDir);

            foreach (var f in Directory.GetFiles(chimeraMakerCacheDir))
                File.Delete(f);
        }

        public static void RebuildCache(StashKey[] states)
        {
            foreach(var state in states)
            {
                CustomStateDump dump = LocalNetCoreRouter.QueryRoute<CustomStateDump>(Ep.EMU_SIDE, Commands.GET_TEMPLATE, state);

                if (useRamCache)
                    RamCache.Add(state.Key, dump);
                else
                    WriteDumpToDrive(state, dump);
            }

        }

        public static void WriteDumpToDrive(StashKey state, CustomStateDump dump)
        {
            foreach(var domain in dump.MemoryDumps)
            {
                var targetFile = Path.Combine(chimeraMakerCacheDir, $"{state.Key}_{domain.Key}_dump.bin");
                File.WriteAllBytes(targetFile, domain.Value);
            }
        }

        public static CustomStateDump GetDump(StashKey state)
        {
            if(useRamCache)
            {
                if (RamCache.TryGetValue(state.Key, out CustomStateDump csd))
                    return csd;
                else
                    return null;
            }

            var di = new DirectoryInfo(chimeraMakerCacheDir);
            var keyDumps = di.GetFiles().Where(it => it.Name.StartsWith(state.Key));

            var csDump = new CustomStateDump();

            foreach (var dump in keyDumps)
            {
                var nameParts = dump.Name.Split('_');
                var domainPart = nameParts[1];

                var data = File.ReadAllBytes(dump.FullName);

                csDump.MemoryDumps[domainPart] = data;
            }

            csDump.StateId = state.Key;

            return csDump;
        }
    }
}
