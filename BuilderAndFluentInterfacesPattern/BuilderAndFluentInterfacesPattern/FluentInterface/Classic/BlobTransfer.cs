using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentInterface.Classic
{
    public class BlobTransfer : IBlobTransfer
    {
        public void BlobDownload(string connectionString, string blobName, string fileName, string filePath)
        {
            throw new NotImplementedException();
        }

        public void BlobDownload(string connectionString, string blobName, string fileName, Stream stream)
        {
            throw new NotImplementedException();
        }

        public void BlobUpload(string connectionString, string blobName, string fileName, string filePath)
        {
            throw new NotImplementedException();
        }

        public void BlobUpload(string connectionString, string blobName, string fileName, Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
