﻿namespace DataTransferObjectLayer.Dtos.SubFeatureDtos
{
    public class GetByIdSubFeatureDto
    {
        public int SubFeatureId { get; set; }
        public string Icon { get; set; }
        public string TopTitle { get; set; }
        public string MainTitle { get; set; }
        public string Description { get; set; }
    }
}