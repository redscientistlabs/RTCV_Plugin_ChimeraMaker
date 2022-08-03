using CHIMERA_MAKER.UI;
using NLog;
using RTCV.Common;
using RTCV.CorruptCore;
using RTCV.NetCore;
using RTCV.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CHIMERA_MAKER
{
    internal class PluginConnectorEMU : IRoutable
    {
        CHIMERA_MAKER plugin;

        public PluginConnectorEMU(CHIMERA_MAKER _plugin)
        {
            plugin = _plugin;
            LocalNetCoreRouter.registerEndpoint(this, Ep.EMU_SIDE);
        }

        public object OnMessageReceived(object sender, NetCoreEventArgs e)
        {
            NetCoreAdvancedMessage message = e.message as NetCoreAdvancedMessage;
            switch (e.message.Type)
            {
                case Commands.SHOW_WINDOW:
                    try
                    {
                        SyncObjectSingleton.FormExecute(() =>
                        {
                            if (((Control)S.GET<PluginForm>()).IsDisposed)
                            {
                                CHIMERA_MAKER.PluginForm = new PluginForm(plugin);
                                S.SET<PluginForm>(CHIMERA_MAKER.PluginForm);
                            }
                            ((Control)S.GET<PluginForm>()).Show();
                            ((Form)S.GET<PluginForm>()).Activate();
                        });
                        break;
                    }
                    catch
                    {
                        Logging.GlobalLogger.Error($"{nameof(PluginConnectorEMU)}: SHOW_WINDOW failed Reason:\r\n" + e.ToString());
                        break;
                    }
                case Commands.GET_TEMPLATES:
                    try
                    {
                        Tuple<string[], List<StashKey>, int> tuple = (Tuple<string[], List<StashKey>, int>)message.objectValue;
                        e.setReturnValue(this.GenerateStateTemplates(tuple.Item1, tuple.Item2, tuple.Item3));
                        break;
                    }
                    catch (Exception ex)
                    {
                        if (!(ex is ArgumentNullException))
                        {
                            NullReferenceException referenceException = ex as NullReferenceException;
                            break;
                        }
                        break;
                    }
            }
            return e.returnMessage;
        }

        private BlastLayer BlastlayerFromState(string[] domains, int precision)
        {
            List<BlastUnit> bus = new List<BlastUnit>();
            foreach (var domain in domains)
            {
                var mi = MemoryDomains.GetInterface(domain);
                if (mi == null)
                {
                    continue;
                }
                for (long i = 0; i < mi.Size; i += precision)
                {
                    if (i + precision > mi.Size)
                    {
                        break;
                    }
                    var bu = new BlastUnit(mi.PeekBytes(i, i + precision, !mi.BigEndian), domain, i, precision, mi.BigEndian);
                    bus.Add(bu);
                }
            }
            return bus.Count > 0 ? new BlastLayer(bus) : new BlastLayer();
        }

        private List<BlastLayer> GenerateStateTemplates(string[] SELECTED_DOMAINS, List<StashKey> states, int precision)
        {
            List<BlastLayer> bls = new List<BlastLayer>();
            List<StashKey> stashKeys = new List<StashKey>();
            foreach (var state in states)
            {
                SyncObjectSingleton.FormExecute(() => StockpileManagerEmuSide.LoadRomNet(state));
                StockpileManagerEmuSide.LoadStateNet(state, false);
                bls.Add(BlastlayerFromState(SELECTED_DOMAINS, precision));
            }
            return bls;
        }

        //private byte[] GetByteArr(long start, long end, string domain)
        //{
        //    MemoryInterface memoryInterface = MemoryDomains.GetInterface(domain);
        //    return end >= memoryInterface.get_Size() ? (byte[])null : memoryInterface.PeekBytes(start, end, true);
        //}
    }
}
