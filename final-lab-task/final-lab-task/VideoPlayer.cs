using System;
namespace final_lab_task
{
	public class VideoPlayer
	{
		private int id;
		public VideoPlayer(int ID)
		{
			this.id = ID;
		}
		public VideoPlayer play()
		{
			if (this.id != 0)
			{
                Console.WriteLine("video is playing");
			}
			else
			{
				Console.WriteLine("video id is wrong");
			}
			return this;
		}
		public VideoPlayer pause()
		{
			if (this.id == 0)
            {
                
                Console.WriteLine("video id is wrong");
            }
            else
            {
                Console.WriteLine("video is pause");
            }
			return this;
        }

	}
}

