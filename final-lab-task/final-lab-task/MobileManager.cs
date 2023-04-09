using System;
namespace final_lab_task
{
	public class MobileManager : MobileInterface
    {
		public MobileManager()
		{
		}

        public void calculator()
        {
            Console.WriteLine("mananing calculator");
        }

        public bool call(string number)
        {
            if (number != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void fileManager()
        {
            Console.WriteLine("file ");
        }

        public void fmRadio()
        {
            Console.WriteLine("fmRadio ");
        }

        public void gallery()
        {
            Console.WriteLine("gallery ");
        }

        public bool message(string number)
        {
            if (number != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void music()
        {
            Console.WriteLine("Music");
        }

        public VideoPlayer videoPlayer(int videoID)
        {
            Console.WriteLine("video playing");
            return new VideoPlayer(videoID);
        }

        public void recoder()
        {
            Console.WriteLine("recoder");
        }

        public void setting()
        {
            Console.WriteLine("setting");
        }
    }
}

