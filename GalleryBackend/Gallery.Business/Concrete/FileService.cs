using Gallery.Business.Abstract;
using Microsoft.AspNetCore.Http;

namespace Gallery.Business.Concrete
{
    public class FileService : IFileService
    {
        Task IFileService.DeleteFile(string filePath)
        {
            throw new NotImplementedException();
        }

        Task IFileService.DeleteMultipleFiles(List<string> filePaths)
        {
            throw new NotImplementedException();
        }

        Task<string> IFileService.SaveFileAsync(IFormFile file, string folderName)
        {
            throw new NotImplementedException();
        }

        Task<List<string>> IFileService.SaveMultipleFilesAsync(ICollection<IFormFile> files, string folderName)
        {
            throw new NotImplementedException();
        }
    }
}
