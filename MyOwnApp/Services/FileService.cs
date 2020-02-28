using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Services
{
    public class FileService
    {
        private readonly EFContext _context;
        private readonly IHostingEnvironment _appEnvironment;
        //public FileService(EFContext context, IHostingEnvironment appEnvironment)
        //{
        //    _context = context;
        //    _appEnvironment = appEnvironment;
        //}
        public async Task AddFile(IFormFile uploadedFile)
        {
            string id = Guid.NewGuid().ToString();
            string name = id + ".jpg";
            string path = "/files/" + name;
            using (var fileStream=new FileStream(_appEnvironment.WebRootPath+path,FileMode.Create))
            {
                await uploadedFile.CopyToAsync(fileStream);
            }
            FileModel file = new FileModel { Id = id, Name = name, Path = path };
            _context.FileModels.Add(file);
            _context.SaveChanges();
        }
        
    }
}
