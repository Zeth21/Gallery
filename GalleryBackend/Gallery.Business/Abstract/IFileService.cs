using Microsoft.AspNetCore.Http;

namespace Gallery.Business.Abstract
{
    public interface IFileService
    {
        Task<List<string>> SaveMultipleFilesAsync(ICollection<IFormFile> files, string folderName);
        Task<string> SaveFileAsync(IFormFile file, string folderName);
        Task DeleteFile(string filePath);
        Task DeleteMultipleFiles(List<string> filePaths);
    }
}
