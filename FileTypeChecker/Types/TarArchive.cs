﻿namespace FileTypeChecker.Types
{
    using FileTypeChecker.Abstracts;

    public class TarArchive : FileType, IFileType
    {
        public const string TypeName = "TAR Archive";
        public const string TypeExtension = "tar";
        private static readonly byte[] magicBytes = new byte[] { 0x75, 0x73, 0x74, 0x61, 0x72 };

        public TarArchive() : base(TypeName, TypeExtension, magicBytes)
        {
        }
    }
}
