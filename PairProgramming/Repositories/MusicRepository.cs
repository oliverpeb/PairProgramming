using PairProgramming.Models;
namespace PairProgramming.Repositories
    
{
    public class MusicRepository
    {

        private int _nextID;
        private List<Music> _music;

        public MusicRepository()
        {
            _music = new List<Music>()
            {
                new Music() { Title = "Hej", Genre = "Rock", Artist = "Halløj", Id = 1},
                new Music() { Title = "Farvel", Genre = "Pop", Artist = "Chris", Id = 2},
                new Music() { Title = "Goddag", Genre = "Rap", Artist = "Oliver", Id = 3},

            };

        }

        public List<Music> GetAll()
        {
           return new List<Music>(_music);
        }

            
        public Music? GetbyID(int id)
        {
           return _music.Find(x => x.ID == id);

        }


        public Music Add(Music newMusic)
        {
            newMusic.Id = _nextID++;
            _music.Add(newMusic);
            return newMusic;

        }

        public Music? Delete(int id)
        {
            Music? foundMusic = GetbyID(id);
            


        }




        

    }
}
