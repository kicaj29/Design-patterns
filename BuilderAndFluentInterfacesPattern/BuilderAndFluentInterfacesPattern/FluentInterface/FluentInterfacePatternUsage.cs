using BuilderAndFluentInterfacesPattern.FluentInterface.Classic;
using BuilderAndFluentInterfacesPattern.FluentInterface.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentInterface
{
    public static class FluentInterfacePatternUsage
    {
        public async static void GoAsync()
        {
            FluentBlobTransfer
                .Connect("storageAccountConnectionString")
                .OnBlob("blobName")
                .Download("fileName")
                .ToFile(@"D:\Azure\Downloads\");

            await FluentBlobTransfer
                .Connect("storageAccountConnectionString")
                .OnBlob("blobName")
                .Upload("fileName")
                .FromStreamAsync(null);

            BlobTransfer bt = new BlobTransfer();
            bt.BlobDownload("storageAccountConnectionString", "blobName", "fileName", @"D:\Azure\Downloads\");

        }
    }
}
