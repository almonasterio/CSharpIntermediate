namespace CsharpIntermediate.Interfaces
{
    public class VideoUploader : ITask
    {
        public void Execute(){
            System.Console.WriteLine("Uploading a video");
        }
    }
}