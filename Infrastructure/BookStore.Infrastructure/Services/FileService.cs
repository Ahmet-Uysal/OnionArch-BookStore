using BookStore.Application.Services;
using BookStore.Infrastructure.Operations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
namespace BookStore.Infrastructure.Services
{
    public class FileService : IFileService
    {
        IWebHostEnvironment _webHostEnvironment;

        public FileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<bool> CopyFileAsync(string path, IFormFile file)
        {
            try
            {
                using FileStream fileStream = new(
                      path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false
                   );
                await file.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }

        private async Task<string> FileRenameAsync(string path, string fileName, bool first = true)
        {
            // string newFileName = await Task.Run<string>(async () =>
            // {
            //     string extension = Path.GetExtension(fileName);
            //     string newFileName = String.Empty;
            //     if (first)
            //     {
            //         string oldName = Path.GetFileNameWithoutExtension(fileName);
            //         newFileName = $"{NameOperations.CharacterRegulatory(oldName)}{extension}";
            //     }
            //     else
            //     {
            //         newFileName = fileName;
            //         int indexNo1 = newFileName.LastIndexOf("-");
            //         int indexNo2 = newFileName.LastIndexOf(".");
            //         if (indexNo1 == -1 || indexNo2 - indexNo1 != 1)
            //         {
            //             newFileName = $"{Path.GetFileNameWithoutExtension(newFileName)}-2{extension}";
            //         }
            //         else
            //         {
            //             string fileNo = newFileName.Substring(indexNo1 + 1, indexNo2 - indexNo1 - 1);
            //             int _fileNo = int.Parse(fileNo);
            //             _fileNo++;
            //             newFileName = newFileName.Remove(indexNo1 + 1, indexNo2 - indexNo1 - 1)
            //                                    .Insert(indexNo1 + 1, _fileNo.ToString());
            //         }
            //     }
            //     if (File.Exists($"{path}/{newFileName}"))
            //         return await FileRenameAsync(path, newFileName, false);
            //     else
            //         return newFileName;
            // });
            string extension = Path.GetExtension(fileName);
            string oldName = Path.GetFileNameWithoutExtension(fileName);
            string newFileName = $"{NameOperations.CharacterRegulatory(oldName)}-{Guid.NewGuid()}{extension}";

            return newFileName;
        }

        public async Task<List<(string fileName, string path)>> UploadAsync(string path, IFormFileCollection files)
        {
            string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, path);
            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);
            List<(string fileName, string path)> datas = new();
            List<bool> results = new();
            foreach (var file in files)
            {
                string fileNewName = await FileRenameAsync(uploadPath, file.FileName);
                bool result = await CopyFileAsync($"{uploadPath}/{fileNewName}", file);
                datas.Add((fileNewName, $"{path}/{fileNewName}"));
                results.Add(result);
            }
            if (results.TrueForAll(r => r.Equals(true)))
                return datas;
            return null;
        }
    }
}