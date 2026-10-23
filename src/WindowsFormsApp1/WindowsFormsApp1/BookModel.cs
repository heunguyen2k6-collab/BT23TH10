namespace WindowsFormsApp1
{
    public class BookModel
    {
        public string BookId { get; set; }          // Mã sách
        public string Title { get; set; }           // Tên sách
        public string Author { get; set; }          // Tác giả
        public decimal Price { get; set; }          // Đơn giá
        public int Quantity { get; set; }           // Số lượng
        public string CoverImagePath { get; set; }  // Đường dẫn ảnh bìa
    }
}