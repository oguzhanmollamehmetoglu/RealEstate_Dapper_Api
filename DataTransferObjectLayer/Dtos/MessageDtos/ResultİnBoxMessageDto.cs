﻿namespace DataTransferObjectLayer.Dtos.MessageDtos
{
    public class ResultİnBoxMessageDto
    {
        public int MessageId { get; set; }

        public int Sender { get; set; }

        public int Receiver { get; set; }

        public string Subject { get; set; }
        
        public string Detail { get; set; }
        
        public DateTime SendDate { get; set; }
        
        public bool IsRead { get; set; }

        public string UserImageUrl { get; set; }
    }
}