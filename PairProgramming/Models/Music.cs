namespace PairProgramming.Models
{
    public class Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Id { get; set; }

        public void ValidateId()
        {
            if (Id == null)
            {
                throw new ArgumentNullException("id cannot be null");
            }

        }

        public void ValidateTitle()
        {
            if (Title == null)
            {
                throw new ArgumentNullException("name cannot be null");
            }
            if (Title.Length < 2)
            {
                throw new ArgumentException("Name cannot be shorter than 2");

            }
        }

        
    }
}