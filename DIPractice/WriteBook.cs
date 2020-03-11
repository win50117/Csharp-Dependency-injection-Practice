namespace DIPractice
{
    internal class WriteBook
    {
        private IBook Book;

        public WriteBook(IBook _Book)
        {
            this.Book = _Book;
        }

        public string Wbook()
        {
            return this.Book.Write();
        }
    }
}