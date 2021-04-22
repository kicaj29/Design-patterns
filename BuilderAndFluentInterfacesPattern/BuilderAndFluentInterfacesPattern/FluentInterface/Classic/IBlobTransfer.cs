using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentInterface.Classic
{
    /// <summary>
    /// Classic approach.
    /// </summary>
    interface IBlobTransfer
    {
        void BlobDownload(string connectionString, string blobName, string fileName, string filePath);
        void BlobDownload(string connectionString, string blobName, string fileName, Stream stream);
        void BlobUpload(string connectionString, string blobName, string fileName, string filePath);
        void BlobUpload(string connectionString, string blobName, string fileName, Stream stream);
    }
}
