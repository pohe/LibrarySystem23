using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem23
{
    public class Media
    {

        private int _mediaId;

        public int MediaId
        {
            get { return _mediaId; }
        }

        //propfull
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


        
        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }


        private string _publisher;

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }


        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        //ctor tab tab
        public Media(int mediaId, string title, string author, string publisher, int year)
        {
            _mediaId = mediaId;
            _title = title;
            _author = author;
            _publisher = publisher;
            _year = year;
        }
        public Media(string title)
        {
            _mediaId = 0;
            Title = title;
        }

        public Media() //default constructor
        {
            _mediaId = 0;
        }
        //skriv override mellemrum

        public override string ToString()
        {
            return $"MediaID: {_mediaId} || Title: {_title} || Author: {_author} || Publisher: {_publisher} || Year: {_year}";
        }
    }
}
