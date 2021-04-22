using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentInterface.Fluent
{
    public class FluentBlobTransfer: IBlob, IAction, IWrite, IRead
    {
        private readonly string connectionString;
        private string blobBlockPath;
        private string fileName;
        private TransferType type;

        private FluentBlobTransfer(string connectionString) => this.connectionString = connectionString;

        public static IBlob Connect(string connectionString) => new FluentBlobTransfer(connectionString);

        public IAction OnBlob(string blobBlockPath)
        {
            this.blobBlockPath = blobBlockPath;

            return this;
        }

        public IWrite Download(string fileName)
        {
            this.fileName = fileName;
            type = TransferType.Download;

            return this;
        }

        public IRead Upload(string fileName)
        {
            type = TransferType.Upload;
            this.fileName = fileName;

            return this;
        }

        public void ToFile(string filePath)
        {
            // Code to download from Azure Blob Storage to file
        }

        public async Task ToFileAsync(string filePath)
        {
            // Code to download async from Azure Blob Storage to file
        }

        public void ToStream(Stream stream)
        {
            // Code to download from Azure Blob Storage to stream
        }

        public async Task ToStreamAsync(Stream stream)
        {
            // Code to download async from Azure Blob Storage to stream
        }

        public void FromFile(string filePath)
        {
            // Code to upload from file to Azure Blob Storage
        }

        public async Task FromFileAsync(string filePath)
        {
            // Code to upload async from file to Azure Blob Storage
        }

        public void FromStream(Stream stream)
        {
            // Code to upload from stream to Azure Blob Storage
        }

        public async Task FromStreamAsync(Stream stream)
        {
            // Code to upload async from stream to Azure Blob Storage
        }
    }
}
