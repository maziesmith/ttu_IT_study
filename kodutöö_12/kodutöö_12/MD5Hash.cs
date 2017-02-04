using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace kodutöö_12 {
    public static class MD5Hash {
        // From:
        // http://stackoverflow.com/questions/8299142/how-to-generate-md5-hash-code-for-my-winrt-app-using-c
        public static string Compute(string str) {
            var alg = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Md5);
            IBuffer buff = CryptographicBuffer.ConvertStringToBinary(str, BinaryStringEncoding.Utf8);
            var hashed = alg.HashData(buff);
            var res = CryptographicBuffer.EncodeToHexString(hashed);
            return res;
        }
    }
}
