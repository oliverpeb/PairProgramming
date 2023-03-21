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

            };
        }

    }
}
