using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.FileHelperManager
{
    public interface IFileHelper
    {
        string Upload(IFormFile file, string root);
        void Delete (string filePath);
        string Update(IFormFile file, string root,string filePath);

    
    }
}
