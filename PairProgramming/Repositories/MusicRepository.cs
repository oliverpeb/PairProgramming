using PairProgramming.Models;
using System.Runtime.CompilerServices;

namespace PairProgramming.Repositories
    
{
    public class MusicRepository
    {
        private static int _nextId = 1;
        private static readonly List<Music> Data = new List<Music>

            {
                new Music() { Title = "Hej", Genre = "Rock", Artist = "Halløj", Id = 1},
                new Music() { Title = "Farvel", Genre = "Pop", Artist = "Chris", Id = 2},
                new Music() { Title = "Goddag", Genre = "Rap", Artist = "Oliver", Id = 3},

            };
    

        

        public List<Music> GetAll(string Title = null, string sortby = null)
        {
           List<Music> Music = new List<Music>(Data);
            if (Title != null)
            {
                Music = Music.FindAll(Music => Music.Title != null && Music.Title.StartsWith(Title));
            }
            if (sortby != null)
            {
                switch (sortby.ToLower())
                {
                    case "Title":
                        Music = Music.OrderBy(Music=> Music.Title).ToList();
                        break;
                    case "Genre":
                        Music = Music.OrderBy(Music => Music.Genre).ToList();
                        break;
                    case "Artist":
                        Music = Music.OrderBy(Music => Music.Artist).ToList();
                        break;
                }
            }
            return Music;
        }

            
        public Music? GetbyID(int id)
        {
           return Data.Find(x => x.Id == id);

        }


        public Music Add(Music newMusic)
        {
            newMusic.Id = _nextId++;
            Data.Add(newMusic);
            return newMusic;

        }

        public Music? Delete(int id)
        {
            Music? foundMusic = GetbyID(id);
            if (foundMusic == null)
            {
                return null;
            }
            Data.Remove(foundMusic);
            return foundMusic;
            
        }

        public Music? Update(int id, Music update)
        {
            Music? foundMusic = GetbyID(id);
            if (foundMusic == null)
            {
                return null;
            }
            foundMusic.Artist = update.Artist;
            foundMusic.Title = update.Title;
            foundMusic.Genre = update.Genre;
            return foundMusic;

        }






        

    }
}
