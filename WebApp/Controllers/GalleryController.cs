using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Hosting;
using System.Web.Http;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class GalleryController : ApiController
    {
        List<ImageModel> images = new List<ImageModel>()
        {
            new ImageModel {id = 0, title = "Dog0" , imagepath ="~/App_Data/sample_0.jpg"},
            new ImageModel {id = 1, title = "Dog1" , imagepath ="~/App_Data/sample_1.jpg"},
            new ImageModel {id = 1, title = "Dog2" , imagepath ="~/App_Data/sample_2.jpg"},
            new ImageModel {id = 1, title = "Dog3" , imagepath ="~/App_Data/sample_3.jpg"},
            new ImageModel {id = 1, title = "Dog4" , imagepath ="~/App_Data/sample_4.jpg"},
            new ImageModel {id = 1, title = "Dog5" , imagepath ="~/App_Data/sample_5.jpg"},
            new ImageModel {id = 1, title = "Dog6" , imagepath ="~/App_Data/sample_6.jpg"},
            new ImageModel {id = 1, title = "Dog7" , imagepath ="~/App_Data/sample_7.jpg"},
        };
                
         

        public IEnumerable<ImageModel> GetAllImages()
        {
            return images;
        }

        public HttpResponseMessage GetImage(int id)
        {
            var result = new HttpResponseMessage(HttpStatusCode.OK);
            String filePath = HostingEnvironment.MapPath(images[id].imagepath);
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            Image image = Image.FromStream(fileStream);
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Jpeg);
            result.Content = new ByteArrayContent(memoryStream.ToArray());
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");

            return result;
        }
    }
}
