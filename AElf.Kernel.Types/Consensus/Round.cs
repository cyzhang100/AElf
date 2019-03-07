using System.Linq;

// ReSharper disable once CheckNamespace
namespace AElf.Kernel
{
    // ReSharper disable InconsistentNaming
    public partial class Round
    {
        public long RoundId => RealTimeMinersInformation.Values.Select(bpInfo => bpInfo.ExpectedMiningTime.Seconds).Sum();

    }
}