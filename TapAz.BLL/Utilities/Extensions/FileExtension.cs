﻿namespace TapAz.BLL.Utilities.Extensions;

public static class FileExtension
{
    public static string FileCreate(this IFormFile formFile, string env, string path)
    {
        string fileName = $"{Guid.NewGuid()}{formFile.FileName}";
        string fullPath = Path.Combine(env, path, fileName);
        using (FileStream fileStream = new(fullPath, FileMode.Create))
        {
            formFile.CopyTo(fileStream);
        }
        return fileName;
    }
}
