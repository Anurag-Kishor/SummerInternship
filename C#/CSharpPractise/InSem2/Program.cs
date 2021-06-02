using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jpeg> photo = new List<Jpeg();
            photo.Add(new Jpeg());
            photo.Add(new Jpeg());
            photo.Add(new Jpeg());


            PhotoStudio<Jpeg> ps = new PhotoStudio<Jpeg>();
            ps.PlaceOrder(photo, PhotoType.Jpeg);
            ps.GetGrayScaleAlbum();
        }
    }

    public enum PhotoType { Jpeg, Png};
    
    public interface IFilter<T>
    {
        public T GrayScale(T img);
    }
    class Jpeg { }

    class JpegFilter<T> : IFilter<T>
    {
        public T GrayScale(T jpeg) { /*convert to grayscale*/ return jpeg; }

       
    }

    class Png { } /* represents a PNG file */
    class PngFilter<T> : IFilter<T>
    {
        public T GrayScale(T png) { /*convert to grayscale*/ return png; }
      
    }

    public interface IPhotoStudio<T> {
        public void PlaceOrder(List<T> photos, PhotoType image);
    }



    class PhotoStudio<T> 
    {
        private IFilter<T> filter;
        private List<T> photos;
        //private List<Png> pngs;
        public void PlaceOrder(List<T> photos,  PhotoType image)
        {
            switch (image)
            {
                case PhotoType.Jpeg:
                    filter = new JpegFilter<T>();
                    this.photos = photos;
                    break;
                case PhotoType.Png:
                    filter = new PngFilter<T>();
                    this.photos = photos;
                    break;
            }
        }

        public List<T> GetGrayScaleAlbum() 
        {
            List<T> album = new List<T>();
            foreach (var photo in photos)
                album.Add(filter.GrayScale(photo));
            return album;
        }
       
    }

    }
