﻿
namespace OnlineRadio.Exceptions
{
   public class InvalidSongMinutesException:InvalidSongLengthException
    {
        private new const string Message = "Song minutes should be between 0 and 14.";
        public InvalidSongMinutesException() : base(Message)
        {
        }
    }
}
