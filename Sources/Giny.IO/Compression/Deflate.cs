using System.IO.Compression;

namespace Giny.IO.Compression;

public class Deflate
{
    public static byte[] Compress(Stream input)
    {
        using (var compressStream = new MemoryStream())
        using (var compressor = new DeflateStream(compressStream, CompressionMode.Compress))
        {
            input.CopyTo(compressor);
            compressor.Close();
            return compressStream.ToArray();
        }
    }
    public static byte[] Decompress(Stream input)
    {
        using (MemoryStream output = new MemoryStream())
        {
            using (DeflateStream decompressionStream = new DeflateStream(input, CompressionMode.Decompress))
            {
                decompressionStream.CopyTo(output);
                return output.ToArray();
            }
        }
    }
}