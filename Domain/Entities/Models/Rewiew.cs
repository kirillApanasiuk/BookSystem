namespace Entities
{
    public class Rewiew
    {
        public int RewiewId { get; set; }
        public string VoterName { get; set; }
        public int Stars { get; set; }
        public string Comment { get; set; }

        #region Nam properties
        public int BookId { get; set; }
        public Book Books { get; set; }
        #endregion
    }
}
