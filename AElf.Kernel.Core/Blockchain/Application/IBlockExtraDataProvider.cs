using System.Threading.Tasks;
using Google.Protobuf;

namespace AElf.Kernel.Blockchain.Application
{
    public interface IBlockExtraDataProvider
    {
        Task<ByteString> FillExtraDataAsync(BlockHeader blockHeader);
    }
}