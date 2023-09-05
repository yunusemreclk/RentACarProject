using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Core.Utilities.Helpers.FileHelp
{
    public interface IFileHelper
    {
        void Delete(string filePath);
        string Upload(IFormFile file, string root);
        string Update(IFormFile file, string filePath, string root);
   
    }
}

