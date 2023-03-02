namespace assignment01_gbcbids.Services
{
    public interface IFileService
    {
        public string SaveImage(IFormFile formFile);
        public bool DeleteImage(string imageFileName);
    }
}
