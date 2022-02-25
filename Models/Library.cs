using System;

namespace LendingLibrary.Models
{
    public class Library
    {
        public List<Novel> NovelList
        {
            // no setter
            get { return NovelList; }
        }

        public List<Textbook> TextbookList
        {
            // no setter
            get { return TextbookList; }
        }

        public List<Album> AlbumList
        {
            // no setter
            get { return AlbumList; }
        }

        public List<Audiobook> AudiobookList
        {
            // no setter
            get { return AudiobookList; }
        }

        
        public void List<Novel>.Add(Models.Novel item);
    
    }
}