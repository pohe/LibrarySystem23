using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem23
{
    public class MediaCatalog
    {
        //Lav en collection af typen List der kan indeholder Media objekter
        private List<Media> _mediaList;

        //Lav en constructor der initialiserer Listen

        public MediaCatalog()
        {
            _mediaList = new List<Media>();
        }

        public void AddMedia(Media aMedia)
        {
            //foreach(Media m in _mediaList)
            //{
            //    if (aMedia.MediaId ==m.MediaId )
            //    {
            //        return;
            //    }
            //}
            if (aMedia.Year < 2010)
                throw new ArgumentException("Det er ikke muligt at tilføje Medier før 2010");
            if (GetMedia(aMedia.MediaId) == null)
                _mediaList.Add(aMedia);
        }

        public void PrintMediaList()
        {
            //foreach (Media media in _mediaList)
            //{
            //    Console.WriteLine(media.ToString());
            //}

            int i=0;
            while(i<_mediaList.Count)
            {
                Console.WriteLine(_mediaList[i]);
                i++;
            }

        }

        public Media GetMedia(int mediaID)
        {
            foreach(Media aMedia in _mediaList)
            {
                if(aMedia.MediaId == mediaID)
                {
                    return aMedia;
                }
            }
            return null;
        }

        public override string ToString()
        {
            string returnString = "";
            foreach (Media media in _mediaList)
            {
                returnString = returnString + media.ToString()+ "\n";
            }
            return returnString;
        }

        public List<Media> GetMediaByAuthor(string author)
        {
            List<Media> returnList = new List<Media>();
            foreach (Media aMedia in _mediaList)
            {
                if (aMedia.Author!= null && aMedia.Author == author)
                        returnList.Add(aMedia);               
            
            }
            if (returnList.Count > 0)
                return returnList;
            else
                return null;
        }
    }
}
