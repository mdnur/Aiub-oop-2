using System;
namespace final_lab_task
{
	public interface MobileInterface
	{
		bool message(string number);
		bool call(string number);
		void gallery();
		void calculator();
        void music();
		void fmRadio();
        VideoPlayer videoPlayer(int videoID);
        void recoder();
		void fileManager();
		void setting();
    }
}

