using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ilSFV.Hash
{
    /// <summary>
    /// Calculates a 32-bit Cyclic Redundancy Checksum (CRC) using the
    /// same polynomial used by Zip.
    /// </summary>
    public unsafe static class CRC32
    {
        private static readonly uint[] _lookup32Unsafe = CreateLookup32Unsafe();
        private static readonly uint* _lookup32UnsafeP = (uint*)GCHandle.Alloc(_lookup32Unsafe, GCHandleType.Pinned).AddrOfPinnedObject();
        private const int BUFFER_SIZE = 8192;

        /// <summary>
        /// Returns the CRC32 Checksum of a specified file as a string.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns>CRC32 Checksum as a string.</returns>
        public static string Calculate(FileInfo file)
        {
            if (file == null)
                throw new ArgumentNullException(nameof(file));

            return FastCrcHexString(CalculateInt32(file));
        }

        /// <summary>
        /// Returns the CRC32 Checksum of an input stream as a string.
        /// </summary>
        /// <param name="stream">Input stream.</param>
        /// <returns>CRC32 Checksum as a string.</returns>
        public static string Calculate(Stream stream)
        {
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            return FastCrcHexString(CalculateInt32(stream));
        }

        /// <summary>
        /// Returns the CRC32 Checksum of a byte array as a string.
        /// </summary>
        /// <param name="data">The byte array.</param>
        /// <returns>CRC32 Checksum as a string.</returns>
        public static string Calculate(byte[] data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            return FastCrcHexString(CalculateInt32(data));
        }

        /// <summary>
        /// Returns the CRC32 Checksum of a specified file as a four byte signed integer (Int32).
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns>CRC32 Checksum as a four byte signed integer (Int32).</returns>
        private static uint CalculateInt32(FileInfo file)
        {
            if (file == null)
                throw new ArgumentNullException(nameof(file));

            using (FileStream fileStream = file.Open(FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return CalculateInt32(fileStream);
            }
        }

        /// <summary>
        /// Returns the CRC32 Checksum of an input stream as a four byte signed integer (Int32).
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <returns>CRC32 Checksum as a four byte signed integer (Int32).</returns>
        public static uint CalculateInt32(Stream stream)
        {
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            stream.Position = 0;
            uint crc32Result = 0;
            byte[] buffer = new byte[BUFFER_SIZE];

            int count = stream.Read(buffer, 0, BUFFER_SIZE);
            while (count > 0)
            {
                crc32Result = Soft160.Data.Cryptography.CRC.Crc32(buffer, 0, count, crc32Result);
                count = stream.Read(buffer, 0, BUFFER_SIZE);
            }

            return crc32Result;
        }

        /// <summary>
        /// Returns the CRC32 Checksum of a byte array as a four byte signed integer (Int32).
        /// </summary>
        /// <param name="data">The byte array.</param>
        /// <returns>CRC32 Checksum as a four byte signed integer (Int32).</returns>
        private static uint CalculateInt32(byte[] data)
        {
            if (data == null)
                throw new ArgumentNullException("data");

            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                return CalculateInt32(memoryStream);
            }
        }

        /// <summary>
        /// Finalize the FastCRC output as hexadecimal string.
        /// </summary>
        /// <param name="runningCrc">The CRC32 under construction.</param>
        /// <returns>CRC32 Checksum as uppercase hexadecimal string.</returns>
        private static string FastCrcHexString(uint runningCrc)
        {
            byte[] fullCrcBytes = BitConverter.GetBytes(runningCrc);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(fullCrcBytes);
            }

            return ByteArrayToHexViaLookup32Unsafe(fullCrcBytes);
        }

        /// <summary>
        /// https://stackoverflow.com/questions/311165/how-do-you-convert-a-byte-array-to-a-hexadecimal-string-and-vice-versa
        /// </summary>
        /// <returns>A lookup table for each byte.</returns>
        private static uint[] CreateLookup32Unsafe()
        {
            var result = new uint[256];
            for (int i = 0; i < 256; i++)
            {
                string s = i.ToString("X2");

                if (BitConverter.IsLittleEndian)
                    result[i] = ((uint)s[0]) + ((uint)s[1] << 16);
                else
                    result[i] = ((uint)s[1]) + ((uint)s[0] << 16);
            }

            return result;
        }

        public static string ByteArrayToHexViaLookup32Unsafe(byte[] bytes)
        {
            var lookupP = _lookup32UnsafeP;
            var result = new char[bytes.Length * 2];
            fixed (byte* bytesP = bytes)
            fixed (char* resultP = result)
            {
                uint* resultP2 = (uint*)resultP;
                for (int i = 0; i < bytes.Length; i++)
                {
                    resultP2[i] = lookupP[bytesP[i]];
                }
            }

            return new string(result);
        }
    }
}