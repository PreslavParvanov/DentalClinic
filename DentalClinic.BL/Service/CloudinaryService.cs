using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using DentalClinic.BL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.BL.Service
{
    public class CloudinaryService : ICloudinaryService
    {
        const string CloudinaryKey = "287841424234317";
        const string CloudinarySecret = "AHPTX1_c47FmOARrQvTo74pfTEs";
        const string CloudinaryName = "ddfrnob2x";

        Account account = new Account(CloudinaryName, CloudinaryKey, CloudinarySecret);

        public async Task<string> UploadImage(string FileName, string FileData)
        {
            string result = "OK";
            try
            {
                Cloudinary _cloudinary = new Cloudinary(account);
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(@"D:\SoftUni\Project\DentalClinic\DentalClinic\wwwroot\img\home.jpg")
                };
                var uploadResult = _cloudinary.Upload(uploadParams);
            }
            catch (Exception ex)
            {

                result = ex.Message.ToString();
            }

            return result;
        }
    }
}
