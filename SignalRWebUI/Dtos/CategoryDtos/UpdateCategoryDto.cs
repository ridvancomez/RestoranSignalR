﻿namespace SignalRWebUI.Dtos.CategoryDtos
{
    public class UpdateCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
