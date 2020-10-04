﻿namespace FileTypeChecker.Types
{
    using FileTypeChecker.Abstracts;

    public class RarArchive : FileType, IFileType
    {
        private const string name = "RAR archive";
        private const string extension = "rar";
        private static readonly byte[][] magicBytesJaggedArray = { new byte[] { 0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x00 }, new byte[] { 0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x01, 0x00 } };

        public RarArchive() : base(name, extension, magicBytesJaggedArray)
        {
        }
    }
}
